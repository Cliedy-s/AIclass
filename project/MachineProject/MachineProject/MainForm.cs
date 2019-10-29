using DinamicControlCreate;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RecursiveForChangeControls_MachineProject;


namespace MachineProject
{
    public partial class MainForm : Form
    {
        int authority = 0b0001;
        List<string> alamList;
        DControls dcontrols;
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 로그인폼
            LoginForm login = new LoginForm();
            if(!(login.ShowDialog() == DialogResult.OK))
            {
                Environment.Exit(0);
            }
            //

            // 매니저 권한 지정 // TODO - 사용자의 권한으로 변경
            if (login.ID == "1") authority = 0b0010;
            else authority = 0b0001;

            //flowlayoutpanel 내부 설정
            flpBase.AutoScroll = true; //스크롤 설정
            panForWork.Location = panForDefectAlarm.Location = new Point(0, 0); // 내부 알람패널, 일 패널 위치
            splitContainer1.SplitterDistance = 550; // 스플릿 거리 
            nudNewDefectRateAlarm.DecimalPlaces = 2; // 누메릭업다운 소수점 설정


            // TODO - 지우기 : 메뉴를 임시로 생성함.
            for (int i = 0; i < 11; i++)
            {
                NewMenuItem("item" + "Machine0" + i, flpBase);
            }
            NewMenuItem("itemTotalSelect", "전체선택", Total_CheckedChanged, true);
            //

            // 권한에 따라 다른 폼을 보여주는 부분----------------
            if((authority & 0b0010) == 0b0010) // 관리자 권한
            {
                worksToolStripMenuItem.Visible = true;
                panForDefectAlarm.Visible = true;
                panForWork.Visible = false;
                NewMenuItem("itemMachineState", "기계상태확인", CheckMachineState_Click);
            }
            else if ((authority & 0b0001) == 0b0001) // 일반 사용자 권한
            {
                worksToolStripMenuItem.Visible = false;
                panForDefectAlarm.Visible = false;
                panForWork.Visible = true;
            }
            //-------------------------------------------------------------

            // 알람 리스트
            alamList = new List<string>();

            // 자식까지 폰트를 바꿈..
            RecursiveForChangeControls rcontrols = new RecursiveForChangeControls();
            rcontrols.ChangeControls(this.Controls, GlobalUsage.ChangeFont);
        }


        // 메뉴 아이템 생성 모듈 => 머신 메뉴를 위함
        /// <summary>
        /// 머신메뉴 생성
        /// </summary>
        private void NewMenuItem(string machineName, Control chileToContainer)
        {
            ToolStripMenuItem Machine = new ToolStripMenuItem();

            Machine.CheckState = CheckState.Unchecked;
            Machine.Name = machineName;
            Machine.Text = machineName;
            Machine.CheckOnClick = true;
            Machine.CheckedChanged += Machines_CheckedChanged;
            Machine.Tag = chileToContainer;

            machinesToolStripMenuItem.DropDownItems.Add(Machine);
        }
        // 전체 머신 메뉴 선택
        /// <summary>
        /// 전체 머신메뉴 선택 아이템
        /// </summary>
        private void NewMenuItem(string menuName, string itemText, EventHandler method, bool checkOnClick)
        {
            ToolStripMenuItem item = new ToolStripMenuItem();

            item.CheckState = CheckState.Unchecked;
            item.Name = menuName;
            item.Text = itemText;
            item.CheckOnClick = checkOnClick;
            item.CheckedChanged += method;

            machinesToolStripMenuItem.DropDownItems.Add(item);
        }

        // 메뉴 아이템 생성 모듈 => 일반 메뉴
        /// <summary>
        /// 일반 메뉴 생성
        /// </summary>
        private void NewMenuItem(string menuName, string itemText, EventHandler method)
        {
            ToolStripMenuItem item = new ToolStripMenuItem();

            item.Name = menuName;
            item.Text = itemText;
            item.Click += method;
            item.Tag = "nomalMenu";

            machinesToolStripMenuItem.DropDownItems.Add(item);
        }

        // 머신 메뉴 아이템을 체크할 때
        // => 머신 불량률 패널 생성(flpBase)
        private void Machines_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is ToolStripMenuItem)
            {
                ToolStripMenuItem item = sender as ToolStripMenuItem;
                if (item.Checked)
                {
                    NewMachineItem(item.Text, item.Tag as Control);
                }
                else
                {
                    (item.Tag as Control).Controls.RemoveByKey(item.Text);
                }
            }
        }
        // 전체 기계 메뉴 체크
        private void Total_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is ToolStripMenuItem)
            {
                ToolStripMenuItem me = sender as ToolStripMenuItem;
                foreach (ToolStripMenuItem item in machinesToolStripMenuItem.DropDownItems)
                {
                    // 아이템을 생성할 때 머신메뉴의 태그에만 컨트롤을 삽입함
                    if (item.Tag is Control) item.Checked = me.Checked; 
                }
            }
        }
        // 기계 상태확인 열기 메소드
        private void CheckMachineState_Click(object sender, EventArgs e)
        {
            MachineStateForm frm = new MachineStateForm();
            frm.ShowDialog();
        }
        //

        // 기계 패널 생성 유저컨트롤을 가져옴
        private void NewMachineItem(string machineName, Control container)
        {
            MachinePanel machinePanel = new MachinePanel();
            machinePanel.Name = machineName;
            machinePanel.MachineName = machineName;
            machinePanel.doubleClick += MachinePanel_doubleClick; // 더블클릭 이벤트 핸들러 => 더블클릭시 실행
            container.Controls.Add(machinePanel);
        }

        // 기계 패널을 더블클릭했을 때
        private void MachinePanel_doubleClick(object sender, MachinePanel.MachineStringsEventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(e.ReturnValues.MachineName.ToString());
            sb.AppendLine(e.ReturnValues.TotalAmount.ToString());
            sb.AppendLine(e.ReturnValues.DefectAmount.ToString());
            sb.AppendLine(e.ReturnValues.DefectRate.ToString());
            sb.AppendLine(e.ReturnValues.DefectRateAlarm.ToString());
            MessageBox.Show(sb.ToString());

            lblMachineName.Text = e.ReturnValues.MachineName;
            lblOldDefectRateAlarm.Text = string.Format("{0}",e.ReturnValues.DefectRateAlarm);
            nudNewDefectRateAlarm.Value = Convert.ToDecimal(e.ReturnValues.DefectRateAlarm);
        }
        //


        #region Test
        // 머신 불량률 패널 생성
        //private void NewMachineItem(string machineName, Control container)
        //{
        //    string panName = "pan" + machineName;

        //    create panel
        //    container.Controls.Add(dcontrols.CreatePanel(panName));
        //    Control chileContainer = container.Controls.Find(panName, true)[0] as Control;

        //    create listBox
        //    chileContainer.Controls.Add(dcontrols.CreateListBox("lst" + machineName));

        //    create labels
        //     MachineName
        //    chileContainer.Controls.Add(dcontrols.CreateLabel("lbl" + machineName, machineName, new Point(15, 305), new Font("나눔고딕", 12, FontStyle.Bold)));
        //     전체 상품수, 불량 상품수 ...
        //    Point pointKey = new Point(17, 329);
        //    Point pointValue = new Point(137, 329);

        //    string[] keyStrs = new string[] { "전체 상품 수", "불량 상품 수", "불량률", "불량률 마지노선" };
        //    string[] valueStrs = new string[] { "전체 상품 수", "불량 상품 수", "불량률", "불량률 마지노선" };
        //    string[] valueStrs = new string[] { "0개", "0개", "0%", "0%" };
        //    for (int i = 0; i < 4; i++)
        //    {
        //        chileContainer.Controls.Add(dcontrols.CreateLabel("lblK", keyStrs[i], pointKey));
        //        chileContainer.Controls.Add(dcontrols.CreateLabel("lblV" + machineName, valueStrs[i], pointValue, default, false, new Size(105, 19), ContentAlignment.MiddleRight));
        //        if (i == 1)
        //        {
        //            pointKey.Y = pointKey.Y + 25;
        //            pointValue.Y = pointValue.Y + 25;
        //        }
        //        else
        //        {
        //            pointKey.Y = pointKey.Y + 20;
        //            pointValue.Y = pointValue.Y + 20;
        //        }
        //    }

        //}

        ////메뉴 아이템을 체크할 때 => 머신 불량률 패널 생성(flpBase)
        //private void Machines_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (sender is ToolStripMenuItem)
        //    {
        //        ToolStripMenuItem item = sender as ToolStripMenuItem;
        //        if (item.Checked)
        //        {
        //            NewMachineItem(item.Text, item.Tag as Control);
        //        }
        //    }
        //}
        #endregion

        private void TodoSetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WorkForm frm = new WorkForm();
            frm.ShowDialog();
        }

        private void ShowMyInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MyInfoForm frm = new MyInfoForm();
            frm.ShowDialog();
        }
    }
}
