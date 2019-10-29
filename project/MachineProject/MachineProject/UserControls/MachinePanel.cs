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
        public int TotalAmount { get => int.Parse(lblTotalAmount_V.Text); set => lblTotalAmount_V.Text = value.ToString(); }
        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always)]
        public int DefectAmount { get => int.Parse(lblDefectAmount_V.Text); set => lblDefectAmount_V.Text = value.ToString(); }
        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always)]
        public double DefectRate { get => double.Parse(lblDefectRate_V.Text); set => lblDefectRate_V.Text = value.ToString(); }
        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always)]
        public double DefectRateAlarm { get => double.Parse(lblDefectRateAlarm_V.Text); set => lblDefectRateAlarm_V.Text = value.ToString(); }

        private void MachinePanel_Load(object sender, EventArgs e)
        {
            panel1.BorderStyle = BorderStyle.FixedSingle;

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
            public int TotalAmount;
            public int DefectAmount;
            public double DefectRate;
            public double DefectRateAlarm;
            public values(string machineName, int totalAmount, int defectAmount, double defectRate, double defectRateAlarm)
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
