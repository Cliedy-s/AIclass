using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0925_02_NetwordProgram_Server_WinForm
{
    public partial class Form1 : Form
    {
        private TcpListener myListener;
        private Encoding encodingDefault = Encoding.Default;
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnStartSever_Click(object sender, EventArgs e)
        {
            try
            {
                IPEndPoint localaddress = new IPEndPoint(IPAddress.Parse(txtIP.Text), int.Parse(txtPort.Text));
                myListener = new TcpListener(localaddress);
                myListener.Start();

                Thread startServer = new Thread(new ThreadStart(ServerProcess));
            }
            catch (SocketException err) {

            }

        }

        public  void ListShow(string str)
        {
            listBox1.Items.Add(str);
        }

        private void PrintMessage() { }

        public void ServerProcess() {

        }
    }
}
