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
using MachineProject.Services;
using MachineProject.DTO;

namespace MachineProject
{
    public partial class MainForm : Form
    {
        int authority = 0b0001; // 권한
        List<string> alamList;
        public MainForm()
        {
            InitializeComponent();
        } //생성자

        private void MainForm_Load(object sender, EventArgs e)
        {
            // 로그인폼
            LoginForm login = new LoginForm();
            if (!(login.ShowDialog() == DialogResult.OK))
            {
                Environment.Exit(0);
            }
            //

            // 사용자 권한 지정
            authority = GlobalUsage.MyInfo.Authority;

            //flowlayoutpanel 내부 설정
            flpBase.AutoScroll = true; //스크롤 설정
            panForWork.Location = panForDefectAlarm.Location = new Point(0, 0); // 내부 알람패널, 일 패널 위치
            splitContainer1.SplitterDistance = this.ClientSize.Width - 301; // 스플릿 거리 
            nudNewDefectRateAlarm.DecimalPlaces = 2; // 누메릭업다운 소수점 설정

            // 권한에 따라 다른 폼을 보여주는 부분----------------
            panForWork.Dock = DockStyle.Fill;
            panForDefectAlarm.Dock = DockStyle.Fill;
            if ((authority & 0b0010) == 0b0010) // 관리자 권한
            {
                // 화면 Visible설정
                worksToolStripMenuItem.Visible = true;
                panForDefectAlarm.Visible = true;
                panForWork.Visible = false;
                employeesToolStripMenuItem.Visible = true;

                LoadEmpDgv(); // 데이터 로드 및 쌍이되는 메뉴 생성
            }
            else if ((authority & 0b0001) == 0b0001) // 일반 사용자 권한
            {
                // 화면 Visible설정
                worksToolStripMenuItem.Visible = false;
                panForDefectAlarm.Visible = false;
                panForWork.Visible = true;
                employeesToolStripMenuItem.Visible = false;

                // 그리드뷰 세팅
                GlobalUsage.SetDataGridView(dgvTodo);
                // 칼럼 넣기
                DataGridViewAddColumns.DataGridViewAddColumns addcol = new DataGridViewAddColumns.DataGridViewAddColumns();
                addcol.AddNewColumnToDataGridView("코드", "TodoCode", dgvTodo, typeof(int), 25);
                addcol.AddNewColumnToDataGridView("기계ID", "MachineID", dgvTodo, typeof(string), 60);
                addcol.AddNewColumnToDataGridView("제품ID", "ProductionID", dgvTodo, typeof(string), 60);
                addcol.AddNewColumnToDataGridView("완료", "Complete", dgvTodo, typeof(char), 25);
                addcol.AddNewColumnToDataGridView("갯수", "Amount", dgvTodo, typeof(int), 60, null, true, DataGridViewContentAlignment.MiddleLeft);
                addcol.AddNewColumnToDataGridView("완료날짜", "CompleteDate", dgvTodo, typeof(DateTime), 100);
                addcol.AddNewColumnToDataGridView("직원ID", "EmployeeID", dgvTodo, typeof(string), 60);
                addcol.AddNewColumnToDataGridView("계획", "ProductionPlanCode", dgvTodo, typeof(int), 25);

                //메뉴 생성
                LoadEmpDgv(); // 데이터 로드 및 쌍이되는 메뉴 생성
            }
            // 공통 메뉴
            NewMenuItem("itemTotalSelect", "전체선택", Total_CheckedChanged, true);
            //-------------------------------------------------------------

            // 알람 리스트
            alamList = new List<string>();

            // 자식까지 폰트를 바꿈..
            RecursiveForChangeControls rcontrols = new RecursiveForChangeControls();
            rcontrols.ChangeControls(this.Controls, GlobalUsage.ChangeFont);
        } // 폼 로드
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
        } // 메뉴 아이템 생성 => 머신 메뉴를 위함
        private void NewMenuItem(string menuName, string itemText, EventHandler method, bool checkOnClick)
        {
            ToolStripMenuItem item = new ToolStripMenuItem();

            item.CheckState = CheckState.Unchecked;
            item.Name = menuName;
            item.Text = itemText;
            item.CheckOnClick = checkOnClick;
            item.CheckedChanged += method;

            machinesToolStripMenuItem.DropDownItems.Add(item);
        } // 전체 머신 메뉴 선택
        private void NewMenuItem(string menuName, string itemText, EventHandler method)
        {
            ToolStripMenuItem item = new ToolStripMenuItem();

            item.Name = menuName;
            item.Text = itemText;
            item.Click += method;
            item.Tag = "nomalMenu";

            machinesToolStripMenuItem.DropDownItems.Add(item);
        } // 메뉴 아이템 생성 => 일반 메뉴
        private void NewMachineItem(string machineName, Control container)
        {
            MachinePanel machinePanel = new MachinePanel();
            machinePanel.Name = machineName;
            machinePanel.MachineName = machineName;
            machinePanel.doubleClick += MachinePanel_doubleClick; // 더블클릭 이벤트 핸들러 => 더블클릭시 실행
            machinePanel.setDgvBackground += SetDGVBackColor;
            container.Controls.Add(machinePanel);
        } // 기계 패널 생성 유저컨트롤을 가져옴

        private void Machines_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is ToolStripMenuItem)
            {
                ToolStripMenuItem item = sender as ToolStripMenuItem;
                if (item.Checked)
                {
                    if (flpBase.Controls.Find(item.Text, false).Length > 1) return; // 패널이 있으면 리턴
                    NewMachineItem(item.Text, flpBase);
                }
                else
                {
                    if (flpBase.Controls.Find(item.Text, false).Length < 1) return; // 패널이 없을 때 리턴
                    MachinePanel childPanel = flpBase.Controls.Find(item.Text, false)[0] as MachinePanel;
                    if (childPanel.MachineState == 1) // 실행중일 때
                    {
                        MessageBox.Show(Properties.Resources.Error_MachineRunning_msg);
                        item.CheckedChanged -= Machines_CheckedChanged;
                        item.Checked = true;
                        item.CheckedChanged += Machines_CheckedChanged;
                        return;
                    }

                    SetDGVBackColor(childPanel.MachineName, Color.White);

                    (item.Tag as Control).Controls.RemoveByKey(item.Text); // 컨트롤 제거
                    ToolStripMenuItem totalitem = machinesToolStripMenuItem.DropDownItems.Find("itemTotalSelect", false)[0] as ToolStripMenuItem; // 전체선택 메뉴
                    totalitem.CheckedChanged -= Total_CheckedChanged;
                    totalitem.Checked = false; // 체크가 풀릴시 전체선택을 취소함
                    totalitem.CheckedChanged += Total_CheckedChanged;
                }
                //MessageBox.Show((flpBase.Controls.Find(item.Text, false)[0] as MachinePanel).MachineState.ToString());
            }
        } // 머신 메뉴 아이템을 체크할 때 => 머신 불량률 패널 생성(flpBase) <=> 체크를 풀 때 제거
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
        } // 전체 기계 메뉴 체크
        private void MachinePanel_doubleClick(object sender, MachinePanel.MachineStringsEventArgs e)
        {
            lblMachineName.Text = e.ReturnValues.MachineName;
            lblOldDefectRateAlarm.Text = string.Format("{0}", e.ReturnValues.DefectRateAlarm);
            nudNewDefectRateAlarm.Value = Convert.ToDecimal(e.ReturnValues.DefectRateAlarm);
        } // 기계 패널을 더블클릭했을 때
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
        } // 일 폼
        private void ShowMyInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MyInfoForm frm = new MyInfoForm();
            frm.ShowDialog();
        } // 내 정보 폼
        private void ShowEmployeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeeToManagerForm frm = new EmployeeToManagerForm();
            frm.Show();
        } // 권한 부여 폼
        private void LoadEmpDgv()
        {
            // 값 읽어오기
            if ((GlobalUsage.MyInfo.Authority | 0b0001) == 0b0001) // 권한이 only 직원일 경우
            {
                List<TodoDTO> todos;
                TodoService tdService = new TodoService(); // Todo에서 가져오기
                todos = tdService.SelectAll().Where((elem) => elem.EmployeeID == GlobalUsage.MyInfo.EmployeeID).ToList();
                tdService.Dispose();

                // 데이터 세팅
                dgvTodo.ClearSelection();
                dgvTodo.DataSource = new BindingList<TodoDTO>(todos);
                MakeItemGroupByMID(todos);
            }
            else if ((GlobalUsage.MyInfo.Authority | 0b0010) == 0b0010) // 관리자 일 경우
            {
                List<MachineDTO> todos;
                MachineService mService = new MachineService(); // Machine에서 가져오기
                todos = mService.SelectAll();
                mService.Dispose();

                // 데이터 세팅
                dgvTodo.ClearSelection();
                dgvTodo.DataSource = new BindingList<MachineDTO>(todos);
                MakeItemGroupByMID(todos);
            }

        }// dgv읽고 item 생성
        private void MakeItemGroupByMID<T>(List<T> list) where T : Machine
        {
            var byEmpMachines = list.GroupBy((elem) => elem.MachineID, (baseMID) => new { Key = baseMID }).ToList();
            foreach (var item in byEmpMachines)
            {
                NewMenuItem(item.Key, flpBase); // child 둘 곳도 설정
            }
        }// 메뉴 생성하기
        private void BtnRun_Click(object sender, EventArgs e)
        {
            try
            {
                // MachineID 가져오기
                string machindID = dgvTodo.SelectedRows[0].Cells["MachineID"].Value.ToString();

                // 이미 생산중인 기계인지?
                MachineService service = new MachineService();
                bool isRunning = service.GetRunState(machindID);
                service.Dispose();
                if (isRunning) // 실행중인지?
                    throw new Exception(Properties.Resources.Error_MachineAlreadyRun_msg);
                //

                // 컨트롤 선택
                ToolStripMenuItem parentItem = machinesToolStripMenuItem.DropDownItems.Find(machindID, false)[0] as ToolStripMenuItem;
                parentItem.Checked = true; // childPanel 보이게 하기
                MachinePanel childPanel = flpBase.Controls.Find(machindID, false)[0] as MachinePanel;

                // 컨트롤 선택 확인
                if (parentItem == null || childPanel == null) // 컨트롤이 선택되지 않았을 때
                {
                    MessageBox.Show(Properties.Resources.Error_MachineNotValid_msg);
                    return;
                }

                // 실행
                TodoDTO todo = new TodoDTO()
                {
                    TodoCode = Convert.ToInt32(dgvTodo.SelectedRows[0].Cells["TodoCode"].Value),
                    ProductionID = dgvTodo.SelectedRows[0].Cells["ProductionID"].Value.ToString(),
                    MachineID = dgvTodo.SelectedRows[0].Cells["MachineID"].Value.ToString(),
                    EmployeeID = dgvTodo.SelectedRows[0].Cells["EmployeeID"].Value.ToString(),
                    ProductionPlanCode = Convert.ToInt32(dgvTodo.SelectedRows[0].Cells["ProductionPlanCode"].Value),
                    Amount = Convert.ToInt32(dgvTodo.SelectedRows[0].Cells["Amount"].Value)
                };
                childPanel.SetWork(todo);
                childPanel.RunMachine();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }// 실행 버튼
        private void SetDGVBackColor(string machineID, Color color)
        {
            foreach (DataGridViewRow item in dgvTodo.Rows)
            {
                if (item.Cells["MachineID"].Value.ToString() == machineID)
                    item.DefaultCellStyle.BackColor = color;
            }
        }
        private void MachineTimer_Tick(object sender, EventArgs e)
        {
            // LoadEmpDgv(); // 혹시 작업이 생기거나 없어 질 수 있으니 실시간으로 갱신함
            // TODO - 실시간 작업 갱신?
            // TODO - 중지시킬시 빈백그라운드로 하기

            // 실시간 기계 상태 확인
            //StringBuilder sb = new StringBuilder();
            //foreach (var item in flpBase.Controls)
            //{
            //    if (item is MachinePanel)
            //    {
            //        MachinePanel machine = item as MachinePanel;
            //        sb.Append(" OR MachindID = " + machine.MachineName);
            //    }
            //}
            //MachineService service = new MachineService();
            //List<MachineDTO> machines = service.SelectAll(sb.ToString());
            //service.Dispose();
            //foreach (var item in machines)
            //{
            //    MachinePanel machine = flpBase.Controls.Find(item.MachineID,false)[0] as MachinePanel;
            //    machine.SetMachineState(item.IsRunning);
            //}
        } // 타이머

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (var item in flpBase.Controls)
            {
                if (item is MachinePanel)
                {
                    MachinePanel machine = item as MachinePanel;
                    if (machine.MachineState == 1)
                        machine.StopMachine();
                }
            }
        } // 폼이 꺼질 때 기계 전체 중지
    }
}
