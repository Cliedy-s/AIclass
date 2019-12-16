using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IceCreamManager.VO;
using System.Data.SqlClient;
using System.Data;
namespace IceCreamManager.DAC
{
    public class OrderDAC : DACParent
    {
        public (List<OrderVO>, List<OrderSubVO>) SelectAll()
        {
            using (SqlCommand cmd = new SqlCommand())
            {

                cmd.Connection = new SqlConnection(Connstr);
                cmd.CommandText = "GetAllOrder";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection.Open();

                SqlDataReader orderread = cmd.ExecuteReader();
                List<OrderVO> orderlist = Helper.DataReaderMapToList<OrderVO>(orderread);
                orderread.Close();

                cmd.CommandText = "GetAllSubOrder";
                cmd.CommandType = CommandType.StoredProcedure;


                SqlDataReader subread = cmd.ExecuteReader();
                List<OrderSubVO> sublist = Helper.DataReaderMapToList<OrderSubVO>(subread);

                cmd.Connection.Close();

                return (orderlist, sublist);
            }
        }
        public bool Insert(OrderVO list)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(Connstr);

                cmd.CommandText = "InsertOrder";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection.Open();

                cmd.Parameters.AddWithValue("@ofo_Each", list.ofo_Each);
                cmd.Parameters.AddWithValue("@mat_No", list.mat_No);
                cmd.Parameters.AddWithValue("@off_No", list.off_No);
                cmd.Parameters.AddWithValue("@cmt_No", list.cmt_No);
                cmd.Parameters.AddWithValue("@ofo_Price", list.ofo_Price);
                cmd.Parameters.AddWithValue("@ofo_Date", list.ofo_Date);

                var rowsAffected = cmd.ExecuteNonQuery();

                return rowsAffected > 0;
            }

        }
        public bool Update(int ofo_no, int cmt_no)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(Connstr);

                cmd.CommandText = "Update_Order";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection.Open();

                cmd.Parameters.AddWithValue("@ofo_No", ofo_no);
                cmd.Parameters.AddWithValue("@cmt_No", cmt_no);


                var rowsAffected = cmd.ExecuteNonQuery();

                return rowsAffected > 0;
            }

        }
        /// <summary>
        /// 발주되어 입고된 자제갯수 업데이트
        /// </summary>
        public bool MaterialEachUpdate(int mat_No, int ofo_Each)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(Connstr);
                cmd.CommandText = "MaterialEachUpdate";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection.Open();

                cmd.Parameters.AddWithValue("@mat_No", mat_No);
                cmd.Parameters.AddWithValue("@mat_Each", ofo_Each);

                var rowsAffected = cmd.ExecuteNonQuery();

                return rowsAffected > 0;
            }


        }

    }
}
