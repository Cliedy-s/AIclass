using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0924_03_ListView
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            listView1.GridLines = true;
            listView1.FullRowSelect = true;

            listView1.Columns.Add("제품명", 150);
            listView1.Columns.Add("단가", 100, HorizontalAlignment.Right);
            listView1.Columns.Add("수량", 70, HorizontalAlignment.Right);
            listView1.Columns.Add("금액", 100, HorizontalAlignment.Right);

            ListViewItem item1 = new ListViewItem(new string[] {"Access","1,000","2","2,000"}, 0);
            ListViewItem item2 = new ListViewItem(new string[] {"Excel","5,000","3","165,000"}, 1);
            ListViewItem item3 = new ListViewItem(new string[] {"PowerPoint","9,000","20","180,000"}, 3);
            ListViewItem item4 = new ListViewItem("Word", 3);
            ListViewItem Item5 = new ListViewItem(new String[] { "OutLook", "22,000", "10", "220,000" }, 4);

            item4.SubItems.Add("Word");
            item4.SubItems.Add("2,000");
            item4.SubItems.Add("10");
            item4.SubItems.Add("20,000");

            ImageList smallImageList = new ImageList();
            smallImageList.ImageSize = new Size(32, 32);
            ImageList largeImageList = new ImageList();
            largeImageList.ImageSize = new Size(64, 64);

            listView1.SmallImageList = smallImageList;
            listView1.LargeImageList = largeImageList;

            smallImageList.Images.Add(Bitmap.FromFile(@"../../Image/access.png"));
            smallImageList.Images.Add(Bitmap.FromFile(@"../../Image/excel.png"));
            smallImageList.Images.Add(Bitmap.FromFile(@"../../Image/ppt.png"));
            smallImageList.Images.Add(Bitmap.FromFile(@"../../Image/word.png"));
            smallImageList.Images.Add(Bitmap.FromFile(@"../../Image/outlook.png"));

            largeImageList.Images.Add(Bitmap.FromFile(@"../../Image/access.png"));
            largeImageList.Images.Add(Bitmap.FromFile(@"../../Image/excel.png"));
            largeImageList.Images.Add(Bitmap.FromFile(@"../../Image/ppt.png"));
            largeImageList.Images.Add(Bitmap.FromFile(@"../../Image/word.png"));
            largeImageList.Images.Add(Bitmap.FromFile(@"../../Image/outlook.png"));

            rdoDetail.Tag = View.Details;
            rdoLargeIcon.Tag = View.LargeIcon;
            rdoSmallIcon.Tag = View.SmallIcon;
            rdoTile.Tag = View.Tile;
            rdoList.Tag = View.List;
        }

        private void Rdo_CheckedChanged(object sender, EventArgs e)
        {
            if(sender is RadioButton)
            {
                RadioButton radioButton = sender as RadioButton;
                listView1.View = (View)radioButton.Tag;
            }

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Bitmap.FromFile("..\\..\\Image\\access.png");
            pictureBox1.ImageLocation = "https://pbs.twimg.com/profile_images/770139154898382848/ndFg-IDH.jpg";
        }

        private void TreeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }
    }
}
