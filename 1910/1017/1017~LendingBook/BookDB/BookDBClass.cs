using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookDBClass
{
    public struct Book
    {
        public string bookid;
        public string bookname;
        public string author;
        public string publisher;

        public Book(string bookid, string bookname, string author, string publisher)
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
            //string connectionString = ConfigurationManager.ConnectionStrings["goodeeConnectionString"].ConnectionString;
            string connectionString = "server=127.0.0.1; uid=root; pwd=1234; port=3306; database=goodeeproject";
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
    }
}
