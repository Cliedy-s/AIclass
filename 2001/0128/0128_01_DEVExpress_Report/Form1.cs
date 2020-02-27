using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0128_01_DEVExpress_Report
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connstr = ConfigurationManager.ConnectionStrings["mydbconn"].ConnectionString;

            DataSet ds = new DataSet();
            using (SqlConnection conn = new SqlConnection(connstr))
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(@"SELECT * FROM EMPLOYEES WHERE EmployeeID < 100 ; ", conn);
                adapter.Fill(ds, "Employees");
            }

            Report rpt = new Report();
            rpt.DataSource = ds.Tables["Employees"];

            Form2 frm = new Form2();
            frm.documentViewer1.DocumentSource =rpt;
            frm.ShowDialog();
            //ReportPreview frm = new ReportPreview(rpt);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string dtstart = dateTimePicker1.Value.ToString("yyyy-MM-") + "01";
            string dtend = dateTimePicker1.Value.AddMonths(1).ToString("yyyy-MM-") + "01";

            string sql =
@"SELECT [OrderID]
	  ,c.[CustomerID]
      ,c.[CompanyName] as CustomerName
      ,[OrderDate]
      ,[RequiredDate]
      ,case when [ShippedDate] is null then '배송중' else '배송완료' end ShipStatus
  FROM [dbo].[Orders] as o
	JOIN [dbo].[Customers] AS c ON c.CustomerID = o.CustomerID
  WHERE o.OrderDate >= '"+dtstart+"' AND o.OrderDate < '"+ dtend +"'; ";

            string detailsql =
@"  SELECT o.[OrderID]
      ,pd.[ProductID]
      ,pd.[ProductName]
      ,ct.[CategoryName]
      ,od.[Quantity]
      ,od.[UnitPrice]
  FROM [dbo].[Orders] as o
	JOIN [dbo].[Customers] AS c ON c.CustomerID = o.CustomerID
	JOIN [dbo].[Order Details] as od ON o.OrderID = od.OrderID
	JOIN [dbo].[Products] as pd ON pd.ProductID= od.ProductID
	JOIN [Northwind].[dbo].[Categories] AS ct ON ct.CategoryID = pd.CategoryID
  WHERE o.OrderDate >=  '" + dtstart + "' AND o.OrderDate < '" + dtend + "'; ";

            string connstr = ConfigurationManager.ConnectionStrings["mydbconn"].ConnectionString;

            DSOrder ds1 = new DSOrder();
            using (SqlConnection conn = new SqlConnection(connstr))
            {
                conn.Open();

                SqlDataAdapter adapter = new SqlDataAdapter(sql , conn);
                adapter.Fill(ds1, "dtOrder");
                adapter = new SqlDataAdapter(detailsql, conn);
                adapter.Fill(ds1, "dtOrderDetail");
            }

            ReportDetail rpt = new ReportDetail();
            rpt.DataSource = ds1;
            rpt.Parameters["OrderYYYYMM"].Value = $"{dtstart.Substring(0, 4)}년 {dtstart.Substring(5,2)}월";
            rpt.Parameters["OrderYYYYMM"].Visible = false; //parameter submit x
            rpt.CreateDocument(); //parameter submit x

            Form2 frm = new Form2();
            frm.documentViewer1.DocumentSource = rpt;
            frm.documentViewer1.PrintingSystem.ExecCommand(DevExpress.XtraPrinting.PrintingSystemCommand.SubmitParameters, new object[] { true }); //parameter submit x
            frm.ShowDialog();
        }
    }
}
