using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookDBClass
{
    public struct Book
    {
        public int bookid;
        public string bookname;
        public string author;
        public string publisher;

        public Book(int bookid, string bookname, string author, string publisher)
        {
            this.bookid = bookid;
            this.bookname = bookname;
            this.author = author;
            this.publisher = publisher;
        }
    }
    public class BookDB : IDisposable
    {
        MySqlConnection conn = null;
        public BookDB()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["goodeeConnectionString"].ConnectionString;
            //string connectionString = "server=127.0.0.1; uid=root; pwd=1234; port=3306; database=goodeeproject";
            conn = new MySqlConnection(connectionString);
            conn.Open();
        }
        public string Insert(Book book)
        {
            string sql = string.Format("INSERT INTO book (bookid, bookname, author, publisher) VALUES({0}, '{1}', '{2}', '{3}'); ", book.bookid, book.bookname, book.author, book.publisher);
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
            string sql = "SELECT bookid, bookname, author, publisher FROM book WHERE deleted = 0; ";
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(sql, conn);
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
        public bool IsValid(int bookID)
        {
            string sql = string.Format("SELECT count(*) FROM book WHERE bookid = {0}; ", bookID);
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            if (Convert.ToInt32(cmd.ExecuteScalar()) == 0)
                return false;
            return true;
        }
        /// <summary>
        /// 예약 : true 예약x : false
        /// </summary>
        public bool IsLended(int bookID)
        {
            string sql = string.Format("SELECT LendingState FROM book WHERE bookid = {0}; ", bookID);
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            if (Convert.ToInt32(cmd.ExecuteScalar()) == 0)
                return false;
            return true;
        }
        /// <summary>
        /// 예약한 사람o : true, 예약한 사람x : false
        /// </summary>
        public bool IsBooked(int bookID, int stdID)
        { // 해당 학생이 해당 책을 예약했는지?
            string sql = string.Format("SELECT Count(*) FROM book WHERE bookid = {0} and ReserveStuID = {1}; ", bookID, stdID);
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            if (Convert.ToInt32(cmd.ExecuteScalar()) == 0)
                return false;
            return true;
        }
        //public int IsBooked(int bookID)
        //{
        //    string sql = string.Format("SELECT ReserveStuID FROM book WHERE bookid = {0}; ", bookID);
        //    MySqlCommand cmd = new MySqlCommand(sql, conn);
        //    return Convert.ToInt32(cmd.ExecuteScalar());
        //}
        /// <summary>
        /// 예약한 책
        /// </summary>
        public bool IsBooked(int bookID)
        { // 책이 예약돼있는지?
            string sql = string.Format("SELECT Count(*) FROM book WHERE bookid = {0} and ReserveStuID is not null; ", bookID);
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            if (Convert.ToInt32(cmd.ExecuteScalar()) == 0)
                return false;
            return true;
        }

        public Book GetbyBookID(int bookID)
        {
            Book BookInfo = new Book();
            string cmdText = string.Format("SELECT bookid, bookname, author, publisher FROM Book WHERE BOOKID={0} AND Deleted =0; ",bookID );
            MySqlCommand cmd = new MySqlCommand(cmdText, conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                BookInfo.bookid = Convert.ToInt32(reader["bookid"]);
                BookInfo.bookname = reader["bookname"].ToString();
                BookInfo.author = reader["author"].ToString();
                BookInfo.publisher = reader["publisher"].ToString();
            }
            return BookInfo;
        }
    }
}
