using _1125_ListLinqSample;
using IceCreamManager.VO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IceCreamManager.DAC
{
    class BOMDAC : DACParent
    {
        public override int delete()
        {
            throw new NotImplementedException();
        }

        public override int Insert()
        {
            throw new NotImplementedException();
        }

        public override List<BOMVO> SelectAll<BOMVO>()
        {
            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = new SqlConnection(Connstr);
                comm.CommandText = "<프로시저 이름>";
                comm.CommandType = CommandType.StoredProcedure;

                comm.Connection.Open();
                SqlDataReader reader = comm.ExecuteReader();
                List<BOMVO> bomlist = Helper.DataReaderMapToList<BOMVO>(reader);
                comm.Connection.Close();

                return bomlist;
            }
        }

        public override int update()
        {
            throw new NotImplementedException();
        }
    }
}
