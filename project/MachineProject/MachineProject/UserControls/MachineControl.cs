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
    public partial class MachineControl : UserControl
    {
        public enum eMachineState { Run ,Running, Stop, Stopping, Crash }
        eMachineState machineState = eMachineState.Stop;
        public string MachineName { get => txtMachineName.Text; set => txtMachineName.Text = value; }
        string MachineStateText { get => txtMachineState.Text; set => txtMachineState.Text = value; }
        public eMachineState MachineState {
            get {
                return machineState;
            }
            set {
                switch (value)
                {
                    case eMachineState.Run:
                        MachineStateText = Properties.Resources.MachineState_Run;
                        break;
                    case eMachineState.Running:
                        MachineStateText = Properties.Resources.MachineState_Running;
                        break;
                    case eMachineState.Stop:
                        MachineStateText = Properties.Resources.MachineState_Stop;
                        break;
                    case eMachineState.Stopping:
                        MachineStateText = Properties.Resources.MachineState_Stopping;
                        break;
                    case eMachineState.Crash:
                        MachineStateText = Properties.Resources.MachineState_Crash;
                        break;

                }
                machineState = value;
            }
        }

        public MachineControl()
        {
            InitializeComponent();
        }

        private void MachineControl_Load(object sender, EventArgs e)
        {
            panel1.BorderStyle = BorderStyle.FixedSingle;

            // TODO - 기계가 실행 중인지 알아오는 부분 요구
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            RunMachine();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            StopMachine();
        }

        public void RunMachine()
        {
            // TODO - 기계 실행
            MachineState = eMachineState.Running;
            MachineState = eMachineState.Run;
        }
        public void StopMachine()
        {
            // TODO - 기계 중지
            MachineState = eMachineState.Stopping;
            MachineState = eMachineState.Stop;
        }
    }
}
