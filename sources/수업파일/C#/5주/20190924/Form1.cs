using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace A143_GradeCalc
{
    public partial class Form1 : Form
    {
        TextBox[] titles;
        ComboBox[] crds;
        ComboBox[] grds;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txt1.Text = "프로그래밍 언어활용";
            txt2.Text = "응용SW기초기술활용";
            txt3.Text = "요구사항 확인";
            txt4.Text = "SQL응용";
            txt5.Text = "데이터베이스 구현";
            txt6.Text = "화면 설계";
            txt7.Text = "화면 구현";

            crds = new ComboBox[] { crd1, crd2, crd3, crd4, crd5, crd6, crd7 };
            grds = new ComboBox[] { grd1, grd2, grd3, grd4, grd5, grd6, grd7 };
            titles = new TextBox[] { txt1, txt2, txt3, txt4, txt5, txt6, txt7 };
            int[] arrCredit = { 1, 2, 3, 4, 5 };
            
            foreach (var combo in crds)
            {
                foreach (var i in arrCredit)
                    combo.Items.Add(i);
                combo.SelectedItem = 3;
            }

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

            foreach (var cb in grds)
            {
                cb.DataSource = new BindingSource(schList, null);
                cb.DisplayMember = "Key"; //Text
                cb.ValueMember = "Value"; //Value
                cb.SelectedIndex = 0;
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            double totalScore = 0;
            int totalCredits = 0;

            for (int i = 0; i < crds.Length; i++)
            {
                if (titles[i].Text != "")
                {
                    int crd = int.Parse(crds[i].SelectedItem.ToString());
                    totalCredits += crd;
                    totalScore += crd * Convert.ToDouble(grds[i].SelectedValue);
                }
            }
            txtGrade.Text = (totalScore / totalCredits).ToString("0.00");
        }
    }
}
