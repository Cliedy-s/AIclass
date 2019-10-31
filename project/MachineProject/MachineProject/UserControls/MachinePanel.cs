using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MachineProject
{
    public partial class MachinePanel : UserControl
    {
        public MachinePanel()
        {
            InitializeComponent();
        }
        bool machineState = false;
        public bool MachineState
        {
            get { return machineState; }
            set
            {
                machineState = value;
                if (value)
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
        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always)]
        public string MachineName { get => lblMahineName.Text; set => lblMahineName.Text = value; }
        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always)]
        public int TotalAmount { get => int.Parse(lblTotalAmount_V.Text); set => lblTotalAmount_V.Text = value.ToString(); }
        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always)]
        public int DefectAmount { get => int.Parse(lblDefectAmount_V.Text); set => lblDefectAmount_V.Text = value.ToString(); }
        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always)]
        public double DefectRate { get => double.Parse(lblDefectRate_V.Text); set => lblDefectRate_V.Text = value.ToString(); }
        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always)]
        public double DefectRateAlarm { get => double.Parse(lblDefectRateAlarm_V.Text); set => lblDefectRateAlarm_V.Text = value.ToString(); }

        private void MachinePanel_Load(object sender, EventArgs e)
        {
            // TODO - 기계 테이블에서 갖고오게 변경하기
            MachineState = false;
            panel1.BorderStyle = BorderStyle.FixedSingle;

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

        private void RunMachine()
        {
            this.MachineState = true;
            // TODO - 기계 시작하기
        }
        private void StopMachine()
        {
            this.MachineState = false;
            // TODO - 기계 중지하기
        }

        private void 재시작ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RunMachine();
        }

        private void 일시중지ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StopMachine();
        }
    }

}
