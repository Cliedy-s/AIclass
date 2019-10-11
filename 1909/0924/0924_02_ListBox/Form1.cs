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

namespace _0924_02_ListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnSendAll_Click(object sender, EventArgs e)
        {
            foreach (var fruit in cklFruits.Items)
            {
                lstSelectedFruits.Items.Add(fruit);
            }
        }

        private void BtnSendChecked_Click(object sender, EventArgs e)
        {
            foreach (var fruit in cklFruits.CheckedItems)
            {
                lstSelectedFruits.Items.Add(fruit);
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            while (lstSelectedFruits.SelectedItems.Count > 0)
            {
                lstSelectedFruits.Items.Remove(lstSelectedFruits.SelectedItems[0]);
            }

            //List<string> lst = new List<string>();
            //for (int i = 0; i < lstSelectedFruits.SelectedItems.Count; i++)
            //{
            //    lst.Add(lstSelectedFruits.SelectedItems[i].ToString());
            //}
            //foreach (string fruit in lst)
            //{
            //    lstSelectedFruits.Items.Remove(fruit);
            //}

            //foreach (var fruit in lstSelectedFruits.SelectedItems)
            //{
            //    lstSelectedFruits.Items.Remove(fruit);
            //}
        }

        private void BtnReverse_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstSelectedFruits.Items.Count; i++)
            {
                //if (lstSelectedFruits.GetSelected(i) == true)
                //    lstSelectedFruits.SetSelected(i, false);
                //else
                //    lstSelectedFruits.SetSelected(i, true);
                lstSelectedFruits.SetSelected(i, !lstSelectedFruits.GetSelected(i));
            }
            lstSelectedFruits.TopIndex = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            cklFruits.TopIndex = 9;
            cklFruits.SetItemChecked(1, true);
        }
    }
}
