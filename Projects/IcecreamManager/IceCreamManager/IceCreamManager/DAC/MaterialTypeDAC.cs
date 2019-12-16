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
    class MaterialTypeDAC : DACParent
    {
        /// <summary>
        /// 자제타입을 가져온다.
        /// </summary>
        /// <returns></returns>
        public List<MaterialsTypeVO> Materials_Type()
        {

            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = new SqlConnection(Connstr);
                comm.CommandText = "GetAllMaterialsType";
                comm.CommandType = CommandType.StoredProcedure;

                comm.Connection.Open();

                SqlDataReader read = comm.ExecuteReader();

                List<MaterialsTypeVO> list = Helper.DataReaderMapToList<MaterialsTypeVO>(read);
                comm.Connection.Close();
                return list;
            }
        }
    }
}
