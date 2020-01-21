namespace FORTEST_03_CLIENT
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvProduction = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rboTotal = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.rdoByDateTime = new System.Windows.Forms.RadioButton();
            this.cmbByName = new System.Windows.Forms.ComboBox();
            this.rdoByProductName = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.lblseq = new System.Windows.Forms.Label();
            this.cmbProductName = new System.Windows.Forms.ComboBox();
            this.proddate = new System.Windows.Forms.DateTimePicker();
            this.runtime = new System.Windows.Forms.NumericUpDown();
            this.q = new System.Windows.Forms.NumericUpDown();
            this.badq = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduction)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.runtime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.q)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.badq)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(1040, 421);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 29;
            this.btnDelete.Text = "삭제";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(959, 421);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 28;
            this.btnUpdate.Text = "수정";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(878, 421);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 27;
            this.btnInsert.Text = "등록";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(404, 70);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 26;
            this.btnSearch.Text = "조회";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(633, 426);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 19;
            this.label3.Text = "생산량";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(497, 426);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 18;
            this.label4.Text = "가동시간";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(253, 426);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 17;
            this.label2.Text = "생산일자";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 426);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 16;
            this.label1.Text = "제품명";
            // 
            // dgvProduction
            // 
            this.dgvProduction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduction.Location = new System.Drawing.Point(12, 121);
            this.dgvProduction.Name = "dgvProduction";
            this.dgvProduction.RowTemplate.Height = 23;
            this.dgvProduction.Size = new System.Drawing.Size(1103, 293);
            this.dgvProduction.TabIndex = 15;
            this.dgvProduction.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduction_CellDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rboTotal);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dtpToDate);
            this.groupBox1.Controls.Add(this.dtpFromDate);
            this.groupBox1.Controls.Add(this.rdoByDateTime);
            this.groupBox1.Controls.Add(this.cmbByName);
            this.groupBox1.Controls.Add(this.rdoByProductName);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1103, 103);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            // 
            // rboTotal
            // 
            this.rboTotal.AutoSize = true;
            this.rboTotal.Location = new System.Drawing.Point(16, 20);
            this.rboTotal.Name = "rboTotal";
            this.rboTotal.Size = new System.Drawing.Size(47, 16);
            this.rboTotal.TabIndex = 27;
            this.rboTotal.Text = "전체";
            this.rboTotal.UseVisualStyleBackColor = true;
            this.rboTotal.CheckedChanged += new System.EventHandler(this.rboTotal_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(241, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 12);
            this.label5.TabIndex = 5;
            this.label5.Text = "~";
            // 
            // dtpToDate
            // 
            this.dtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpToDate.Location = new System.Drawing.Point(261, 70);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(121, 21);
            this.dtpToDate.TabIndex = 4;
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFromDate.Location = new System.Drawing.Point(114, 70);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(121, 21);
            this.dtpFromDate.TabIndex = 3;
            this.dtpFromDate.ValueChanged += new System.EventHandler(this.dtpFromDate_ValueChanged);
            // 
            // rdoByDateTime
            // 
            this.rdoByDateTime.AutoSize = true;
            this.rdoByDateTime.Location = new System.Drawing.Point(16, 74);
            this.rdoByDateTime.Name = "rdoByDateTime";
            this.rdoByDateTime.Size = new System.Drawing.Size(59, 16);
            this.rdoByDateTime.TabIndex = 2;
            this.rdoByDateTime.Text = "기간별";
            this.rdoByDateTime.UseVisualStyleBackColor = true;
            this.rdoByDateTime.CheckedChanged += new System.EventHandler(this.rdoByDateTime_CheckedChanged);
            // 
            // cmbByName
            // 
            this.cmbByName.FormattingEnabled = true;
            this.cmbByName.Location = new System.Drawing.Point(114, 46);
            this.cmbByName.Name = "cmbByName";
            this.cmbByName.Size = new System.Drawing.Size(121, 20);
            this.cmbByName.TabIndex = 1;
            // 
            // rdoByProductName
            // 
            this.rdoByProductName.AutoSize = true;
            this.rdoByProductName.Location = new System.Drawing.Point(16, 47);
            this.rdoByProductName.Name = "rdoByProductName";
            this.rdoByProductName.Size = new System.Drawing.Size(59, 16);
            this.rdoByProductName.TabIndex = 0;
            this.rdoByProductName.Text = "제품별";
            this.rdoByProductName.UseVisualStyleBackColor = true;
            this.rdoByProductName.CheckedChanged += new System.EventHandler(this.rdoByProductName_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 426);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 12);
            this.label6.TabIndex = 31;
            this.label6.Text = "Seq";
            // 
            // lblseq
            // 
            this.lblseq.AutoSize = true;
            this.lblseq.Location = new System.Drawing.Point(60, 426);
            this.lblseq.Name = "lblseq";
            this.lblseq.Size = new System.Drawing.Size(0, 12);
            this.lblseq.TabIndex = 32;
            // 
            // cmbProductName
            // 
            this.cmbProductName.FormattingEnabled = true;
            this.cmbProductName.Location = new System.Drawing.Point(147, 422);
            this.cmbProductName.Name = "cmbProductName";
            this.cmbProductName.Size = new System.Drawing.Size(100, 20);
            this.cmbProductName.TabIndex = 28;
            // 
            // proddate
            // 
            this.proddate.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.proddate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.proddate.Location = new System.Drawing.Point(312, 422);
            this.proddate.Name = "proddate";
            this.proddate.Size = new System.Drawing.Size(179, 21);
            this.proddate.TabIndex = 28;
            // 
            // runtime
            // 
            this.runtime.Location = new System.Drawing.Point(556, 422);
            this.runtime.Maximum = new decimal(new int[] {
            2147283647,
            0,
            0,
            0});
            this.runtime.Name = "runtime";
            this.runtime.Size = new System.Drawing.Size(71, 21);
            this.runtime.TabIndex = 33;
            // 
            // q
            // 
            this.q.Location = new System.Drawing.Point(680, 422);
            this.q.Maximum = new decimal(new int[] {
            2147283647,
            0,
            0,
            0});
            this.q.Name = "q";
            this.q.Size = new System.Drawing.Size(64, 21);
            this.q.TabIndex = 34;
            // 
            // badq
            // 
            this.badq.Location = new System.Drawing.Point(808, 422);
            this.badq.Maximum = new decimal(new int[] {
            2147283647,
            0,
            0,
            0});
            this.badq.Name = "badq";
            this.badq.Size = new System.Drawing.Size(64, 21);
            this.badq.TabIndex = 36;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(750, 426);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 35;
            this.label8.Text = "불량수량";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 450);
            this.Controls.Add(this.badq);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.q);
            this.Controls.Add(this.runtime);
            this.Controls.Add(this.proddate);
            this.Controls.Add(this.cmbProductName);
            this.Controls.Add(this.lblseq);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvProduction);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduction)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.runtime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.q)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.badq)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvProduction;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.RadioButton rdoByDateTime;
        private System.Windows.Forms.ComboBox cmbByName;
        private System.Windows.Forms.RadioButton rdoByProductName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblseq;
        private System.Windows.Forms.RadioButton rboTotal;
        private System.Windows.Forms.ComboBox cmbProductName;
        private System.Windows.Forms.DateTimePicker proddate;
        private System.Windows.Forms.NumericUpDown runtime;
        private System.Windows.Forms.NumericUpDown q;
        private System.Windows.Forms.NumericUpDown badq;
        private System.Windows.Forms.Label label8;
    }
}

