using BookDBClass;
using MySql.Data.MySqlClient;
using StudentDB;
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
        /// <summary>
        /// 책을 학생이 대여중인지?
        /// </summary>
        public bool IsLendbyStudentID(int studentID, int bookID)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("select count(*) from lending l ");
            sql.Append("inner join lendingitem li on l.lendingID = li.lendingID ");
            sql.Append(string.Format("where l.studentid = {0} and li.bookid = {1} ", studentID, bookID));
            sql.Append("and li.returndate = null; ");
            MySqlCommand cmd = new MySqlCommand(sql.ToString(), conn);
            if (Convert.ToInt32(cmd.ExecuteScalar()) == 0)
                return false;
            return true;
        }
        public void Reserve(int studentID, int bookID)
        {
            // 체크
            // 유효한 학생인지?
            StudentDB.StudentDB studentdb = new StudentDB.StudentDB();
            if (!studentdb.isValied(studentID))
            {
                studentdb.Dispose();
                throw new Exception("학번을 확인해 주세요");
            }
            studentdb.Dispose();

            // 존재하는 책인지?
            BookDB bookdb = new BookDB();
            if (!bookdb.IsValid(bookID))
            {
                bookdb.Dispose();
                throw new Exception("책 번호를 확인해 주세요");
            }
            // 이미 예약한 책인지?
            if (bookdb.IsBooked(bookID))
            {
                bookdb.Dispose();
                throw new Exception("이미 예약한 책입니다.");
            }
            // 이미 대여중인 책인지?
            if (!bookdb.IsLended(bookID))
            {
                bookdb.Dispose();
                throw new Exception("대여 가능한 책입니다.");
            }
            else // 1.대여 중일 경우 => 예약o, 2.내 책을 예약할 경우
            {
                // 현재 대여 중인 학생인지 체크
                if (IsLendbyStudentID(studentID, bookID))
                {
                    bookdb.Dispose();
                    throw new Exception("이미 대여한 책입니다.");
                }
            }
            bookdb.Dispose();

            // 실행
            MySqlCommand command = new MySqlCommand("", conn);
            command.CommandText = "update book set reservestuid =@studentID  where bookid = @bookID;";
            command.Parameters.Add(new MySqlParameter("@studentID", MySqlDbType.Int32));
            command.Parameters.Add(new MySqlParameter("@bookID", MySqlDbType.Int32));

            command.Parameters["@studentID"].Value = studentID;
            command.Parameters["@bookID"].Value = bookID;

            command.ExecuteNonQuery();
        }
        public void LendBook(int studentID, int[] bookIDs)
        {
            // 재학중인 학생인지?
            StudentDB.StudentDB studentDB = new StudentDB.StudentDB();
            if (!studentDB.isValied(studentID))
            {
                throw new Exception("학번을 확인해주세요.");
            }
            studentDB.Dispose();
            // 반납했는지?
            // 존재하는 도서인지?
            // 이미 빌려간 도서인지?
            // 누가 예약했는지?
            // 같은 책이 들어있는지?

            // BeginTransaction 
            MySqlTransaction transaction = conn.BeginTransaction();
            try
            {
                // Set Command
                MySqlCommand command = new MySqlCommand("", conn, transaction);
                command.CommandText = string.Format("INSERT INTO lending( studentid, lenddate) values({0}, now()); SELECT last_insert_id(); ", studentID);

                MySqlCommand insertCommand = new MySqlCommand("", conn, transaction);
                insertCommand.CommandText = "INSERT INTO lendingitem(lendingid, bookitem, bookid) VALUES(@lendingid, @bookitem, @bookid); ";
                insertCommand.Parameters.Add(new MySqlParameter("@lendingid", MySqlDbType.Int32));
                insertCommand.Parameters.Add(new MySqlParameter("@bookitem", MySqlDbType.Int32));
                insertCommand.Parameters.Add("@bookid", MySqlDbType.Int32); // ?

                MySqlCommand updateCommand = new MySqlCommand("", conn, transaction);
                updateCommand.CommandText = "UPDATE book SET lendingstate = 1 WHERE bookid = @bookid; ";
                updateCommand.Parameters.Add(new MySqlParameter("@bookid", MySqlDbType.Int32));

                MySqlCommand updateStudentCommand = new MySqlCommand("", conn, transaction);
                updateStudentCommand.CommandText = "UPDATE book SET reservestuid =null where bookid =@bookid and reservestuid = @studid; ";
                updateStudentCommand.Parameters.Add(new MySqlParameter("@bookid", MySqlDbType.Int32));
                updateStudentCommand.Parameters.Add(new MySqlParameter("@studid", MySqlDbType.Int32));
                //

                // Execute
                int last_insert_id = Convert.ToInt32(command.ExecuteScalar().ToString());
                insertCommand.Parameters["@lendingid"].Value = last_insert_id;
                for (int i = 0; i < bookIDs.Length; i++)
                {
                    insertCommand.Parameters["@bookitem"].Value = i + 1;
                    insertCommand.Parameters["@bookid"].Value = bookIDs[i];
                    insertCommand.ExecuteNonQuery();

                    updateCommand.Parameters["@bookid"].Value = bookIDs[i];
                    updateCommand.ExecuteNonQuery();

                    updateStudentCommand.Parameters["@studid"].Value = studentID;
                    updateStudentCommand.Parameters["@bookid"].Value = bookIDs[i];
                    updateStudentCommand.ExecuteNonQuery();
                }
                //

                transaction.Commit();
            }
            catch (Exception)
            {
                transaction.Rollback();
            }
            // EndTransaction
        }
        public void ReturnBook(int bookID)
        {
            string update01 = "UPDATE book SET lendingstate = b'0' WHERE bookid = @bookid; ";
            string update02 = "UPDATE lendingitem SET returndate = now() WHERE bookid = @bookid AND returndate = null; ";

            MySqlTransaction transaction = conn.BeginTransaction();
            try
            {
                //
                MySqlCommand update01command = new MySqlCommand();
                update01command.Connection = conn;
                update01command.CommandText = update01;
                update01command.Transaction = transaction;
                update01command.Parameters.Add(new MySqlParameter("@bookid", MySqlDbType.Int32));
                update01command.Parameters["@bookid"].Value = bookID;
                update01command.ExecuteNonQuery();
                //
                MySqlCommand update02command = new MySqlCommand();
                update02command.Connection = conn;
                update02command.CommandText = update02;
                update02command.Transaction = transaction;
                update02command.Parameters.Add(new MySqlParameter("@bookid", MySqlDbType.Int32));
                update02command.Parameters["@bookid"].Value = bookID;
                update02command.ExecuteNonQuery();

                transaction.Commit();
            }
            catch (Exception)
            {
                transaction.Rollback();
            }
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
        public DataSet GetLendingItem()
        {
            string sql = "select bookid, max(returndate) from lendingitem group by bookid; ";
            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn);
            adapter.SelectCommand.CommandText = sql;
            adapter.SelectCommand.Connection = conn;

            DataSet ds = new DataSet();
            adapter.Fill(ds, "LendingItem");

            return ds;
        }
        public DataSet GetLog()
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataSet ds = new DataSet();

            adapter.SelectCommand =new MySqlCommand("select lendingid, l.studentid, lenddate, studentname from student s inner join lending l on s.studentid = l.studentid; ");
            adapter.SelectCommand.Connection = conn;
            adapter.Fill(ds, "lending");

            adapter.SelectCommand = new MySqlCommand("select lendingid, bookitem, b.bookid, bookname, returndate from book b inner join lendingitem li on b.bookid = li.bookid; ");
            adapter.SelectCommand.Connection = conn;
            adapter.Fill(ds, "lendingitem");

            ds.Relations.Add("lendingrel", ds.Tables["lending"].Columns["lendingid"], ds.Tables["lendingitem"].Columns["lendingid"]);

            return ds;
        }
        public void Dispose()
        {
            conn.Close();
        }

    }
}
