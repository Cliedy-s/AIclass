using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1104_01_UserControlEvent
{
    public partial class UserControlEvent : UserControl
    {
        public string Product { get { return label1.Text; } set { label1.Text = value; } }
        public int Price { get { return int.Parse(label2.Text.Replace("원", "").Replace(",", "")); } set { label2.Text = value.ToString("#,##0") + "원"; } }

        public UserControlEvent()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (btnClick != null)
                btnClick(this, new btnClickEventArgs() { Product = this.Product, Price = this.Price });
        }
        public delegate void btnClickEvent(object sender, btnClickEventArgs args);
        public event btnClickEvent btnClick;
        public class btnClickEventArgs : EventArgs
        {
            string product;
            int price;
            public string Product { get => product; set => product = value; }
            public int Price { get => price; set => price = value; }
        }
    }

}
