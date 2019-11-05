using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MachineProject.Services;
using System.IO;
using MachineProject.DTO;
using System.Configuration;
using System.Diagnostics;

namespace MachineProject
{
    public partial class MachinePanel : UserControl
    {
        public MachinePanel()
        {
            // 생성자 => control을 보여줄 상태 준비x
            // Load => control을 보여줄 상태 준비 o
            InitializeComponent();
        }

        private string filePath;
        private int machineState = 0;
        private TodoDTO runningDTO = null;
        private TodoDTO RunningTODO { get { return runningDTO; } set { runningDTO = value; lblRunningDTO.Text = runningDTO.TodoCode.ToString(); } }
        public int MachineState
        {
            get { return machineState; }
            set
            {
                machineState = value;
                if (value == 1)
                {
                    picGreenLight.Image = imageList1.Images[1]; // 켜진 그린라이트
                    picRedLight.Image = imageList1.Images[2]; // 꺼진 레드라이트
                }
                else
                {
                    picGreenLight.Image = imageList1.Images[0]; // 꺼진 그린라이트
                    picRedLight.Image = imageList1.Images[3]; // 켜진 레드라이트
                }
            }
        }
        public string MachineName { get => lblMahineName.Text; set => lblMahineName.Text = value; }
        public int TotalAmount { get => int.Parse(lblTotalAmount_V.Text); set => lblTotalAmount_V.Text = value.ToString(); }
        public int NomalAmount { get => int.Parse(lblNomalAmount_V.Text); set => lblNomalAmount_V.Text = value.ToString(); }
        public int DefectAmount { get => int.Parse(lblDefectAmount_V.Text); set => lblDefectAmount_V.Text = value.ToString(); }
        public double DefectRate { get => double.Parse(lblDefectRate_V.Text); set => lblDefectRate_V.Text = value.ToString(); }
        public double DefectRateAlarm { get => double.Parse(lblDefectRateAlarm_V.Text); set => lblDefectRateAlarm_V.Text = value.ToString(); }

        private void MachinePanel_Load(object sender, EventArgs e)
        {
            rand = new Random();
            // get App.Settings
            fileWriteinterval = Convert.ToInt32(ConfigurationManager.AppSettings["fileCreateInterval"]);
            runTimer.Interval = Convert.ToInt32(ConfigurationManager.AppSettings["fileWriteInterval"]);
            // TODO - 기계 테이블에서 갖고오게 변경하기
            MachineState = 0; // 현재 꺼져있음
            panel1.BorderStyle = BorderStyle.FixedSingle; // 바깥 테두리 주기

            // 더블클릭 이벤트 설정
            panel1.DoubleClick += All_DoubleClick;
            foreach (Control item in panel1.Controls)
            {
                item.DoubleClick += All_DoubleClick;
            }
        }
        private void All_DoubleClick(object sender, EventArgs e)
        {
            if (doubleClick != null)
            {
                MachineStringsEventArgs E = new MachineStringsEventArgs();
                E.ReturnValues = new values(MachineName, TotalAmount, DefectAmount, DefectRate, DefectRateAlarm);
                doubleClick(this, E);
            }
        }

        public delegate void MachineEventHandler(object sender, MachineStringsEventArgs e);
        public delegate void SetBackGroundHandler(string machineID, Color color);
        public event SetBackGroundHandler setDgvBackground;
        public event MachineEventHandler doubleClick;
        public class MachineStringsEventArgs : EventArgs
        {
            public values ReturnValues { get; set; }
        }
        public struct values
        {
            public string MachineName;
            public int TotalAmount;
            public int DefectAmount;
            public double DefectRate;
            public double DefectRateAlarm;
            public values(string machineName, int totalAmount, int defectAmount, double defectRate, double defectRateAlarm)
            {
                MachineName = machineName;
                TotalAmount = totalAmount;
                DefectAmount = defectAmount;
                DefectRate = defectRate;
                DefectRateAlarm = defectRateAlarm;
            }
        }

        public void SetWork(TodoDTO todo)
        {
            RunningTODO = todo;
        }
        public void RunMachine()
        {
            try
            {
                if (RunningTODO == null) // 실행항목이 설정됐는지?
                    throw new Exception(Properties.Resources.Error_MachineNotSetedWork_msg);

                // 실행
                setDgvBackground?.Invoke(MachineName, Color.LightGreen);
                this.MachineState = 1;
                MachineService service02 = new MachineService();
                service02.UpdateRunState(MachineName, true);
                service02.Dispose();
                FileCreate();
                runTimer.Start();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }

        } // 기계 시작하기
        public void StopMachine()
        {
            try
            {
                if (RunningTODO == null)
                    throw new Exception(Properties.Resources.Error_MachineNotSetedWork_msg);

                // 중지
                setDgvBackground?.Invoke(MachineName, Color.OrangeRed);
                this.MachineState = 0;
                // db 업데이트
                MachineService service = new MachineService();
                service.UpdateRunState(MachineName, false);
                service.Dispose();
                // 타이머 멈추기
                runTimer.Stop();
                // 쓰는 파일 멈추기
                writer.Flush();
                writer.Close();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        } // 기계 멈추기
        private void FileCreate()
        {
            if(writer != null)
            {
                writer.Flush();
                writer.Close();
            }
            // 폴더 없을 경우 생성
            string dPath = string.Format("Productions/Running/{0}/", MachineName);
            if (!Directory.Exists(dPath))
                Directory.CreateDirectory(dPath);

            // 파일 없을 경우 생성
            string fPath = dPath + DateTime.Now.ToString("yyyyMMddHHmmss") + ".txt";
            if (!File.Exists(fPath))
                File.Create(fPath).Close();

            filePath = Environment.CurrentDirectory + "\\" + fPath;
            writer = new StreamWriter(filePath, true, Encoding.UTF8);
        } // 호출 시 마다 해당 기계와 현재 시간을 갖고와서 폴더와 파일을 만든다. 

        private void 재시작ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // 이미 생산중인 기계인지?
                MachineService service = new MachineService();
                bool isRunning = service.GetRunState(MachineName);
                service.Dispose();
                if (isRunning)
                    throw new Exception(Properties.Resources.Error_MachineAlreadyRun_msg);
                //
                RunMachine();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        } // == RunMachine
        private void 일시중지ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StopMachine();
        } // == StopMachine

        Random rand; // load에서 생성함
        int intervalCount = 0;
        int fileWriteinterval;
        StreamWriter writer;
        private void RunTimer_Tick(object sender, EventArgs e)
        {
            try
            {
                int totalAmount = 0;
                int defectedAmount = 0;
                int nomalAmount;
                DateTime now = DateTime.Now;
                Debug.WriteLine("{0} {1}", intervalCount, fileWriteinterval);
                intervalCount += runTimer.Interval;
                if (intervalCount >= fileWriteinterval)
                {
                    intervalCount %= fileWriteinterval;
                    FileCreate(); // 폴더와 파일을 만들어서 현재 쓰는 경로에 저장
                }
                // 파일 생성 및 입력
                for (int i = 0; i < 10; i++)
                {
                    totalAmount++;
                    if (rand.Next(0, 10) / 2 == 0) { defectedAmount++; }
                }
                nomalAmount = totalAmount - defectedAmount;

                writer.WriteLine("{0}|{1}|{2}|{3}|{4,5}|{5,5}|{6, 5}|{7}", RunningTODO.TodoCode, now.ToString("HH:mm:ss"), RunningTODO.ProductionID, RunningTODO.EmployeeID, totalAmount, nomalAmount, defectedAmount, MachineName);
            }
            catch (Exception ee)
            {
                StopMachine();
                MessageBox.Show(ee.Message);
            }
        }
    }

}
