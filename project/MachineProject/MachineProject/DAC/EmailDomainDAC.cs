using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachineProject.DAC
{
    class EmailDomainDAC
    {
        MySqlConnection conn;
        public EmailDomainDAC(MySqlConnection conn)
        {
            this.conn = conn;
        }

        public DataTable SelectAll()
        {
            string sql = "SELECT DomainCode, Domain FROM EMAILDOMAINS ORDER BY DomainCode; ";

            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn);
            DataTable data = new DataTable();
            adapter.Fill(data);
            data.TableName = "EMAILDOMAIN";

            return data;
        }
    }
}
