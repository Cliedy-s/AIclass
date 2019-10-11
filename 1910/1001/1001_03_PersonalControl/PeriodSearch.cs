using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1001_03_CustomControl
{
    public enum Period { Month, Year, Week, Day3, Day0 };
    public partial class PeriodSearch : UserControl
    {
        private Period period;
        public Period Period { get => period; set {  period = value;  setPeriod(period); }  }
        public DateTime StartDate { get => dateTimePicker1.Value; set => dateTimePicker1.Value = value; }
        public DateTime EndDate
        {
            get => dateTimePicker2.Value;
            set
            {
                dateTimePicker2.Value = value;
                setPeriod(period);
            }
        }
        public PeriodSearch()
        {
            InitializeComponent();
            period = Period.Week;
            EndDate = DateTime.Now.AddDays(1);
        }
        private void setPeriod(Period period)
        {
            switch (period)
            {
                case Period.Month:
                    dateTimePicker1.Value = dateTimePicker2.Value.AddMonths(-1);
                    break;
                case Period.Year:
                    dateTimePicker1.Value = dateTimePicker2.Value.AddYears(-1);
                    break;
                case Period.Week:
                    dateTimePicker1.Value = dateTimePicker2.Value.AddDays(-7);
                    break;
                case Period.Day3:
                    dateTimePicker1.Value = dateTimePicker2.Value.AddDays(-3);
                    break;
                case Period.Day0:
                    dateTimePicker1.Value = dateTimePicker2.Value;
                    break;

            }
        }

        public event EventHandler EndDateChanged;

        private void DateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            if(EndDateChanged != null)
            {
                EndDateChanged(this, e);
            }
        }
    }
}
