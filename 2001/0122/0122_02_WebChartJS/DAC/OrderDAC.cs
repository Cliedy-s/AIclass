using _0122_02_WebChartJS.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace _0122_02_WebChartJS.DAC
{
    public class OrderDAC
    {
        string connstr;
        public OrderDAC()
        {
            connstr = ConfigurationManager.ConnectionStrings["mydb"].ConnectionString;
        }

        public List<OrderStatsVO> GetOrderBestProduct()
        {
            string sql = 
@"SELECT ProductName, SUM(Quantity) qty, Month(OrderDate) MM
FROM Orders o 
	INNER JOIN [Order Details] od on o.OrderID = od.OrderID
	INNER JOIN Products p on od.ProductID = p.ProductID
WHERE YEAR(OrderDate) = 1997
	AND od.ProductID IN (SELECT TOP(5) od.ProductID
	FROM Orders o 
		INNER JOIN [Order Details] od ON o.OrderID = od.OrderID 
	WHERE Year(OrderDate) = 1997 
	GROUP BY od.ProductID 
	ORDER BY Sum(Quantity) DESC)
GROUP BY MONTH(OrderDate), od.ProductID, ProductName; ";

            List<OrderStatsVO> list = null;
            using(SqlConnection conn = new SqlConnection(connstr))
            {
                using(SqlCommand comm = new SqlCommand(sql, conn))
                {
                    conn.Open();
                    list = Helper_1230.Helper.DataReaderMapToList<OrderStatsVO>(comm.ExecuteReader());
                }
            }
            return list;
        }
    }
}