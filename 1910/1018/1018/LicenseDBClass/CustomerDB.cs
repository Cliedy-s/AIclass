using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBClasses
{
    public struct Customer{
        public Customer(int customerID, string customerName)
        {
            this.CustomerID = customerID;
            this.CustomerName = customerName;
        }

        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
    }
    public class CustomerDB : IDisposable
    {
        MySqlConnection conn;
        public CustomerDB()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["LICENSEDB"].ConnectionString;
            conn = new MySqlConnection(connectionString);
            conn.Open();
        }
        public DataSet GetAll()
        {
            string sql = "SELECT CustomerID, CustomerName, CustomerM_Date FROM customer WHERE CustomerDeleted = b'0'; ";
            MySqlDataAdapter adapter = new MySqlDataAdapter(sql,conn);
            DataSet dataset = new DataSet();
            adapter.Fill(dataset, "Customers");
            return dataset;
        }
        public void Insert(Customer customer)
        {
            string sql = string.Format("INSERT INTO Customer (CustomerID, CustomerName) VALUES({0},'{1}'); ",customer.CustomerID, customer.CustomerName);
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
        }
        public void Update(Customer customer)
        {
            string sql = string.Format("UPDATE Customer SET CustomerName = '{1}' WHERE CustomerID = {0}; ", customer.CustomerID, customer.CustomerName);
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            int result = cmd.ExecuteNonQuery();
        }
        public void Delete(int customerID)
        {
            string sql = string.Format("DELETE FROM Customer WHERE CustomerID = {0}; ", customerID);
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            int result = cmd.ExecuteNonQuery();
        }

        public void Dispose()
        {
            conn.Close();
        }
    }
}
