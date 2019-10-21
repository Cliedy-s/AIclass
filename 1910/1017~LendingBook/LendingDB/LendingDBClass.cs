using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LendingDBClass
{
    public struct Lending
    {
        public int StudentID { get; set; }
        public int[] BookID { get; set; }
    }
    public class LendingDB : IDisposable
    {
        MySqlConnection conn;
        public LendingDB() 
        {
            conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["goodeeConnectionString"].ConnectionString);
            conn.Open();
        }

        public void Insert()
        {
            string insertsql = "INSERT";
            MySqlCommand command = new MySqlCommand();
            // 재학중인 학생인지?
            // 반납했는지?
            // 존재하는 도서인지?
            // 이미 빌려간 도서인지?
            // 누가 예약했는지?
            // 같은 책이 들어있는지?
        }
        public void Update()
        {

        }

        public void Delete() { 

        }

        public DataSet GetAll()
        {
            string sql = "SELECT bookid, bookname, author, publisher, ifnull(reservestuid, 0) as reservestuid, lendingstate FROM book where deleted = b'0'";
            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn);
            adapter.SelectCommand.CommandText = sql;
            adapter.SelectCommand.Connection = conn;

            DataSet ds = new DataSet();
            adapter.Fill(ds, "Book");

            return ds;
        }

        public void Dispose()
        {
            conn.Close();
        }
    }
}
