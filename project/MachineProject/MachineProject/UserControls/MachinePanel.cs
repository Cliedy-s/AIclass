using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MachineProject
{
    public partial class MachinePanel : UserControl
    {
        public MachinePanel()
        {
            InitializeComponent();
        }

        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always)]
        public string MachineName { get => lblMahineName.Text; set => lblMahineName.Text = value; }
        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always)]
        public string TotalAmount { get => lblTotalAmount_V.Text; set => lblTotalAmount_V.Text = value; }
        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always)]
        public string DefectAmount { get => lblDefectAmount_V.Text; set => lblDefectAmount_V.Text = value; }
        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always)]
        public string DefectRate { get => lblDefectRate_V.Text; set => lblDefectRate_V.Text = value; }
        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always)]
        public string DefectRateAlarm { get => lblDefectRateAlarm_V.Text; set => lblDefectRateAlarm_V.Text = value; }

        private void MachinePanel_Load(object sender, EventArgs e)
        {
            panel1.DoubleClick += All_DoubleClick;
            foreach (Control item in panel1.Controls)
            {
                item.DoubleClick += All_DoubleClick;
            }
        }

        private void All_DoubleClick(object sender, EventArgs e)
        {
            if (doubleClick != null)
            {
                MachineStringsEventArgs E = new MachineStringsEventArgs();
                E.ReturnValues = new values(MachineName, TotalAmount, DefectAmount, DefectRate, DefectRateAlarm);
                doubleClick(this, E);
            }
        }

        public delegate void MachineEventHandler(object sender, MachineStringsEventArgs e);
        public event MachineEventHandler doubleClick;
        public class MachineStringsEventArgs : EventArgs
        {
            public values ReturnValues { get; set; }
        }
        public struct values
        {
            public string MachineName;
            public string TotalAmount;
            public string DefectAmount;
            public string DefectRate;
            public string DefectRateAlarm;
            public values(string machineName, string totalAmount, string defectAmount, string defectRate, string defectRateAlarm)
            {
                MachineName = machineName;
                TotalAmount = totalAmount;
                DefectAmount = defectAmount;
                DefectRate = defectRate;
                DefectRateAlarm = defectRateAlarm;
            }
        }
    }

}
