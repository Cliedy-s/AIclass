using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0924_01_ComboBox
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Dictionary<string, string> dicGraduate = new Dictionary<string, string>();
            dicGraduate.Add("==선택==", "");
            dicGraduate.Add("초등학교졸", "001");
            dicGraduate.Add("중학교졸", "002");
            dicGraduate.Add("고등학교졸", "003");
            dicGraduate.Add("전문대졸", "004");
            dicGraduate.Add("대학교졸", "005");

            cmbGraduate.DataSource = new BindingSource(dicGraduate, null);
            cmbGraduate.DisplayMember = "Key";
            cmbGraduate.ValueMember = "Value";
            cmbGraduate.SelectedIndex = 4;
            
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cmbGraduate.SelectedValue.ToString()))
            {
                KeyValuePair<string, string> key = (KeyValuePair<string, string>)cmbGraduate.SelectedItem;
                MessageBox.Show(string.Format("{0} :: {1}", key.Key, key.Value), "Hello", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button3);
                //string.Format("{0} :: {1}", key.Key, key.Value))
                //MessageBox.Show(string.Format("{0} :: {1}", cmbGraduate.Text, cmbGraduate.SelectedValue));
            }

        }
    }
}
