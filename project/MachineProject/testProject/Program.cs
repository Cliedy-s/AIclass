using MachineProject.DTO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace testProject
{
    class Program
    {
        static void Main(string[] args)
        {
            MachineService service = new MachineService();
            //service.SetPath(@"C:");
            //
            service.SetPath(@"D:\AIclass\project\MachineProject\MachineProject\bin\Debug");
            try
            {
                service.MoveToStoring();
            }
            catch (Exception ee)
            {
                Console.WriteLine(ee.Message);
            }
        }
    }
    public class MachineService
    {
        int ReadInterval;
        string connstr;
        public string path;
        List<MachineDTO> machines;

        public MachineService()
        {
            // TODO - Exception이 모두 코드에 박혀있음
            ReadInterval = Convert.ToInt32(ConfigurationManager.AppSettings["ReadInterval"]);
            connstr = ConfigurationManager.ConnectionStrings["MachineProjectConnStr"].ConnectionString;
            machines = new List<MachineDTO>();

            //serverThread = new Thread(() => { ServiceLoop(); });
        }
        public void Start()
        {
            //serverThread.Start();
        }
        public void Stop()
        {
            //serverThread.Abort();
        }
        public void SetPath(string path)
        {
            this.path = path;
        }
        // toPrivate
        public void ServiceLoop()
        {
            while (true)
            {
                GetMachineState();
                if (machines.Count > 0)
                {

                }
                Thread.Sleep(ReadInterval);
            }
        }
        // toPrivate
        public void MoveToStoring()
        {
            // TODO - 빈 파일일 경우 그냥 삭제한다.
            string runningPath = string.Format(@"{0}\Productions\Running", path);
            string storingPath = string.Format(@"{0}\Productions\Storing", path);
            string storedPath = string.Format(@"{0}\Productions\Stored", path);

            if (Directory.Exists(storingPath))
            {
                return;
                //throw new Exception("처리 중인 파일이 존재합니다.");
            }
            if (!Directory.Exists(runningPath))
            {
                return;
                //throw new Exception("기계가 실행 중인지 확인해 주세요");
            }
            CopyFolder(runningPath, storingPath, true);
        }
        // toPrivate
        public void MoveToStored()
        {
            string runningPath = string.Format(@"{0}\Productions\Running", path);
            string storingPath = string.Format(@"{0}\Productions\Storing", path);
            string storedPath = string.Format(@"{0}\Productions\Stored", path);

            // 폴더 없을 경우 생성
            if (!Directory.Exists(storedPath))
                Directory.CreateDirectory(storedPath);
            if (!Directory.Exists(storingPath))
            {
                //return;
                throw new Exception("처리된 파일이 없습니다.");
            }
            #region 폴더복사
            //// storing => stored
            //List<string> childFiles = new List<string>();
            //string[] childDirectories = Directory.GetDirectories(storingPath);

            //// 파일 경로들 갖고오기
            //foreach (var item in childDirectories)
            //{
            //    childFiles.Add(item);
            //}
            //foreach (var item in childDirectories)
            //{
            //    string[] arr = Directory.GetFiles(item);
            //    for (int i = 0; i < arr.Length; i++)
            //    {
            //        childFiles.Add(arr[i]);
            //    }
            //}
            //// 옮기기
            //foreach (var item in childFiles)
            //{
            //    if (!item.Contains("."))
            //    { //폴더일 때
            //        string folderPath = storedPath + item.Substring(item.LastIndexOf('\\'));
            //        if (!Directory.Exists(folderPath))
            //            Directory.CreateDirectory(item);
            //    }
            //    else
            //    { //파일일 때
            //        string filePath = storedPath + item.Substring(item.LastIndexOf("Storing")+7);
            //        File.Copy(item, filePath, true);
            //    }
            //}

            #endregion
            CopyFolder(storingPath, storedPath, true);
            Directory.Delete(storingPath, true);
        }
        // 폴더 복사 ( 재귀함수 )
        private void CopyFolder(string sourceFolder, string destFolder, bool append = false)
        {
            if (!Directory.Exists(destFolder))
                Directory.CreateDirectory(destFolder);

            string[] files = Directory.GetFiles(sourceFolder);
            string[] folders = Directory.GetDirectories(sourceFolder);

            foreach (string file in files)
            {
                string name = Path.GetFileName(file);
                string dest = Path.Combine(destFolder, name);
                File.Copy(file, dest, append);
            }

            foreach (string folder in folders)
            {
                string name = Path.GetFileName(folder);
                string dest = Path.Combine(destFolder, name);
                CopyFolder(folder, dest, append);
            }
        }
        // toPrivate
        public void PushToDB()
        {
            // Read Files
            StreamReader reader = new StreamReader(path, Encoding.UTF8);


            // Push To DB
            //MySqlConnection conn = new MySqlConnection(connstr);
            //MySqlCommand comm = new MySqlCommand("SELECT MachineID, isRunning FROM MACHINE WHERE isRunning =1; ", conn);

            //conn.Open();
            //MySqlDataReader reader = comm.ExecuteReader();
            //conn.Close();
            //while (reader.Read())
            //    machines.Add(new MachineDTO() { MachineID = reader["MachineID"].ToString(), IsRunning = Convert.ToInt32(reader["isRunning"]) });
        }
        // toPrivate
        public void GetMachineState()
        {
            machines.Clear();
            MySqlConnection conn = new MySqlConnection(connstr);
            MySqlCommand comm = new MySqlCommand("SELECT MachineID, isRunning FROM MACHINE WHERE isRunning =1; ", conn);

            conn.Open();
            MySqlDataReader reader = comm.ExecuteReader();
            conn.Close();
            while (reader.Read())
                machines.Add(new MachineDTO() { MachineID = reader["MachineID"].ToString(), IsRunning = Convert.ToInt32(reader["isRunning"]) });
        }
    }
}
