using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0927_01_PictureBox
{
    public partial class Form1 : Form
    {
        ToolStripMenuItem[] toolStripMenuItems;
        public Form1()
        {
            InitializeComponent();
        }

        private void 이미지입력ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string filePath;
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.Filter = "이미지 파일|*.jpg;*.png;*.gif|모든파일|*.*";
            openFileDialog1.FilterIndex = 0;
            if (DialogResult.OK == openFileDialog1.ShowDialog())
            {
                filePath = openFileDialog1.FileName;
                pictureBox1.Image = new Bitmap(filePath);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            toolStripMenuItems = new ToolStripMenuItem[] { nomalToolStripMenuItem, stretchImageToolStripMenuItem, autoSizeToolStripMenuItem, centerImageToolStripMenuItem, zoomToolStripMenuItem };
            for (int i = 0; i < toolStripMenuItems.Length; i++)
            {
                toolStripMenuItems[i].Tag = (PictureBoxSizeMode)i;
            }
        }

        private void SizeMode_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem toolStripMenuItem = sender as ToolStripMenuItem;
            pictureBox1.SizeMode = (PictureBoxSizeMode)toolStripMenuItem.Tag;
        }

        private void 종ㄹToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
            // Environment.Exit(0);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            label1.Text = e.X.ToString();
            label2.Text = e.Y.ToString();
            
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            label1.Text = e.X.ToString();
            label2.Text = e.Y.ToString();
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            label1.Text = e.X.ToString();
            label2.Text = e.Y.ToString();
        }
    }
}
