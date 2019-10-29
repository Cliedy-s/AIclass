using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace _1028_01_ADO.NET
{
    // Data Access Component
    public class MemberInfoDAC
    {
        MySqlConnection conn;
        public MemberInfoDAC(MySqlConnection conn)
        {
            this.conn = conn;
        }

        public void Insert(MemberInfoVO item)
        {
            string sql = "INSERT INTO memberinfo(Name, Birth, Email, Family) values(@Name, @Birth, @Email, @Family); ";
            MySqlCommand comm = new MySqlCommand(sql, conn);
            FillParameters(comm, item);
            comm.ExecuteNonQuery();
        }

        public void Update(MemberInfoVO item)
        {
            string sql = "UPDATE memberinfo SET Birth=@Birth, Email=@Email, Family=@Family WHERE Name=@Name; ";
            MySqlCommand comm = new MySqlCommand(sql, conn);
            FillParameters(comm, item);
            comm.ExecuteNonQuery();
        }

        public void Delete(MemberInfoVO item)
        {
            string sql = "DELETE FROM memberinfo WHERE Name=@Name; ";
            MySqlCommand comm = new MySqlCommand(sql, conn);
            FillParameters(comm, item);
            comm.ExecuteNonQuery();
        }

        public List<MemberInfoVO> SelectAll()
        {
            string sql = "SELECT Name, Birth, Email, Family FROM memberinfo; ";
            List<MemberInfoVO> list = new List<MemberInfoVO>();

            MySqlCommand comm = new MySqlCommand(sql, conn);
            using (MySqlDataReader reader = comm.ExecuteReader())
            {
                while (reader.Read())
                {
                    MemberInfoVO item = new MemberInfoVO()
                    {
                        Name = reader["Name"].ToString(),
                        Birth = Convert.ToDateTime(reader["Birth"]),
                        Email = reader["Email"].ToString(),
                        Family = Convert.ToByte(reader["Family"])
                    };
                    list.Add(item);
                }
            }
            return list;
        }
        public DataTable SelectAll(bool b)
        {
            string sql = "SELECT Name, Birth, Email, Family FROM memberinfo; ";

            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        private void FillParameters(MySqlCommand comm, MemberInfoVO item)
        {
            //MySqlParameter param1 = new MySqlParameter("Name", MySqlDbType.VarChar, 30);
            //param1.Value = item.Name;
            //comm.Parameters.Add(param1);

            comm.Parameters.Add("@Name", MySqlDbType.VarChar, 30);
            comm.Parameters["@Name"].Value = item.Name;

            comm.Parameters.Add("@Birth", MySqlDbType.DateTime);
            comm.Parameters["@Birth"].Value = item.Birth;

            comm.Parameters.Add("@Email", MySqlDbType.VarChar, 50);
            comm.Parameters["@Email"].Value = item.Email;

            comm.Parameters.Add("@Family", MySqlDbType.Byte);
            comm.Parameters["@Family"].Value = item.Family;
        }
    }


    // Value Object // (==) DTO Data Transfer Object
    public class MemberInfoVO
    {
        public string Name { get; set; }
        public DateTime Birth { get; set; }
        public string Email { get; set; }
        public byte Family { get; set; }
    }
}
