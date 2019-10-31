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
        DataSet ds;
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
            // TODO
            addcol.AddNewColumnToDataGridView("코드", "TodoCode", dgvTodo, typeof(int), 25);
            addcol.AddNewColumnToDataGridView("기계ID", "MachineID", dgvTodo, typeof(string), 70);
            addcol.AddNewColumnToDataGridView("제품ID", "ProductionID", dgvTodo, typeof(string), 70);
            addcol.AddNewColumnToDataGridView("직원ID", "EmployeeID", dgvTodo, typeof(string), 70);
            addcol.AddNewColumnToDataGridView("갯수", "TotalAmount", dgvTodo, typeof(int), 100, null, true, DataGridViewContentAlignment.MiddleLeft);
            GlobalUsage.SetDataGridView(dgvTodo);
            // 담당 작업
            addcol.AddNewColumnToDataGridView("코드", "TodoCode", dgvTodoListPerEmployee, typeof(int), 25);
            addcol.AddNewColumnToDataGridView("기계ID", "MachineID", dgvTodoListPerEmployee, typeof(string), 60);
            addcol.AddNewColumnToDataGridView("제품ID", "ProductionID", dgvTodoListPerEmployee, typeof(string), 60);
            addcol.AddNewColumnToDataGridView("갯수", "TotalAmount", dgvTodoListPerEmployee, typeof(int), 100, null, true, DataGridViewContentAlignment.MiddleLeft);
            addcol.AddNewColumnToDataGridView("직원ID", "EmployeeID", dgvTodoListPerEmployee, typeof(string), 60);
            GlobalUsage.SetDataGridView(dgvTodoListPerEmployee);
            // cmb 설정

            cmbEmployees.ValueMember = "EmployeeID";
            cmbEmployees.DisplayMember = "idAndName";
            cmbMachines.ValueMember = "MachineID";
            cmbMachines.DisplayMember = "MachineID";

            // 전체 데이터 로드
            LoadDate();
            //
        }

        private void LoadDate()
        {
            ds = new DataSet();

            // 직원 콤보 로드
            EmployeesService eService = new EmployeesService();
            ds.Tables.Add(eService.SelectAll());
            eService.Dispose();
            DataView dv00 = new DataView(ds.Tables["EMPLOYEES"]);
            dv00.RowFilter = string.Format("Authority = 1"); // 관리자 제외 콤보 로드
            cmbEmployees.DataSource = dv00;

            // 기계 콤보 로드
            MachineService mService = new MachineService();
            ds.Tables.Add(mService.SelectAll());
            mService.Dispose();
            cmbMachines.DataSource = ds.Tables["MACHINE"];

            // 생산 계획 로드
            ProductionPlanService ppService = new ProductionPlanService();
            ds.Tables.Add(ppService.SelectAll());
            ppService.Dispose();
            dgvProductionPlans.DataSource = ds.Tables["PRODUCTIONPLAN"];

            // 생산가능한 제품 로드 ( 기계 마다 =>  )
            PListByMachineService plService = new PListByMachineService();
            ds.Tables.Add(plService.SelectAll());
            plService.Dispose();
            DataView dv01 = new DataView(ds.Tables["PLISTBYMACHINE"]);
            dv01.RowFilter = string.Format("MachineID = {0}", cmbMachines.SelectedValue);
            dgvProductionable.DataSource = dv01;
            //dgvProductionable.DataSource = new DataView(ds.Tables["PLISTBYMACHINE"]);
            
            // 전체 Todo 갖고오기
            TodoService tdService = new TodoService();
            ds.Tables.Add(tdService.SelectAll());
            tdService.Dispose();
            DataView dv02 = new DataView(ds.Tables["TODO"]);
            dv02.RowFilter = string.Format("EmployeeID = {0}", cmbEmployees.SelectedValue);
            dgvTodoListPerEmployee.DataSource = dv02;
            //dgvTodo.DataSource = ds.Tables["TODO"];

            // 직원 Todo 갖고오기
            dgvTodoListPerEmployee.DataSource = new DataView(ds.Tables["TODO"]);
            //
        }

        private void CmbMachines_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataView dv = new DataView(ds.Tables["PLISTBYMACHINE"]);
            dv.RowFilter = string.Format("MachineID = {0}", cmbMachines.SelectedValue);
            dgvProductionable.DataSource = dv;
        }

        private void CmbEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataView dv = new DataView(ds.Tables["TODO"]);
            dv.RowFilter = string.Format("EmployeeID = {0}", cmbEmployees.SelectedValue);
            dgvTodoListPerEmployee.DataSource = dv;
        }
    }
}
