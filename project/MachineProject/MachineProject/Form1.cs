using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MachineProject
{
    public partial class Form1 : Form
    {
        List<string> alamList;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            alamList = new List<string>();

            NewMachineMenu("Machine01");
            NewMachineMenu("Machine02");

            ClientSize = new Size(400, 200);

        }

        private void NewMachineMenu(string machineName)
        {
            ToolStripMenuItem Machine = new ToolStripMenuItem();

            Machine.Checked = true;
            Machine.CheckState = CheckState.Unchecked;
            Machine.Name = machineName;
            Machine.Size = new Size(180, 22);
            Machine.Text = machineName;
            Machine.CheckOnClick = true;
            Machine.CheckedChanged += Machines_CheckedChanged;

            machinesToolStripMenuItem.DropDownItems.Add(Machine);

            NewMachineItem(machineName);
        }
        private void NewMachineItem(string machineName)
        {
            Panel pan = new Panel();
            pan.Size = new Size(262, 420);
            pan.Tag = "";

            Label label = new Label();







        }

        private void Machines_CheckedChanged(object sender, EventArgs e)
        {
            if(sender is ToolStripMenuItem)
            {
                ToolStripMenuItem item = sender as ToolStripMenuItem;
                if (item.Checked)
                {

                }
            }

            List<string> vw = new List<string>();
            IEnumerable<string> vs = vw.Select((elem) => elem);
        }

        private void MachinePan_MouseClick(object sender, MouseEventArgs e)
        {

        }

        //private void MachineListBox_MouseClick(object sender, MouseEventArgs e)
        //{

        //}
    }
}
