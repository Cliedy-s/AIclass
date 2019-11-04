using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static _1104_01_UserControlEvent.UserControlEvent;

namespace _1104_01_UserControlEvent
{
    public partial class Form1 : Form
    {
        string[] products = { "아메리카노", "카푸치노", "바닐라라떼" };
        int[] prices = { 2500, 2000, 3000 };

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < products.Length; i++)
            {
                UserControlEvent user = new UserControlEvent();
                user.Product = products[i % 3];
                user.Price = prices[i % 3];
                flowLayoutPanel1.Controls.Add(user);
                user.btnClick += btnClickMethod;
            }
            InitCart();
        }

        DataTable cart;
        private void InitCart()
        {
            if (cart != null)
            {
                cart.Rows.Clear();
                return;
            }

            cart = new DataTable("cart");
            cart.Columns.Add(new DataColumn("product", typeof(string)));
            cart.Columns.Add(new DataColumn("qty", typeof(int)));
            cart.Columns.Add(new DataColumn("price", typeof(int)));
        }

        private void btnClickMethod(object sender, btnClickEventArgs args)
        {
            if (cart == null)
                InitCart();

            DataRow[] rows = cart.Select("product = '" + args.Product + "'");
            if(rows.Length > 0)
            {
                rows[0]["qty"] = Convert.ToInt32(rows[0]["qty"]) + 1;
                rows[0]["price"] = Convert.ToInt32(rows[0]["price"]) + args.Price;
            }
            else
            {
                DataRow row = cart.NewRow();
                row["product"] = args.Product;
                row["qty"] = 1;
                row["price"] = args.Price;

                cart.Rows.Add(row);
            }
            cart.AcceptChanges(); // commit!!
            dataGridView1.DataSource = cart;
        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}
