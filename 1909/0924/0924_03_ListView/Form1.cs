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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add(View.LargeIcon);
            comboBox1.Items.Add(View.Details);
            comboBox1.Items.Add(View.List);
            comboBox1.Items.Add(View.SmallIcon);
            comboBox1.Items.Add(View.Tile);
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listView1.View = (View)comboBox1.SelectedItem;
        }
    }
}
