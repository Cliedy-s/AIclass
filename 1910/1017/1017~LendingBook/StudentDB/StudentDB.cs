using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDB
{
    public struct Student
    {
        public int ID;
        public string Name;
        public string Dept;

        public Student(int iD, string name, string dept)
        {
            ID = iD;
            Name = name;
            Dept = dept;
        }
    }

    public class StudentDB : IDisposable
    {
        MySqlConnection conn = null;
        public StudentDB()
        {
            //string connectionString = ConfigurationManager.ConnectionStrings["goodeeConnectionString"].ConnectionString;
            string connectionString = "server=127.0.0.1; uid=root; pwd=1234; port=3306; database=goodeeproject";
            conn = new MySqlConnection(connectionString);
            conn.Open();
        }
        public string Insert(Student std)
        {
            string sql = string.Format("INSERT INTO student (studentid, studentname, department) VALUES({0}, '{1}','{2}'); ", std.ID, std.Name, std.Dept);
            try
            {
                MySqlCommand command = new MySqlCommand(sql, conn);
                int resultCount = command.ExecuteNonQuery();
                return "입력성공!";
            }
            catch
            {
                return "실패!";
            }
        }
        public DataSet GetAll()
        {
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter("SELECT studentid, studentname, department FROM student WHERE deleted = 0; ",conn);
            //dataAdapter.SelectCommand.CommandText = "SELECT studentid, studentname, department FROM student WHERE deleted = 0; ";
            //dataAdapter.SelectCommand.Connection = conn;
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds, "Student");
            return ds;
        }

        public void Dispose()
        {
            conn.Close();
        }
    }
}
