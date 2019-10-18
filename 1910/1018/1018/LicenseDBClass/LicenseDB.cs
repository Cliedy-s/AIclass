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
    public struct License
    {
        public License(int licenseID, string licenseName, int licenseCost)
        {
            LicenseID = licenseID;
            LicenseName = licenseName;
            LicenseCost = licenseCost;
        }

        public int LicenseID { get; set; }
        public string LicenseName { get; set; }
        public int LicenseCost { get; set; }
    }
    public class LicenseDB : IDisposable
    {
        MySqlConnection conn;
        public LicenseDB()
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
            string sql = string.Format("INSERT INTO License (LicenseID, LicenseName, LicenseCost) VALUES({0},'{1}',{2}); ",license.LicenseID, license.LicenseName, license.LicenseCost);
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
