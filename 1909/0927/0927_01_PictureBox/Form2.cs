using System;
using System.Drawing;
using System.Windows.Forms;

namespace _0927_01_PictureBox
{
    public partial class Form2 : Form
    {
        bool isClicked = false;
        Bitmap bm;
        Point recLoc;
        Point choosingPoint;

        public Form2()
        {
            InitializeComponent();
            this.Text = "ImageViewer";
            pictureBox1.BackColor = Color.White;
        }

        #region ToopStripClick
        private void 이미지선택ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "이미지 파일(.jpg)|*.jpg|모든 파일(*.*)|*.*";
            openFileDialog1.Title = "이미지 열기";
            openFileDialog1.FileName = "";
            openFileDialog1.ShowDialog();
            if (openFileDialog1.FileName != "")
            {
                pictureBox1.Image = new Bitmap(openFileDialog1.FileName);

                bm = new Bitmap(openFileDialog1.FileName);
            }
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }
        private void autoSizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
        }

        private void centerImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
        }

        private void zoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }
        private void ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem menu = (ToolStripMenuItem)sender;
            pictureBox1.SizeMode = (PictureBoxSizeMode)menu.Tag;
        }
        private void 종료ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion

        private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            isClicked = true;
            choosingPoint.X = e.X;
            choosingPoint.Y = e.Y;
        }

        private void PictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            isClicked = false;
        }

        private void PictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isClicked)
            {
                recLoc.X = recLoc.X + e.X - choosingPoint.X;
                recLoc.Y = recLoc.Y + e.Y - choosingPoint.Y;
                choosingPoint = e.Location;
                pictureBox1.Invalidate();
            }
        }

        private void PictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if (isClicked)
            {
                //e.Graphics.Clear(Color.White); // 뒤화면..이보임? 왜보이지 invalidate..?
                e.Graphics.DrawImage(bm, recLoc);
            }
        }

    }
}
