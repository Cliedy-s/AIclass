using _1125_ListLinqSampleVO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1125_ListLinqSample
{
    public class OrderDAC : ConnectionAccess
    {
        public List<ProductInfoVO> GetProductsInfoByCategoryID(string categoryID)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(this.Connstr);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = @"select ProductID, ProductName, CategoryID, QuantityPerUnit,                               UnitPrice, UnitsOnOrder
                                       from Products
                                      where CategoryID = @P_CategoryID";
                cmd.Parameters.AddWithValue("@P_CategoryID", categoryID);

                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<ProductInfoVO> list = Helper.DataReaderMapToList<ProductInfoVO>(reader);
                cmd.Connection.Close();

                return list;
            }
        }

        public bool RegisterOrder(OrderInfoVO order, List<OrderDetailVO> details)
        {

            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(this.Connstr);
                cmd.Connection.Open();
                SqlTransaction tran = cmd.Connection.BeginTransaction();

                try
                {
                    cmd.Transaction = tran;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = @"Insert into Orders 
                                                (CustomerID, EmployeeID, OrderDate, RequiredDate)
                                          Values 
                                             (@CustomerID, @EmployeeID, @OrderDate, @RequiredDate); Select @@IDENTITY";

                    cmd.Parameters.AddWithValue("@CustomerID", order.CustomerID);
                    cmd.Parameters.AddWithValue("@EmployeeID", order.EmployeeID);
                    cmd.Parameters.AddWithValue("@OrderDate", DateTime.Now.ToShortDateString());
                    cmd.Parameters.AddWithValue("@RequiredDate", order.RequiredDate);

                    int newOrderID = Convert.ToInt32(cmd.ExecuteScalar());

                    foreach (OrderDetailVO item in details)
                    {
                        cmd.Parameters.Clear();

                        cmd.CommandText = @"Insert into [Order Details] 
                                                (OrderID, ProductID, UnitPrice, Quantity)
                                          Values (@OrderID, @ProductID, @UnitPrice, @Quantity)";

                        cmd.Parameters.AddWithValue("@OrderID", newOrderID);
                        cmd.Parameters.AddWithValue("@ProductID", item.ProductID);
                        cmd.Parameters.AddWithValue("@UnitPrice", item.UnitPrice);
                        cmd.Parameters.AddWithValue("@Quantity", item.Quantity);

                        cmd.ExecuteNonQuery();
                    }
                    tran.Commit();
                    cmd.Connection.Close();
                    return true;
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine(ex.Message);
                    tran.Rollback();
                    cmd.Connection.Close();
                    return false;
                }
            }
        }

        public List<OrderInfoVO> GetOrderSearchList(int selEmployeeID, string selCustomerID, string dtFrom, string dtTo)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(this.Connstr);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GetOrderSearchList";

                cmd.Parameters.AddWithValue("@p_EmployeeID", (selEmployeeID == 0) ? DBNull.Value : (object)selEmployeeID);
                cmd.Parameters.AddWithValue("@p_CustomerID", (string.IsNullOrEmpty(selCustomerID)) ? DBNull.Value : (object)selCustomerID);
                cmd.Parameters.AddWithValue("@p_FromDate", dtFrom);
                cmd.Parameters.AddWithValue("@p_ToDate", dtTo);

                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<OrderInfoVO> list = Helper.DataReaderMapToList<OrderInfoVO>(reader);
                cmd.Connection.Close();

                return list;
            }
        }

        public List<OrderDetailVO> GetOrderDetailSearchList(int orderID)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(this.Connstr);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GetOrderDetailSearchList";

                cmd.Parameters.AddWithValue("@p_OrderID", orderID);

                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<OrderDetailVO> list = Helper.DataReaderMapToList<OrderDetailVO>(reader);
                cmd.Connection.Close();

                return list;
            }
        }

        public bool UpdateOrderInfo(int orderID, int shipperID, string shippedDate, decimal freightFee)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(this.Connstr);
                cmd.Connection.Open();

                try
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = @"Update Orders Set ShippedDate = @ShippedDate, ShipVia = @ShipVia, Freight = @Freight
                                          Where OrderID = @OrderID";

                    cmd.Parameters.AddWithValue("@ShippedDate", shippedDate);
                    cmd.Parameters.AddWithValue("@ShipVia", shipperID);
                    cmd.Parameters.AddWithValue("@Freight", freightFee);
                    cmd.Parameters.AddWithValue("@OrderID", orderID);

                    cmd.ExecuteScalar();
                    cmd.Connection.Close();
                    return true;
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine(ex.Message);
                    cmd.Connection.Close();
                    return false;
                }
            }
        }

        public bool DeleteOrderInfo(int orderID)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(this.Connstr);
                cmd.Connection.Open();

                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "DelOrderInfo";

                    cmd.Parameters.AddWithValue("@OrderID", orderID);

                    cmd.ExecuteScalar();
                    cmd.Connection.Close();
                    return true;
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine(ex.Message);
                    cmd.Connection.Close();
                    return false;
                }
            }
        }
    }
}
