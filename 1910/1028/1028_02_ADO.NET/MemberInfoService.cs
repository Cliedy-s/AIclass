using _1028_01_ADO.NET;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;

namespace _1028_02_ADO.NET
{
    public class MemberInfoService : IDisposable
    {
        MySqlConnection conn;
        MemberInfoDAC dac;
        // 역할 : 커넥션 오픈, 덱 호출
        public MemberInfoService()
        {
            string sqlconn = ConfigurationManager.ConnectionStrings["memberInfo"].ConnectionString;
            conn = new MySqlConnection(sqlconn);
            conn.Open();
            dac = new MemberInfoDAC(conn);
        }

        public void Insert(MemberInfoVO item)
        {
            dac.Insert(item);
        }

        public void Update(MemberInfoVO item)
        {
            dac.Update(item);
        }

        public void Delete(MemberInfoVO item)
        {
            dac.Delete(item);
        }

        public List<MemberInfoVO> SelectAll()
        {
            return dac.SelectAll();
        }

        public void Dispose()
        {
            conn.Close();
        }
    }
}
