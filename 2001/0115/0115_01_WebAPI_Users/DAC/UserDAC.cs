using DTO;
using Helper_1230;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace _0115_01_WebAPI_Users.DAC
{
    public class UserDAC
    {
        string strConn = string.Empty;
        public UserDAC()
        {
            this.strConn = WebConfigurationManager.ConnectionStrings["db"].ConnectionString;
        }
        public List<UserVO> GetAllUsers()
        {
            string sql = "GetUsers";
            List<UserVO> list = new List<UserVO>();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                using(SqlCommand comm = new SqlCommand(sql, conn))
                {
                    comm.CommandType = CommandType.StoredProcedure;
                    
                    conn.Open();
                    list = Helper.DataReaderMapToList<UserVO>(comm.ExecuteReader()); 
                }
            }
            return list;
        }
        public UserVO GetUserInfo(int id)
        {
            string sql = "SELECT TOP(1) id, Name, Email, Mobile, Address, IsActive FROM Users WHERE id= @id";
            UserVO user = null;
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                using (SqlCommand comm = new SqlCommand(sql, conn))
                {
                    comm.Parameters.AddWithValue("@id", id);

                    conn.Open();
                    SqlDataReader reader = comm.ExecuteReader();
                    if (reader.Read())
                    {
                        user = new UserVO()
                        {
                            id = id,
                            Name = reader["Name"].ToString(),
                            Address = reader["Address"].ToString(),
                            Email = reader["Email"].ToString(),
                            IsActive = Convert.ToBoolean(reader["IsActive"]),
                            Mobile = reader["Mobile"].ToString()
                        };
                    }
                }
            }
            return user;
        }
        public string DeleteUser(int id)
        {
            string sql = "DeleteUser";
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                using (SqlCommand comm = new SqlCommand(sql, conn))
                {
                    comm.CommandType = CommandType.StoredProcedure;
                    comm.Parameters.AddWithValue("@id", id);
                    comm.Parameters.Add("@ReturnCode", SqlDbType.NVarChar, 5).Direction = ParameterDirection.Output;

                    conn.Open();
                    comm.ExecuteNonQuery();
                    conn.Close();

                    return comm.Parameters["@ReturnCode"].Value.ToString();
                }
            }
        }
        public string SaveUser(UserVO vo)
        {
            string sql = "SaveUser";
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                using (SqlCommand comm = new SqlCommand(sql, conn))
                {
                    comm.CommandType = CommandType.StoredProcedure;
                    comm.Parameters.AddWithValue("@id", vo.id);
                    comm.Parameters.AddWithValue("@Name", vo.Name);
                    comm.Parameters.AddWithValue("@Email", vo.Email);
                    comm.Parameters.AddWithValue("@Mobile", vo.Mobile);
                    comm.Parameters.AddWithValue("@Address", vo.Address);

                    comm.Parameters.Add("@ReturnCode", SqlDbType.NVarChar, 5).Direction = ParameterDirection.Output;

                    conn.Open();
                    comm.ExecuteNonQuery();
                    conn.Close();

                    return comm.Parameters["@ReturnCode"].Value.ToString();
                }
            }
        }
    }
}