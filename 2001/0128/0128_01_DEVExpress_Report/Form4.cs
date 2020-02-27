using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0128_01_DEVExpress_Report
{
    public partial class Form4 : Form
    {
        #region Serial Ports
        // 시리얼 포트
        private SerialPort _Port;
        /// <summary>
        /// 시리얼포트 컨트롤 객체
        /// </summary>
        private SerialPort Port
        {
            get
            {
                if (_Port == null)
                {
                    _Port = new SerialPort();
                    _Port.PortName = "COM5";
                    _Port.BaudRate = 9600;
                    _Port.DataBits = 8;
                    _Port.Parity = Parity.None;
                    _Port.Handshake = Handshake.None;
                    _Port.StopBits = StopBits.One;
                    _Port.Encoding = Encoding.UTF8;
                    _Port.DataReceived += Port_DataReceived;
                }
                return _Port;
            }
        }
        /// <summary>
        /// 시리얼포트 상태 및 컨트롤 제어
        /// </summary>
        private Boolean IsOpen
        {
            get { return Port.IsOpen; }
            set
            {
                if (value)
                {
                }
                else
                {
                }
            }
        }
        /// <summary>
        /// SerialPort : Data Received Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            Thread.Sleep(500);
            String msg = Port.ReadExisting();

            this.Invoke(new EventHandler(delegate
            {
                Strings = msg;
            }));
        }

        /* 로그 제어 */
        private StringBuilder _Strings;
        /// <summary>
        /// 로그 객체
        /// </summary>
        private String Strings
        {
            set
            {
                if (_Strings == null)
                    _Strings = new StringBuilder(1024);
                // 로그 길이가 1024자가 되면 이전 로그 삭제
                if (_Strings.Length >= (1024 - value.Length))
                    _Strings.Clear();
                // 로그 추가 및 화면 표시
                _Strings.AppendLine(value);
                textBox1.Text = _Strings.ToString();
            }
        }
        #endregion

        // 메인
        public Form4()
        {
            InitializeComponent();
        }
        private void SerialPortConnect()
        {
            if (!Port.IsOpen)
            {
                // 현재 시리얼이 연결된 상태가 아니면 연결.
                Port.PortName = "COM5";
                Port.BaudRate = 9600;
                Port.DataBits = 8;
                Port.Parity = Parity.None;
                Port.Handshake = Handshake.None;

                try
                {
                    // 연결
                    Port.Open();
                }
                catch (Exception ex) {
                    MessageBox.Show("[ERR] {0}", ex.Message);
                }
            }
            else
            {
                // 현재 시리얼이 연결 상태이면 연결 해제
               // Port.Close();
            }

            // 상태 변경
            IsOpen = Port.IsOpen;
        }

        private void Form4_Activated(object sender, EventArgs e)
        {
            SerialPortConnect();
        }
        private void Form4_Deactivate(object sender, EventArgs e)
        {
           // Port.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.IndexOf('/') > 0)
            {
                string barID = textBox1.Text.Split('/')[0];
                textBox1.Text = barID;
            }
            if (textBox1.Text.Length >= 5)
            {
                button1.PerformClick();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        { // 출고버튼
            // 출고정보 조회 -> 라벨
            // 출고 확인 메세지 처리
            // DB 출고 처리 , 버퍼 지우기

            if (textBox1.Text.Trim().Length < 1)
            {
                MessageBox.Show("번호를 입력해주세요");
                return;
            }

            int barID = Convert.ToInt32(textBox1.Text); // textBox1.Text.TrimStart('0')

            string connstr = ConfigurationManager.ConnectionStrings["mydbconn"].ConnectionString;
            string sql =
@"SELECT p.ProductName
      ,[Qty]
	  ,QuantityPerUnit
  FROM [dbo].[BarcodeOutput] b
  JOIN Products p ON b.ProductID = p.ProductID
  WHERE b.BarcodeID = @barID";

            using (SqlCommand comm = new SqlCommand(sql))
            {
                comm.Connection = new SqlConnection(connstr);

                comm.Parameters.AddWithValue("@barID", barID);
                comm.Connection.Open();
                SqlDataReader reader = comm.ExecuteReader();
                if (reader.Read())
                {
                    label1.Text = $" {reader["ProductName"]} - 출고 - {reader["Qty"]} 개";
                }
            }
            if(label1.Text.Length > 0)
            {
                if(MessageBox.Show($"{label1.Text} 출고를 확정하시겠습니까?","출고확인", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // 실제 DB에서 재고 작업
                    label1.Text = "";
                    _Strings.Clear();
                    textBox1.Clear();
                    textBox1.Focus();
                }
            }
        }
    }
}
