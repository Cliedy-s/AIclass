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
        public LicenseRegistry( int customerID, int licenseID, int registrycode = -1)
        {
            this.RegistryCode = registrycode;
            this.CustomerID = customerID;
            this.LicenseID = licenseID;
        }
        public int RegistryCode { get; set; }
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
            string sql = "SELECT registrycode, CustomerID, LicesneID FROM licenseregistry; ";
            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn);
            DataSet dataset = new DataSet();
            adapter.Fill(dataset, "licenseregistry");
            return dataset;
        }
        public void Insert(LicenseRegistry licenseRegistry)
        {
            string sql = string.Format("INSERT INTO licenseregistry (CustomerID, LicesneID) VALUES({0},{1}); ", licenseRegistry.CustomerID, licenseRegistry.LicenseID);
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
        }
        public void Update(LicenseRegistry licenseRegistry)
        {
            string sql = string.Format("UPDATE licenseregistry SET CustomerID = {1}, LicesneID ={2} WHERE registrycode = {0}; ", licenseRegistry.RegistryCode, licenseRegistry.CustomerID, licenseRegistry.LicenseID);
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            int result = cmd.ExecuteNonQuery();
        }
        public void Delete(int registrycode)
        {
            string sql = string.Format("DELETE FROM licenseregistry WHERE registrycode = {0}; ", registrycode);
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            int result = cmd.ExecuteNonQuery();
        }

        public void Dispose()
        {
            conn.Close();
        }
    }
}
