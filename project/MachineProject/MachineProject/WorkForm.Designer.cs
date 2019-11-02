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
            this.txtAmount = new System.Windows.Forms.TextBox();
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
            this.cmbMachines.Location = new System.Drawing.Point(723, 15);
            this.cmbMachines.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbMachines.Name = "cmbMachines";
            this.cmbMachines.Size = new System.Drawing.Size(246, 29);
            this.cmbMachines.TabIndex = 2;
            this.cmbMachines.SelectedIndexChanged += new System.EventHandler(this.CmbMachines_SelectedIndexChanged);
            // 
            // btnAddTodo
            // 
            this.btnAddTodo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddTodo.Location = new System.Drawing.Point(359, 218);
            this.btnAddTodo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddTodo.Name = "btnAddTodo";
            this.btnAddTodo.Size = new System.Drawing.Size(105, 29);
            this.btnAddTodo.TabIndex = 5;
            this.btnAddTodo.Text = "◁ 작업할당";
            this.btnAddTodo.UseVisualStyleBackColor = true;
            this.btnAddTodo.Click += new System.EventHandler(this.BtnAddTodo_Click);
            // 
            // cmbEmployees
            // 
            this.cmbEmployees.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbEmployees.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cmbEmployees.FormattingEnabled = true;
            this.cmbEmployees.Location = new System.Drawing.Point(981, 15);
            this.cmbEmployees.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbEmployees.Name = "cmbEmployees";
            this.cmbEmployees.Size = new System.Drawing.Size(246, 29);
            this.cmbEmployees.TabIndex = 7;
            this.cmbEmployees.SelectedIndexChanged += new System.EventHandler(this.CmbEmployees_SelectedIndexChanged);
            // 
            // btnRemoveTodo
            // 
            this.btnRemoveTodo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRemoveTodo.Location = new System.Drawing.Point(359, 254);
            this.btnRemoveTodo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRemoveTodo.Name = "btnRemoveTodo";
            this.btnRemoveTodo.Size = new System.Drawing.Size(105, 29);
            this.btnRemoveTodo.TabIndex = 9;
            this.btnRemoveTodo.Text = "▷ 작업취소";
            this.btnRemoveTodo.UseVisualStyleBackColor = true;
            this.btnRemoveTodo.Click += new System.EventHandler(this.BtnRemoveTodo_Click);
            // 
            // dgvProductionable
            // 
            this.dgvProductionable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dgvProductionable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductionable.Location = new System.Drawing.Point(723, 95);
            this.dgvProductionable.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvProductionable.Name = "dgvProductionable";
            this.dgvProductionable.RowHeadersWidth = 51;
            this.dgvProductionable.RowTemplate.Height = 23;
            this.dgvProductionable.Size = new System.Drawing.Size(247, 390);
            this.dgvProductionable.TabIndex = 11;
            // 
            // dgvTodoListPerEmployee
            // 
            this.dgvTodoListPerEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dgvTodoListPerEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTodoListPerEmployee.Location = new System.Drawing.Point(981, 95);
            this.dgvTodoListPerEmployee.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvTodoListPerEmployee.Name = "dgvTodoListPerEmployee";
            this.dgvTodoListPerEmployee.RowHeadersWidth = 51;
            this.dgvTodoListPerEmployee.RowTemplate.Height = 23;
            this.dgvTodoListPerEmployee.Size = new System.Drawing.Size(247, 390);
            this.dgvTodoListPerEmployee.TabIndex = 12;
            // 
            // dgvProductionPlans
            // 
            this.dgvProductionPlans.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dgvProductionPlans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductionPlans.Location = new System.Drawing.Point(471, 54);
            this.dgvProductionPlans.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvProductionPlans.Name = "dgvProductionPlans";
            this.dgvProductionPlans.RowHeadersWidth = 51;
            this.dgvProductionPlans.RowTemplate.Height = 23;
            this.dgvProductionPlans.Size = new System.Drawing.Size(246, 395);
            this.dgvProductionPlans.TabIndex = 13;
            // 
            // dgvTodo
            // 
            this.dgvTodo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dgvTodo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTodo.Location = new System.Drawing.Point(14, 54);
            this.dgvTodo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvTodo.Name = "dgvTodo";
            this.dgvTodo.RowHeadersWidth = 51;
            this.dgvTodo.RowTemplate.Height = 23;
            this.dgvTodo.Size = new System.Drawing.Size(338, 431);
            this.dgvTodo.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(786, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 23);
            this.label1.TabIndex = 15;
            this.label1.Text = "생산 가능 제품";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(1063, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 23);
            this.label2.TabIndex = 16;
            this.label2.Text = "담당 작업";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(552, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 23);
            this.label3.TabIndex = 17;
            this.label3.Text = "생산 계획";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(142, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 23);
            this.label4.TabIndex = 18;
            this.label4.Text = "TODO";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(471, 458);
            this.txtAmount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(173, 25);
            this.txtAmount.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(651, 461);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 15);
            this.label5.TabIndex = 20;
            this.label5.Text = "개 할당";
            // 
            // WorkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1241, 500);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtAmount);
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
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label5;
    }
}