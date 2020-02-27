using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Log4NetTest
{
    public partial class Form1 : Form
    {
        //log4net의 레벨
        //ALL, DEBUG, INFO, WARN, ERROR, FATAL, OFF
        //ALL / OFF 자주 사용안함
        public Form1()
        {
            Program.log.Debug("InitializeComponent 호출전");
            InitializeComponent();
            Program.log.Debug("InitializeComponent 호출후");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Program.log.Debug("Load 이벤트 - Debug");
            Program.log.Info("Load 이벤트 - Info");
            Program.log.Warn("Load 이벤트 - Warn");
            Program.log.Error("Load 이벤트 - Error");
        }
    }
}
