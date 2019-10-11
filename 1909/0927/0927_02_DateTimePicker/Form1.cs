using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0927_02_DateTimePicker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //dateTimePicker1.Value = Convert.ToDateTime("2000-07-24");
            //dateTimePicker1.Value = DateTime.Parse("2000-07-24");
            //dateTimePicker1.Value = DateTime.ParseExact("2000-07-24", "yyyy-MM-dd", null);

            dateTimePicker2.Value = DateTimePicker.MinimumDateTime;

            //dateTimePicker1.Value = DateTime.Now.AddDays(-7);

            MessageBox.Show(dateTimePicker2.Text.ToString());
        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            textBox1.Text = "오늘부터 선택한 날짜까지 : " + (DateTime.Now - dateTimePicker1.Value).Days.ToString();
            textBox1.Text = "오늘부터 선택한 날짜까지 : "+dateTimePicker2.Text.ToString();
        }

        private void DateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePicker2.Value == DateTimePicker.MinimumDateTime)
            {
                dateTimePicker2.Value = DateTime.Now;
                dateTimePicker2.Format = DateTimePickerFormat.Custom;
                dateTimePicker2.CustomFormat = " ";
            }
            else
            {
                dateTimePicker2.Format = DateTimePickerFormat.Short;
            }
        }
    }
}
