using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using Helper_1230;

namespace _1231_01_MVC_Board.Models
{
    public class Board
    {
        [DisplayName("글번호")]
        public int SEQ { get; set; }
        [DisplayName("작성자")]
        public string Name { get; set; }
        [DisplayName("제목")]
        public string Subject { get; set; }
        [DisplayName("내용")]
        public string Contents { get; set; }
        [DisplayName("작성일자")]
        [DisplayFormat(DataFormatString ="{0:yyyy-MM-dd}")]
        public string WriteTime { get; set; }
        [DisplayName("조회수")]
        public int ReadCount { get; set; }
    }
    public class BoardManager
    {
        public List<Board> GetAllList()
        {
            List<Board> list = new List<Board>();
            string sql = @"
                                SELECT [SEQ]
                                      ,[Name]
                                      ,[Subject]
                                      ,[Contents]
                                      ,convert(varchar(10), [WriteTime], 23) as WriteTime
                                      ,[ReadCount]
                              FROM [SampleDB].[dbo].[BBS]
                              ORDER BY SEQ DESC; ";
            SqlConnection conn = new SqlConnection(WebConfigurationManager.ConnectionStrings["board"].ConnectionString);
            SqlCommand comm = new SqlCommand(sql, conn);

            conn.Open();
            SqlDataReader reader = comm.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new Board() { Name = reader["Name"].ToString()
                    , Contents = reader["Contents"].ToString()
                    , ReadCount = Convert.ToInt32(reader["ReadCount"])
                    , SEQ = Convert.ToInt32(reader["SEQ"])
                    , Subject = reader["Subject"].ToString()
                    , WriteTime = Convert.ToString(reader["WriteTime"]) });
            }
            //list = Helper.DataReaderMapToList<Board>(reader);
            conn.Close();

            return list;
        }
        public bool BoardUpdate(int id, Board post)
        {
            string sql = @"UPDATE [dbo].[BBS]
                                   SET [Name] = @Name
                                      ,[Subject] = @Subject
                                      ,[Contents] = @Contents
                                      ,[WriteTime] = getdate()
                                 WHERE SEQ=@SEQ; ";

            SqlConnection conn = new SqlConnection(WebConfigurationManager.ConnectionStrings["board"].ConnectionString);
            SqlCommand comm = new SqlCommand(sql, conn);

            comm.Parameters.AddWithValue("@SEQ", id);
            comm.Parameters.AddWithValue("@Name", post.Name);
            comm.Parameters.AddWithValue("@Subject", post.Subject);
            comm.Parameters.AddWithValue("@Contents", post.Contents); // raw만 쓸 경우 string.Replace("\r\n", "<br/>)

            conn.Open();
            int cnt = comm.ExecuteNonQuery();
            conn.Close();

            return (cnt > 0);
        }

        internal bool BoardDelete(int id, Board post)
        {
            string sql = @"DELETE FROM [dbo].[BBS]
                                WHERE SEQ=@SEQ; ";

            SqlConnection conn = new SqlConnection(WebConfigurationManager.ConnectionStrings["board"].ConnectionString);
            SqlCommand comm = new SqlCommand(sql, conn);

            comm.Parameters.AddWithValue("@SEQ", id);

            conn.Open();
            int cnt = comm.ExecuteNonQuery();
            conn.Close();

            return (cnt > 0);
        }

        public Board GetBoardByID(int id, bool isView)
        {
            Board item = null;
            string sql = @"SELECT [SEQ]
                                      ,[Name]
                                      ,[Subject]
                                      ,[Contents]
                                      ,[WriteTime]
                                      ,[ReadCount]
                              FROM [SampleDB].[dbo].[BBS]
                              WHERE SEQ = @SEQ; ";
            if (isView)
            {
                sql.Insert(0, "UPDATE BBS SET ReadCount = ReadCount + 1 WHERE SEQ = @SEQ; ");
            }

            SqlConnection conn = new SqlConnection(WebConfigurationManager.ConnectionStrings["board"].ConnectionString);
            SqlCommand comm = new SqlCommand(sql, conn);

            comm.Parameters.AddWithValue("@SEQ", id);

            conn.Open();
            SqlDataReader reader = comm.ExecuteReader();
            if (reader.Read())
            {
                item = new Board()
                {
                    SEQ = Convert.ToInt32(reader["SEQ"]),
                    Name = reader["Name"].ToString(),
                    Contents = reader["Contents"].ToString(),
                    ReadCount = Convert.ToInt32(reader["ReadCount"]),
                    Subject = reader["Subject"].ToString(),
                    WriteTime = reader["WriteTime"].ToString()
                };
            }
            //list = Helper.DataReaderMapToList<Board>(reader);
            conn.Close();

            return item;
        }
        public bool BoardInsert(Board board)
        {
            string sql = @"INSERT INTO BBS
           (Name
           ,Subject
           ,Contents
           ,WriteTime
           ,ReadCount)
     VALUES
           (@Name
           ,@Subject
           ,@Contents
           ,getdate()
           ,0); ";

            SqlConnection conn = new SqlConnection(WebConfigurationManager.ConnectionStrings["board"].ConnectionString);
            SqlCommand comm = new SqlCommand(sql, conn);

            comm.Parameters.AddWithValue("@Name", board.Name);
            comm.Parameters.AddWithValue("@Subject", board.Subject);
            comm.Parameters.AddWithValue("@Contents", board.Contents);// raw만 쓸 경우 string.Replace("\r\n", "<br/>)

            conn.Open();
            int cnt= comm.ExecuteNonQuery();
            conn.Close();

            return (cnt > 0);
                
        }
    }
}