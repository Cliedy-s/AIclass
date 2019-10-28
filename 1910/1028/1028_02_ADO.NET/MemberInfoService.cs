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
        // 역할 : 커넥션 오픈, 덱 호출
        public MemberInfoService()
        {
            string sqlconn = ConfigurationManager.ConnectionStrings["memberInfo"].ConnectionString;
            conn = new MySqlConnection(sqlconn);
            conn.Open();
        }

        public void Insert(MemberInfoVO item)
        {
            MemberInfoDAC dac = new MemberInfoDAC(conn);
            dac.Insert(item);
        }

        public void Update(MemberInfoVO item)
        {
            MemberInfoDAC dac = new MemberInfoDAC(conn);
            dac.Update(item);
        }

        public void Delete(MemberInfoVO item)
        {
            MemberInfoDAC dac = new MemberInfoDAC(conn);
            dac.Delete(item);
        }

        public List<MemberInfoVO> SelectAll()
        {
            MemberInfoDAC dac = new MemberInfoDAC(conn);
            return dac.SelectAll();
        }

        public void Dispose()
        {
            conn.Close();
        }
    }
}
