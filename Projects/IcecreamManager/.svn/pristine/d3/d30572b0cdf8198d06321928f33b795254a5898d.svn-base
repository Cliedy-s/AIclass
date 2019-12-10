using IceCreamManager.VO;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace IceCreamManager.DAC
{
    public class UserDAC : DACParent
    {
        
        public bool UserSiginUp(UserInfoVO emp)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(this.Connstr);
                cmd.CommandText = "insert into Customer(cus_Id, cus_Password,cus_Name ,cus_Phone ,cus_Addr , cus_Email) values (@cus_Id, @cus_Password, @cus_Name, @cus_Phone, @cus_Addr, @cus_Email)";

                cmd.Parameters.AddWithValue("@cus_Id", emp.cus_ID);
                cmd.Parameters.AddWithValue("@cus_Password", emp.cus_Password);
                cmd.Parameters.AddWithValue("@cus_Name", emp.cus_Name);
                cmd.Parameters.AddWithValue("@cus_Phone", emp.cus_Phone);
                cmd.Parameters.AddWithValue("@cus_Addr", emp.cus_Addr);
                cmd.Parameters.AddWithValue("@cus_Email", emp.cus_Email);

                cmd.Connection.Open();
                var rowsAffected = cmd.ExecuteNonQuery();
                cmd.Connection.Close();
                return rowsAffected > 0;

            }
        }

        

        public bool UserIDCheck(UserInfoVO emp)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(this.Connstr);
                cmd.CommandText = "select count(*) from Customer where cus_Id=@cus_Id";

                cmd.Parameters.AddWithValue("@cus_Id", emp.cus_ID);

                cmd.Connection.Open();
                var rowsAffected = cmd.ExecuteScalar();
                cmd.Connection.Close();
                if ((int)rowsAffected == 1) //동일한 ID 가있다면
                {
                    return false;
                }
                return true; //없다면
            }
        }
        
        public string UserIDSearch(UserInfoVO uvo)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                try
                {
                    cmd.Connection = new SqlConnection(this.Connstr);
                    cmd.CommandText = "select cus_Id from Customer where cus_Email =@cus_Email  and cus_Name=@cus_Name and cus_Phone=@cus_Phone";

                    cmd.Parameters.AddWithValue("@cus_Name", uvo.cus_Name);
                    cmd.Parameters.AddWithValue("@cus_Phone", uvo.cus_Phone);
                    cmd.Parameters.AddWithValue("@cus_Email", uvo.cus_Email);

                    cmd.Connection.Open();
                    string result = Convert.ToString(cmd.ExecuteScalar());
                    cmd.Connection.Close();
                    if (result == "")
                    {
                        return null;
                    }
                    else
                    {
                        return result;
                    }

                }
                catch (Exception err)
                {
                    MessageBox.Show(err.ToString());
                    return null;
                }
            }
        }

     
            public bool UserEmailCheck(UserInfoVO emp)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(this.Connstr);
                cmd.CommandText = "select count(*) from Customer where cus_Email =@cus_Email  and cus_Id=@cus_Id and cus_Phone=@cus_Phone";

                cmd.Parameters.AddWithValue("@cus_Id", emp.cus_ID);
                cmd.Parameters.AddWithValue("@cus_Email", emp.cus_Email);
                cmd.Parameters.AddWithValue("@cus_Phone", emp.cus_Phone);

                cmd.Connection.Open();
                var rowsAffected = cmd.ExecuteScalar();
                cmd.Connection.Close();
                if ((int)rowsAffected == 1) //동일한 ID 가있다면
                {
                    return false;
                }
                return true; //없다면
            }
        }

        public int UserPWDUpdate(UserInfoVO uvo)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                try
                {
                    cmd.Connection = new SqlConnection(this.Connstr);
                    cmd.CommandText = "update Customer set cus_Password=@cus_Password where cus_Email =@cus_Email  and cus_Id=@cus_Id and cus_Phone=@cus_Phone";

                    cmd.Parameters.AddWithValue("@cus_Id", uvo.cus_Password);
                    cmd.Parameters.AddWithValue("@cus_Id", uvo.cus_ID);
                    cmd.Parameters.AddWithValue("@cus_Email", uvo.cus_Email);
                    cmd.Parameters.AddWithValue("@cus_Phone", uvo.cus_Phone);

                    cmd.Connection.Open();

                    int a = cmd.ExecuteNonQuery();

                    cmd.Connection.Close();

                    return a;

                }
                catch (Exception err)
                {
                    throw err;
                }

            }
        }



    }
}
