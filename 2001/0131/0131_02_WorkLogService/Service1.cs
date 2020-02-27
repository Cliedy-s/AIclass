using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.IO;

namespace _0131_02_WorkLogService
{
    public partial class Service1 : ServiceBase
    {
        Timer timer;
        string orgfolder = ConfigurationManager.AppSettings["OrgFolder"];
        string donefolder = ConfigurationManager.AppSettings["DoneFolder"];
        int interval = int.Parse(ConfigurationManager.AppSettings["ServiceIntervalMilliSecond"]);
        string strconn = ConfigurationManager.ConnectionStrings["mydb"].ConnectionString;

        public Service1()
        {
            InitializeComponent();
        }

        //protected override void OnStart(string[] args)
        //{
        //}
        public void OnStart()
        {
            timer = new Timer(interval);
            timer.Enabled = true;
            timer.Elapsed += Timer_Elapsed;
            timer.AutoReset = true;

            WorkerLoger.WriteLog("윈도우 서비스 프로그램 시작...");
        }

        protected override void OnStop()
        {
            timer.Enabled = false;
            WorkerLoger.WriteLog("윈도우 서비스 프로그램 종료...");
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            WorkerLoger.WriteLog("윈도우 서비스 타이머 호출 시작");
            int icnt = 0;
            try
            { // orgFolder 안의 파일을 선택(1초 이전에 최종수정된 파일 목록)
                string[] files = Directory.GetFiles(orgfolder);
                foreach (string file in files)
                {
                    DateTime edittime = File.GetLastWriteTime(file);
                    if((DateTime.Now - edittime).Seconds > 1)
                    {  // 파일 내용을 읽어서 DB에 Insert
                        //20200131 10:50:45/Machine/1/62/104/1
                        string[] arrData = File.ReadAllText(file).Split('/');
                        if(arrData.Length >= 5)
                        {
                            try
                            {
                                using (SqlCommand comm = new SqlCommand())
                                {
                                    comm.Connection = new SqlConnection(strconn);
                                    comm.CommandText = "INSERT INTO WorkQtyLog (ProductID, MachineID, Qty, BadQty) VALUES(@ProductID, @MachineID, @Qty, @BadQty); ";
                                    comm.Parameters.AddWithValue("@ProductID", int.Parse(arrData[3]));
                                    comm.Parameters.AddWithValue("@MachineID", int.Parse(arrData[2]));
                                    comm.Parameters.AddWithValue("@Qty", int.Parse(arrData[4]));
                                    comm.Parameters.AddWithValue("@BadQty", int.Parse(arrData[5]));


                                    comm.Connection.Open();
                                    comm.ExecuteNonQuery();
                                    comm.Connection.Close();
                                }
                            }
                            catch(Exception ee)
                            {
                                WorkerLoger.WriteErrorLog(ee);
                                continue ;
                            }
                            // 파일 폴더 이동 (orgfolder/file.log -> orgfolder/donefolder/file.log)
                            Console.WriteLine($"move to {file} -> {Path.Combine(donefolder, Path.GetFileName(file))} ");
                            File.Move(file, Path.Combine(donefolder,Path.GetFileName(file)));
                            icnt++;
                        }
                    }
                }

                WorkerLoger.WriteLog($"{icnt}개 파일 이동 완료");
            }
            catch(Exception err)
            {
                WorkerLoger.WriteErrorLog(err);
            }
            finally
            {
                WorkerLoger.WriteLog($"윈도우 서비스 타이머 호출 종료");
            }
        }

    }
}
