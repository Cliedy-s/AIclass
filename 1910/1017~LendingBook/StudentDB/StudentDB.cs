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
            string connectionString = ConfigurationManager.ConnectionStrings["goodeeConnectionString"].ConnectionString;
            //string connectionString = "server=127.0.0.1; uid=root; pwd=1234; port=3306; database=goodeeproject";
            conn = new MySqlConnection(connectionString);
            conn.Open();
        }
        public void Insert(Student std)
        {
            string sql = string.Format("INSERT INTO student (studentid, studentname, department) VALUES({0}, '{1}','{2}'); ", std.ID, std.Name, std.Dept);
            MySqlCommand command = new MySqlCommand(sql, conn);
            int resultCount = command.ExecuteNonQuery();
        }
        public void Update(Student std)
        {
            string sql = string.Format("UPDATE student SET studentname = '{1}', department = '{2}' WHERE studentid = {0}; ", std.ID, std.Name, std.Dept);
            MySqlCommand command = new MySqlCommand(sql, conn);
            int resultCount = command.ExecuteNonQuery();
        }
        public void Delete(int stdID)
        {
            string sql = string.Format("DELETE FROM student WHERE studentid = {0}; ", stdID);
            // 이미 삭제된 학생인지 체크
            if (isDeleted(stdID))
                throw new Exception("이미 삭제된 학생입니다");
            // 대여하고 있거나 대여한 책이 있거나 예약된 도서가 있는지 체크
            // fk..확인
            MySqlCommand command = new MySqlCommand(sql, conn);
            int resultCount = command.ExecuteNonQuery();
        }
        public bool isDeleted(int stdID)
        {
            string sql = string.Format("SELECT deleted FROM student WHERE studentid = {0}; ", stdID);
            MySqlCommand command = new MySqlCommand(sql, conn);
            int resultCount = Convert.ToInt32(command.ExecuteScalar());
            if (resultCount == 1)
                return true;
            else
                return false;
        }
        public DataSet GetAll()
        {
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter("SELECT studentid, studentname, department FROM student WHERE deleted = 0; ", conn);
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
