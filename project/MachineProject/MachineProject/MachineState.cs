using RecursiveForChangeControls_MachineProject;
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
    public partial class MachineState : Form
    {
        public MachineState()
        {
            InitializeComponent();
        }

        private void MachineState_Load(object sender, EventArgs e)
        {

            RecursiveForChangeControls rcontrols = new RecursiveForChangeControls();
            rcontrols.ChangeControls(this.Controls, GlobalUsage.ChangeFont);
        }
    }
}
