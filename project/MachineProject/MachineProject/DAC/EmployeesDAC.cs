using MachineProject.DTO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachineProject.DAC
{
    public class EmployeesDAC
    {
        MySqlConnection conn;
        public EmployeesDAC(MySqlConnection conn)
        {
            this.conn = conn;
        }

        public void Insert(EmployeeDTO item)
        {
            string sql = "INSERT INTO EMPLOYEES(EmployeeID, Email, Password, Name, Phone, ZipCod, Addr1, Addr2) VALUES(@EmployeeID, @Email, @Password, @Name, @Phone, @ZipCod, @Addr1, @Addr2); ";
            MySqlCommand comm = new MySqlCommand(sql, conn);
            FillParameters(comm, item);
            comm.ExecuteNonQuery();
        }

        public void Update(EmployeeDTO item)
        {
            string sql = "UPDATE EMPLOYEES SET Password =@Password , Name =@Name, Phone = @Phone, ZipCode = @ZipCode, Addr1 = @Addr1, Addr2 = @Addr2 WHERE EmployeeID = @EmployeeID; ";
            MySqlCommand comm = new MySqlCommand(sql, conn);
            FillParameters(comm, item);
            comm.ExecuteNonQuery();
        }

        public void Delete(EmployeeDTO item)
        {
            string sql = "DELETE FROM EMPLOYEES WHERE EmployeeID = @EmployeeID; ";
            MySqlCommand comm = new MySqlCommand(sql, conn);
            FillParameters(comm, item);
            comm.ExecuteNonQuery();
        }

        public bool IsValid(string employeeID)
        {
            string sql = string.Format("SELECT count(*) FROM EMPLOYEES WHERE EmployeeID = @EmployeeID; ");
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@EmployeeID", employeeID);

            if (Convert.ToInt32(cmd.ExecuteScalar()) == 0)
                return false;
            return true;
        }
        public bool IsEmailExist(string email)
        {
            string sql = string.Format("SELECT count(*) FROM EMPLOYEES WHERE Email = @Email; ");
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@Email", email);

            if (Convert.ToInt32(cmd.ExecuteScalar()) == 0)
                return false;
            return true;
        }

        public EmployeeDTO SearchEmployee(string employeeID)
        {
            string sql = "SELECT EmployeeID, Email, Password, Name, Phone, ZipCode, Addr1, Addr2, Authority FROM EMPLOYEES WHERE EmployeeID=@EmployeeID; ";
            MySqlCommand comm = new MySqlCommand(sql, conn);
            comm.Parameters.AddWithValue("@EmployeeID", employeeID);
            EmployeeDTO getItem = new EmployeeDTO();
            using (MySqlDataReader reader = comm.ExecuteReader())
            {
                if (reader.Read())
                {
                    getItem = new EmployeeDTO() {
                        EmployeeID = reader["EmployeeID"].ToString()
                        , Email = reader["Email"].ToString()
                        , Password = reader["Password"].ToString()
                        , Name = reader["Name"].ToString()
                        , Phone = reader["Phone"].ToString()
                        , ZipCode = reader["ZipCode"].ToString()
                        , Addr1 = reader["Addr1"].ToString()
                        , Addr2 = reader["Addr2"].ToString()
                        , Authority = Convert.ToInt32(reader["Authority"])
                    } ;
                }
                return getItem;
            }
        }

        public List<EmployeeDTO> SelectAll()
        {
            string sql = "SELECT  EmployeeID, Email, Password, Name, Phone, ZipCode, Addr1, Addr2, Authority FROM EMPLOYEES; ";
            List<EmployeeDTO> list = new List<EmployeeDTO>();

            MySqlCommand comm = new MySqlCommand(sql, conn);
            using (MySqlDataReader reader = comm.ExecuteReader())
            {
                while (reader.Read())
                {
                    EmployeeDTO item = new EmployeeDTO() {
                        EmployeeID = reader["EmployeeID"].ToString()
                        , Email = reader["Email"].ToString()
                        , Password = reader["Password"].ToString()
                        , Name = reader["Name"].ToString()
                        , Phone = reader["Phone"].ToString()
                        , ZipCode = reader["ZipCode"].ToString()
                        , Addr1 = reader["Addr1"].ToString()
                        , Addr2 = reader["Addr2"].ToString()
                        , Authority = Convert.ToInt32(reader["Authority"])
                    } ;
                    list.Add(item);
                }
            }
            return list;
        }
        public DataTable SelectAll(bool b)
        {
            string sql = "SELECT EmployeeID, Email, Password, Name, Phone, ZipCode, Addr1, Addr2, Authority FROM EMPLOYEES; ";

            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        private void FillParameters(MySqlCommand comm, EmployeeDTO item)
        {
            comm.Parameters.Add("@EmployeeID", MySqlDbType.VarChar, 5);
            comm.Parameters["@EmployeeID"].Value = item.Name;

            comm.Parameters.Add("@Email", MySqlDbType.VarChar, 30);
            comm.Parameters["@Email"].Value = item.Email;

            comm.Parameters.Add("@Password", MySqlDbType.VarChar, 20);
            comm.Parameters["@Password"].Value = item.Password;

            comm.Parameters.Add("@Name", MySqlDbType.VarChar, 30);
            comm.Parameters["@Name"].Value = item.Name;

            comm.Parameters.Add("@Phone", MySqlDbType.VarChar, 14);
            comm.Parameters["@Phone"].Value = item.Phone;

            comm.Parameters.Add("@ZipCode", MySqlDbType.VarChar, 5);
            comm.Parameters["@ZipCode"].Value = item.ZipCode;

            comm.Parameters.Add("@Addr1", MySqlDbType.VarChar, 50);
            comm.Parameters["@Addr1"].Value = item.Addr1;

            comm.Parameters.Add("@Addr2", MySqlDbType.VarChar, 50);
            comm.Parameters["@Addr2"].Value = item.Addr2;
        }
    }
}
