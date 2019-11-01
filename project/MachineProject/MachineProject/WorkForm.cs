using MachineProject.DTO;
using MachineProject.Services;
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
    // 예상되는 작업시간도 계산해서 table에 넣었으면함
    public partial class WorkForm : Form
    {
        public WorkForm()
        {
            InitializeComponent();
        }

        private void WorkForm_Load(object sender, EventArgs e)
        {
            //폰트 설정
            RecursiveForChangeControls rcontrols = new RecursiveForChangeControls();
            rcontrols.ChangeControls(this.Controls, GlobalUsage.ChangeFont);

            // dgv 칼럼넣는 클래스
            DataGridViewAddColumns.DataGridViewAddColumns addcol = new DataGridViewAddColumns.DataGridViewAddColumns();
            // dgv설정
            // 생산 계획
            addcol.AddNewColumnToDataGridView("번호", "ProductionPlanCode", dgvProductionPlans, typeof(int), 25);
            addcol.AddNewColumnToDataGridView("제품ID", "ProductionID", dgvProductionPlans, typeof(string), 100);
            addcol.AddNewColumnToDataGridView("갯수", "TotalAmount", dgvProductionPlans, typeof(int), 100, null, true, DataGridViewContentAlignment.MiddleLeft);
            GlobalUsage.SetDataGridView(dgvProductionPlans);
            // 생산 가능 제품
            addcol.AddNewColumnToDataGridView("기계ID", "MachineID", dgvProductionable, typeof(string), 60);
            addcol.AddNewColumnToDataGridView("제품ID", "ProductionID", dgvProductionable, typeof(string), 60);
            addcol.AddNewColumnToDataGridView("하루생산", "AmountPerDay", dgvProductionable, typeof(int), 100, null, true, DataGridViewContentAlignment.MiddleLeft);
            GlobalUsage.SetDataGridView(dgvProductionable);
            // TODO테이블
            addcol.AddNewColumnToDataGridView("코드", "TodoCode", dgvTodo, typeof(int), 25);
            addcol.AddNewColumnToDataGridView("기계ID", "MachineID", dgvTodo, typeof(string), 70);
            addcol.AddNewColumnToDataGridView("제품ID", "ProductionID", dgvTodo, typeof(string), 70);
            addcol.AddNewColumnToDataGridView("직원ID", "EmployeeID", dgvTodo, typeof(string), 70);
            addcol.AddNewColumnToDataGridView("갯수", "Amount", dgvTodo, typeof(int), 100, null, true, DataGridViewContentAlignment.MiddleLeft);
            GlobalUsage.SetDataGridView(dgvTodo);
            // 담당 작업
            addcol.AddNewColumnToDataGridView("코드", "TodoCode", dgvTodoListPerEmployee, typeof(int), 25);
            addcol.AddNewColumnToDataGridView("기계ID", "MachineID", dgvTodoListPerEmployee, typeof(string), 60);
            addcol.AddNewColumnToDataGridView("제품ID", "ProductionID", dgvTodoListPerEmployee, typeof(string), 60);
            addcol.AddNewColumnToDataGridView("완료", "Complete", dgvTodoListPerEmployee, typeof(char), 10);
            addcol.AddNewColumnToDataGridView("갯수", "Amount", dgvTodoListPerEmployee, typeof(int), 90, null, true, DataGridViewContentAlignment.MiddleLeft);
            addcol.AddNewColumnToDataGridView("완료날짜", "CompleteDate", dgvTodoListPerEmployee, typeof(DateTime), 50);
            addcol.AddNewColumnToDataGridView("직원ID", "EmployeeID", dgvTodoListPerEmployee, typeof(string), 60);
            GlobalUsage.SetDataGridView(dgvTodoListPerEmployee);
            // cmb 설정
            cmbMachines.ValueMember = "MachineID";
            cmbMachines.DisplayMember = "MachineID";
            cmbEmployees.DisplayMember = "IdAndName";
            cmbEmployees.ValueMember = "EmployeeID";

            // 전체 데이터 로드
            LoadDate();
            //
        }

        List<PListByMachineDTO> pllist;
        List<TodoDTO> tdlist;
        private void LoadDate()
        {
            //로드 때 갖고오지 못하게 하기
            cmbMachines.SelectedIndexChanged -= CmbMachines_SelectedIndexChanged;
            cmbEmployees.SelectedIndexChanged -= CmbEmployees_SelectedIndexChanged;

            // 직원 콤보 로드
            EmployeesService eService = new EmployeesService();
            BindingList <EmployeeDTO> ebindlist = new BindingList<EmployeeDTO>(eService.SelectAll().Where((elem) => (elem.Authority | 0b0001) == 0b0001).ToList());
            eService.Dispose();
            cmbEmployees.DataSource = ebindlist;

            // 기계 콤보 로드
            MachineService mService = new MachineService();
            BindingList<MachineDTO> mbindlist = new BindingList<MachineDTO>(mService.SelectAll());
            mService.Dispose();
            cmbMachines.DataSource = mbindlist;

            // 생산 계획 로드
            ProductionPlanService ppService = new ProductionPlanService();
            BindingList<ProductionPlanDTO> ppbindlist = new BindingList<ProductionPlanDTO>(ppService.SelectAll());
            ppService.Dispose();
            dgvProductionPlans.DataSource = ppbindlist;

            // 생산가능한 제품 로드 ( 기계 마다 )
            PListByMachineService plService = new PListByMachineService();
            pllist = plService.SelectAll();
            plService.Dispose();
            
            // 전체 Todo 갖고오기
            TodoService tdService = new TodoService();
            tdlist = tdService.SelectAll();
            tdService.Dispose();

            // 이벤트 재활성화
            cmbMachines.SelectedIndexChanged += CmbMachines_SelectedIndexChanged;
            cmbEmployees.SelectedIndexChanged += CmbEmployees_SelectedIndexChanged;

            // 갖고오기
            dgvProductionable.DataSource = new BindingList<PListByMachineDTO>(pllist.Where((elem) => elem.MachineID == cmbMachines.SelectedValue.ToString()).ToList());
            dgvTodoListPerEmployee.DataSource = new BindingList<TodoDTO>(tdlist.Where((elem)=> elem.EmployeeID == cmbEmployees.SelectedValue.ToString()).ToList());

        }

        private void CmbMachines_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvProductionable.DataSource = new BindingList<PListByMachineDTO>(pllist.Where((elem) => elem.MachineID == cmbMachines.SelectedValue.ToString()).ToList());
        }

        private void CmbEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvTodoListPerEmployee.DataSource = new BindingList<TodoDTO>(tdlist.Where((elem) => elem.EmployeeID == cmbEmployees.SelectedValue.ToString()).ToList());
        }
    }
}
