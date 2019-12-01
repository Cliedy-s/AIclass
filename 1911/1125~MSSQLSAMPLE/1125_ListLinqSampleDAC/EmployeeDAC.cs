using _1125_ListLinqSampleVO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1125_ListLinqSample
{
    public class EmployeeDAC : ConnectionAccess
    {
        public bool RegisterEmployee(EmployeeVO emp)
        {
            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = new SqlConnection(Connstr);
                comm.CommandText = "insert into Employees(LastName, FirstName, Title, BirthDate, HireDate, HomePhone, Photo, Notes) " +
                    "values(@LastName, @FirstName, @Title, @BirthDate, @HireDate, @HomePhone, @Photo, @Notes)";
                comm.Parameters.AddWithValue("@LastName", emp.LastName);
                comm.Parameters.AddWithValue("@FirstName", emp.FirstName);
                comm.Parameters.AddWithValue("@Title", emp.Title);
                comm.Parameters.AddWithValue("@BirthDate", emp.BirthDate);
                comm.Parameters.AddWithValue("@HireDate", emp.HireDate);
                comm.Parameters.AddWithValue("@Photo", emp.Photo);
                comm.Parameters.AddWithValue("@HomePhone", emp.HomePhone);
                comm.Parameters.AddWithValue("@Notes", emp.Notes);

                comm.Connection.Open();
                bool IsAffected = comm.ExecuteNonQuery() > 0;
                comm.Connection.Close();    
                return IsAffected;
            }
        }

        public bool DeleteEmployee(int empID)
        {
            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = new SqlConnection(Connstr);
                comm.CommandText = "DeleteEmployee_04";
                comm.CommandType = CommandType.StoredProcedure;

                comm.Parameters.AddWithValue("@EmployeeID", empID);

                comm.Connection.Open();
                bool IsAffected = comm.ExecuteNonQuery() > 0;
                comm.Connection.Close();
                return IsAffected;
            }
        }

        public bool UpdateEmployee(EmployeeVO emp)
        {
            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = new SqlConnection(Connstr);
                comm.CommandText = "UpdateEmployee_04";
                comm.CommandType = CommandType.StoredProcedure;

                comm.Parameters.AddWithValue("@EmployeeID", emp.EmployeeID);
                comm.Parameters.AddWithValue("@LastName", emp.LastName);
                comm.Parameters.AddWithValue("@FirstName", emp.FirstName);
                comm.Parameters.AddWithValue("@Title", emp.Title);
                comm.Parameters.AddWithValue("@BirthDate", emp.BirthDate);
                comm.Parameters.AddWithValue("@HireDate", emp.HireDate);
                comm.Parameters.AddWithValue("@HomePhone", emp.HomePhone);
                comm.Parameters.AddWithValue("@Photo", emp.Photo);
                comm.Parameters.AddWithValue("@Notes", emp.Notes);

                comm.Connection.Open();
                bool IsAffected = comm.ExecuteNonQuery() > 0;
                comm.Connection.Close();
                return IsAffected;
            }
        }

        public bool RegisterEmployeeSP(EmployeeVO emp)
        {
            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = new SqlConnection(Connstr);
                comm.CommandText = "RegisterEmployee_04";
                comm.CommandType = CommandType.StoredProcedure;

                comm.Parameters.AddWithValue("@LastName", emp.LastName);
                comm.Parameters.AddWithValue("@FirstName", emp.FirstName);
                comm.Parameters.AddWithValue("@Title", emp.Title);
                comm.Parameters.AddWithValue("@BirthDate", emp.BirthDate);
                comm.Parameters.AddWithValue("@HireDate", emp.HireDate);
                comm.Parameters.AddWithValue("@HomePhone", emp.HomePhone);
                comm.Parameters.AddWithValue("@Photo", emp.Photo);
                comm.Parameters.AddWithValue("@Notes", emp.Notes);

                comm.Connection.Open();
                bool IsAffected = comm.ExecuteNonQuery() > 0;
                comm.Connection.Close();
                return IsAffected;
            }
        }
        public List<EmployeeVO> GetAllEmployee()
        {
            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = new SqlConnection(Connstr);
                comm.CommandText = "GetAllEmployee";
                comm.CommandType = CommandType.StoredProcedure;

                comm.Connection.Open();
                SqlDataReader reader = comm.ExecuteReader();
                List<EmployeeVO> vos = Helper.DataReaderMapToList<EmployeeVO>(reader);
                comm.Connection.Close();
                return vos;
            }
        }

        public EmployeeVO GetEmployeeById(int empID)
        {
            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = new SqlConnection(Connstr);
                comm.CommandText = "GetEmployeeInfoById";
                comm.CommandType = CommandType.StoredProcedure;

                comm.Parameters.AddWithValue("@p_empID", empID);

                comm.Connection.Open();
                SqlDataReader reader = comm.ExecuteReader();
                List<EmployeeVO> vos = Helper.DataReaderMapToList<EmployeeVO>(reader);
                comm.Connection.Close();
                return vos.Count > 0 ? vos[0] : null;
            }
        }
    }
}
