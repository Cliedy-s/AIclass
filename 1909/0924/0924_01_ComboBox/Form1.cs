using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0924_01_ComboBox
{
    public partial class Form1 : Form
    {
        ComboBox[] comboboxsPoint;
        ComboBox[] comboboxsScore;

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnGetResult_Click(object sender, EventArgs e)
        {
            MessageBox.Show(comboboxsScore[0].Text);
            double sum = 0;
            double sumDivide = 0;

            for (int i = 0; i < comboboxsPoint.Length; i++)
            {
                if (comboboxsScore[i].SelectedIndex == 0) { MessageBox.Show("성적을 선택해 주세요"); return; }
                //sum += (comboboxsPoint[i].SelectedIndex + 1) * (4.5 - (comboboxsScore[i].SelectedIndex - 1 * 0.5));
                sumDivide += (comboboxsPoint[i].SelectedIndex + 1);
                sum += sumDivide * Convert.ToDouble(comboboxsScore[i].SelectedValue);
            }

            txtResult.Text = string.Format("{0:F2}", (sum / sumDivide));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtClass01.Text = "국어";
            txtClass02.Text = "수학";
            txtClass03.Text = "사회";
            txtClass04.Text = "과학";
            txtClass05.Text = "영어";
            txtClass06.Text = "도덕";
            txtClass07.Text = "인문";

            comboboxsPoint = new ComboBox[] { cmbPoint01, cmbPoint02, cmbPoint03, cmbPoint04, cmbPoint05, cmbPoint06, cmbPoint07 };
            comboboxsScore = new ComboBox[] { cmbScore01, cmbScore02, cmbScore03, cmbScore04, cmbScore05, cmbScore06, cmbScore07 };
            // string[] strings = new string[] { "<<선택>>", "A+", "A0", "B+", "B0", "C+", "C0", "D+", "D0" };
            Dictionary<string, double> schList = new Dictionary<string, double>();
            schList.Add("==선택==", 0);
            schList.Add("A+", 4.5);
            schList.Add("A0", 4.0);
            schList.Add("B+", 3.5);
            schList.Add("B0", 3.0);
            schList.Add("C+", 2.5);
            schList.Add("C0", 2.0);
            schList.Add("D+", 1.5);
            schList.Add("D0", 1.0);

            foreach (var item in comboboxsScore)
            {
                item.DataSource = new BindingSource(schList, null);
                item.DisplayMember = "Key";
                item.ValueMember = "Value";
                item.SelectedItem = 0;
            }

            foreach (var item in Controls)
            {
                if (item is ComboBox)
                {
                    ComboBox comboBox = item as ComboBox;
                    if (comboBox.Tag.ToString() == "point")
                    {
                        for (int i = 1; i < 6; i++)
                        {
                            comboBox.Items.Add(i);
                        }
                        comboBox.SelectedIndex = 2;
                    }
                    //if (comboBox.Tag.ToString() == "score")
                    //{
                    //    comboBox.Items.AddRange(strings);
                    //    comboBox.SelectedIndex = 0;
                    //}
                }
            }
        }
    }
}
