using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static IceCreamManager.UserMain.ProductListUserControl;

namespace IceCreamManager.UserMain
{
    public delegate void UserOrderEvent(object sender, UserOrderEventArgs eArgs);
    public partial class ProductListUserControl : UserControl
    {
        public event UserOrderEvent OrderClick;
        public Image Picture
        {
            get { return pro_Img.Image; }
            set { pro_Img.Image = value; }
        }
        public string PName
        {
            get { return pro_Name.Text; }
            set { pro_Name.Text = value; }
        }

        public string PID
        {
            get { return pro_No.Text; }
            set { pro_No.Text = value; }
        }

        public int Price
        {
            get { return int.Parse(pro_Price.Text); }
            set { pro_Price.Text = value.ToString("#,##0"); }
        }

        public ProductListUserControl()
        {
            InitializeComponent();
        }

        private void ProductListUserControl_Click(object sender, EventArgs e)
        {
            if (OrderClick != null)
            {
                UserOrderEventArgs eArgs = new UserOrderEventArgs();
                eArgs.ProductID = Convert.ToInt32(pro_No.Text);
                eArgs.ProductName = pro_Name.Text;
                eArgs.Price = int.Parse(pro_Price.Text.Replace(",",""));
                eArgs.PImage = pro_Img.Image;
                OrderClick(this, eArgs);
            }
        }

        public class UserOrderEventArgs : EventArgs
        {
            private string mproductName;
            private int mproductID;
            private int mprice;
            private Image mImage;
            public string ProductName
            {
                get { return mproductName; }
                set { mproductName = value; }
            }

            public int ProductID
            {
                get { return mproductID; }
                set { mproductID = value; }
            }

            public int Price
            {
                get { return mprice; }
                set { mprice = value; }
            }
            public Image PImage
            {
                get { return mImage; }
                set { mImage = value; }
            }
        }

    }
}
