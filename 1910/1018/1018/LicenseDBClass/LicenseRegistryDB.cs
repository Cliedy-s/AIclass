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
    public struct LicenseRegistry
    {
        public LicenseRegistry(int customerID, int licenseID)
        {
            this.CustomerID = customerID;
            this.LicenseID = licenseID;
        }

        public int LicenseID { get; set; }
        public int CustomerID { get; set; }
    }
    public class LicenseRegistryDB : IDisposable
    {
        MySqlConnection conn;
        public LicenseRegistryDB()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["LICENSEDB"].ConnectionString;
            conn = new MySqlConnection(connectionString);
            conn.Open();
        }
        public DataSet GetAll()
        {
            string sql = "SELECT LicenseID, LicenseName, LicenseCost FROM License; ";
            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn);
            DataSet dataset = new DataSet();
            adapter.Fill(dataset, "Licenses");
            return dataset;
        }
        public void Insert(License license)
        {
            string sql = string.Format("INSERT INTO License (LicenseID, LicenseName, LicenseCost) VALUES({0},'{1}',{2}); ", license.LicenseID, license.LicenseName, license.LicenseCost);
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
        }
        public void Update(License license)
        {
            string sql = string.Format("UPDATE License SET LicenseName = '{1}', LicenseCost ={2} WHERE LicenseID = {0}; ", license.LicenseID, license.LicenseName, license.LicenseCost);
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            int result = cmd.ExecuteNonQuery();
        }
        public void Delete(int licenseID)
        {
            string sql = string.Format("DELETE FROM License WHERE LicenseID = {0}; ", licenseID);
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            int result = cmd.ExecuteNonQuery();
        }

        public void Dispose()
        {
            conn.Close();
        }
    }
}
