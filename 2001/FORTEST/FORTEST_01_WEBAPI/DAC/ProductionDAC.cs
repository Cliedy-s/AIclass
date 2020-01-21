using FORTEST_01_WEBAPI.Controllers;
using FORTEST_02_DTO;
using Helper_1230;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace FORTEST_01_WEBAPI.DAC
{
    public class ProductionDAC
    {
        string strConn = string.Empty;
        public ProductionDAC()
        {
            this.strConn = WebConfigurationManager.ConnectionStrings["db"].ConnectionString;
        }
        //TODO - SQL문 수정 ( 집합 작게 )
        public List<ProductNProductionVO> GetProductionRecord()
        {
            string sql = "SELECT Seq, prd.ProductID, ProductName,  Date, Time, Quantity, BadQuantity FROM Production_SSY as pion JOIN Product_SSY as prd ON pion.ProductID = prd.ProductID; ";
            List<ProductNProductionVO> list = null;
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                using (SqlCommand comm = new SqlCommand(sql, conn))
                {

                    conn.Open();
                    list = Helper.DataReaderMapToList<ProductNProductionVO>(comm.ExecuteReader());
                }
            }
            return list;
        }
        public ProductNProductionVO GetProductionRecordBySeq(int seq)
        {
            string sql = "SELECT TOP(1) Seq, prd.ProductID, ProductName,  Date, Time, Quantity, BadQuantity FROM Production_SSY as pion JOIN Product_SSY as prd ON pion.ProductID = prd.ProductID WHERE Seq = @Seq; ";
            List<ProductNProductionVO> list = new List<ProductNProductionVO>();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                using (SqlCommand comm = new SqlCommand(sql, conn))
                {
                    comm.Parameters.AddWithValue("@Seq", seq);
                    conn.Open();
                    list = Helper.DataReaderMapToList<ProductNProductionVO>(comm.ExecuteReader());
                }
            }
            return list==null? null : list[0];
        }
        public List<ProductNProductionVO> GetProductionRecordByProductID(int id)
        {
            string sql = "SELECT Seq, prd.ProductID, ProductName,  Date, Time, Quantity, BadQuantity FROM Production_SSY as pion JOIN Product_SSY as prd ON pion.ProductID = prd.ProductID WHERE pion.ProductID = @ProductID; ";
            List<ProductNProductionVO> list = new List<ProductNProductionVO>();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                using (SqlCommand comm = new SqlCommand(sql, conn))
                {
                    comm.Parameters.AddWithValue("@ProductID", id);
                    conn.Open();
                    list = Helper.DataReaderMapToList<ProductNProductionVO>(comm.ExecuteReader());
                }
            }
            return list;
        }
        public List<ProductNProductionVO> GetProductionRecordByDate(DateTime fromDate, DateTime toDate)
        {
            string sql = "SELECT Seq, prd.ProductID, ProductName,  Date, Time, Quantity, BadQuantity FROM Production_SSY as pion JOIN Product_SSY as prd ON pion.ProductID = prd.ProductID WHERE Date BETWEEN @fromDate AND @toDate; ";
            List<ProductNProductionVO> list = new List<ProductNProductionVO>();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                using (SqlCommand comm = new SqlCommand(sql, conn))
                {
                    comm.Parameters.AddWithValue("@fromDate", fromDate);
                    comm.Parameters.AddWithValue("@toDate", toDate);
                    conn.Open();
                    list = Helper.DataReaderMapToList<ProductNProductionVO>(comm.ExecuteReader());
                }
            }
            return list;
        }

        public string InorUpProductionRecord(ProductionVO production)
        {
            string sql = "InorUpProductionRecord";
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                using (SqlCommand comm = new SqlCommand(sql, conn))
                {
                    comm.CommandType = CommandType.StoredProcedure;
                    comm.Parameters.AddWithValue("@Seq", production.Seq);
                    comm.Parameters.AddWithValue("@ProductID", production.ProductID);
                    comm.Parameters.AddWithValue("@Date", production.Date);
                    comm.Parameters.AddWithValue("@Time", production.Time);
                    comm.Parameters.AddWithValue("@Quantity", production.Quantity);
                    comm.Parameters.AddWithValue("@BadQuantity", production.BadQuantity);

                    comm.Parameters.Add("@ReturnCode", SqlDbType.NVarChar, 5).Direction = ParameterDirection.Output;

                    conn.Open();
                    comm.ExecuteNonQuery();
                    conn.Close();

                    return comm.Parameters["@ReturnCode"].Value.ToString();
                }
            }
        }
        public string DeleteProductionRecord(int id)
        {
            string sql = "DelProductionRecord";
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                using (SqlCommand comm = new SqlCommand(sql, conn))
                {
                    comm.CommandType = CommandType.StoredProcedure;
                    comm.Parameters.AddWithValue("@Seq", id);
                    comm.Parameters.Add("@ReturnCode", SqlDbType.NVarChar, 5).Direction = ParameterDirection.Output;

                    conn.Open();
                    comm.ExecuteNonQuery();
                    conn.Close();

                    return comm.Parameters["@ReturnCode"].Value.ToString();
                }
            }
        }


    }
}