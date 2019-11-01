namespace MachineProject
{
    partial class WorkForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbMachines = new System.Windows.Forms.ComboBox();
            this.btnAddTodo = new System.Windows.Forms.Button();
            this.cmbEmployees = new System.Windows.Forms.ComboBox();
            this.btnRemoveTodo = new System.Windows.Forms.Button();
            this.dgvProductionable = new System.Windows.Forms.DataGridView();
            this.dgvTodoListPerEmployee = new System.Windows.Forms.DataGridView();
            this.dgvProductionPlans = new System.Windows.Forms.DataGridView();
            this.dgvTodo = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductionable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTodoListPerEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductionPlans)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTodo)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbMachines
            // 
            this.cmbMachines.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbMachines.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cmbMachines.FormattingEnabled = true;
            this.cmbMachines.Location = new System.Drawing.Point(633, 12);
            this.cmbMachines.Name = "cmbMachines";
            this.cmbMachines.Size = new System.Drawing.Size(216, 25);
            this.cmbMachines.TabIndex = 2;
            this.cmbMachines.SelectedIndexChanged += new System.EventHandler(this.CmbMachines_SelectedIndexChanged);
            // 
            // btnAddTodo
            // 
            this.btnAddTodo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddTodo.Location = new System.Drawing.Point(314, 174);
            this.btnAddTodo.Name = "btnAddTodo";
            this.btnAddTodo.Size = new System.Drawing.Size(92, 23);
            this.btnAddTodo.TabIndex = 5;
            this.btnAddTodo.Text = "◁ 작업할당";
            this.btnAddTodo.UseVisualStyleBackColor = true;
            // 
            // cmbEmployees
            // 
            this.cmbEmployees.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbEmployees.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cmbEmployees.FormattingEnabled = true;
            this.cmbEmployees.Location = new System.Drawing.Point(858, 12);
            this.cmbEmployees.Name = "cmbEmployees";
            this.cmbEmployees.Size = new System.Drawing.Size(216, 25);
            this.cmbEmployees.TabIndex = 7;
            this.cmbEmployees.SelectedIndexChanged += new System.EventHandler(this.CmbEmployees_SelectedIndexChanged);
            // 
            // btnRemoveTodo
            // 
            this.btnRemoveTodo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRemoveTodo.Location = new System.Drawing.Point(314, 203);
            this.btnRemoveTodo.Name = "btnRemoveTodo";
            this.btnRemoveTodo.Size = new System.Drawing.Size(92, 23);
            this.btnRemoveTodo.TabIndex = 9;
            this.btnRemoveTodo.Text = "▷ 작업취소";
            this.btnRemoveTodo.UseVisualStyleBackColor = true;
            // 
            // dgvProductionable
            // 
            this.dgvProductionable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dgvProductionable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductionable.Location = new System.Drawing.Point(633, 76);
            this.dgvProductionable.Name = "dgvProductionable";
            this.dgvProductionable.RowTemplate.Height = 23;
            this.dgvProductionable.Size = new System.Drawing.Size(216, 312);
            this.dgvProductionable.TabIndex = 11;
            // 
            // dgvTodoListPerEmployee
            // 
            this.dgvTodoListPerEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dgvTodoListPerEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTodoListPerEmployee.Location = new System.Drawing.Point(858, 76);
            this.dgvTodoListPerEmployee.Name = "dgvTodoListPerEmployee";
            this.dgvTodoListPerEmployee.RowTemplate.Height = 23;
            this.dgvTodoListPerEmployee.Size = new System.Drawing.Size(216, 312);
            this.dgvTodoListPerEmployee.TabIndex = 12;
            // 
            // dgvProductionPlans
            // 
            this.dgvProductionPlans.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dgvProductionPlans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductionPlans.Location = new System.Drawing.Point(412, 43);
            this.dgvProductionPlans.Name = "dgvProductionPlans";
            this.dgvProductionPlans.RowTemplate.Height = 23;
            this.dgvProductionPlans.Size = new System.Drawing.Size(215, 316);
            this.dgvProductionPlans.TabIndex = 13;
            // 
            // dgvTodo
            // 
            this.dgvTodo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dgvTodo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTodo.Location = new System.Drawing.Point(12, 43);
            this.dgvTodo.Name = "dgvTodo";
            this.dgvTodo.RowTemplate.Height = 23;
            this.dgvTodo.Size = new System.Drawing.Size(296, 345);
            this.dgvTodo.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(688, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 19);
            this.label1.TabIndex = 15;
            this.label1.Text = "생산 가능 제품";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(930, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 19);
            this.label2.TabIndex = 16;
            this.label2.Text = "담당 작업";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(483, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 19);
            this.label3.TabIndex = 17;
            this.label3.Text = "생산 계획";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(124, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 19);
            this.label4.TabIndex = 18;
            this.label4.Text = "TODO";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(412, 366);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(152, 21);
            this.textBox1.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(570, 369);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 12);
            this.label5.TabIndex = 20;
            this.label5.Text = "개 할당";
            // 
            // WorkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 400);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvTodo);
            this.Controls.Add(this.dgvProductionPlans);
            this.Controls.Add(this.dgvTodoListPerEmployee);
            this.Controls.Add(this.dgvProductionable);
            this.Controls.Add(this.btnRemoveTodo);
            this.Controls.Add(this.cmbEmployees);
            this.Controls.Add(this.btnAddTodo);
            this.Controls.Add(this.cmbMachines);
            this.Name = "WorkForm";
            this.Text = " WorkForm";
            this.Load += new System.EventHandler(this.WorkForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductionable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTodoListPerEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductionPlans)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTodo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbMachines;
        private System.Windows.Forms.Button btnAddTodo;
        private System.Windows.Forms.ComboBox cmbEmployees;
        private System.Windows.Forms.Button btnRemoveTodo;
        private System.Windows.Forms.DataGridView dgvProductionable;
        private System.Windows.Forms.DataGridView dgvTodoListPerEmployee;
        private System.Windows.Forms.DataGridView dgvProductionPlans;
        private System.Windows.Forms.DataGridView dgvTodo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
    }
}