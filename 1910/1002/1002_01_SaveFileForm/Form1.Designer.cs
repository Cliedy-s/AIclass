namespace _1002_01_SaveFileForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCencel = new System.Windows.Forms.Button();
            this.listView = new System.Windows.Forms.ListBox();
            this.btnFileSave = new System.Windows.Forms.Button();
            this.dtpWorkDate = new System.Windows.Forms.DateTimePicker();
            this.panWorkInfos = new System.Windows.Forms.Panel();
            this.nudWorkQty = new System.Windows.Forms.NumericUpDown();
            this.cmbWorkMachine = new System.Windows.Forms.ComboBox();
            this.cmbWorker = new System.Windows.Forms.ComboBox();
            this.cmbWorkProduct = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panWorkInfos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudWorkQty)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "작업일자";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(320, 342);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "저장";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // btnCencel
            // 
            this.btnCencel.Location = new System.Drawing.Point(413, 342);
            this.btnCencel.Name = "btnCencel";
            this.btnCencel.Size = new System.Drawing.Size(75, 23);
            this.btnCencel.TabIndex = 7;
            this.btnCencel.Text = "취소";
            this.btnCencel.UseVisualStyleBackColor = true;
            this.btnCencel.Click += new System.EventHandler(this.BtnCencel_Click);
            // 
            // listView
            // 
            this.listView.FormattingEnabled = true;
            this.listView.ItemHeight = 12;
            this.listView.Location = new System.Drawing.Point(34, 102);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(221, 268);
            this.listView.TabIndex = 12;
            this.listView.DoubleClick += new System.EventHandler(this.ListView_DoubleClick);
            // 
            // btnFileSave
            // 
            this.btnFileSave.Location = new System.Drawing.Point(405, 54);
            this.btnFileSave.Name = "btnFileSave";
            this.btnFileSave.Size = new System.Drawing.Size(75, 23);
            this.btnFileSave.TabIndex = 13;
            this.btnFileSave.Text = "파일저장";
            this.btnFileSave.UseVisualStyleBackColor = true;
            this.btnFileSave.Click += new System.EventHandler(this.BtnFileSave_Click);
            // 
            // dtpWorkDate
            // 
            this.dtpWorkDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpWorkDate.Location = new System.Drawing.Point(34, 53);
            this.dtpWorkDate.Name = "dtpWorkDate";
            this.dtpWorkDate.Size = new System.Drawing.Size(83, 21);
            this.dtpWorkDate.TabIndex = 18;
            this.dtpWorkDate.ValueChanged += new System.EventHandler(this.DtpWorkDate_ValueChanged);
            // 
            // panWorkInfos
            // 
            this.panWorkInfos.Controls.Add(this.nudWorkQty);
            this.panWorkInfos.Controls.Add(this.cmbWorkMachine);
            this.panWorkInfos.Controls.Add(this.cmbWorker);
            this.panWorkInfos.Controls.Add(this.cmbWorkProduct);
            this.panWorkInfos.Controls.Add(this.label5);
            this.panWorkInfos.Controls.Add(this.label6);
            this.panWorkInfos.Controls.Add(this.label4);
            this.panWorkInfos.Controls.Add(this.label3);
            this.panWorkInfos.Location = new System.Drawing.Point(284, 102);
            this.panWorkInfos.Name = "panWorkInfos";
            this.panWorkInfos.Size = new System.Drawing.Size(224, 205);
            this.panWorkInfos.TabIndex = 19;
            // 
            // nudWorkQty
            // 
            this.nudWorkQty.Location = new System.Drawing.Point(89, 161);
            this.nudWorkQty.Maximum = new decimal(new int[] {
            2147383647,
            0,
            0,
            0});
            this.nudWorkQty.Name = "nudWorkQty";
            this.nudWorkQty.Size = new System.Drawing.Size(120, 21);
            this.nudWorkQty.TabIndex = 25;
            // 
            // cmbWorkMachine
            // 
            this.cmbWorkMachine.FormattingEnabled = true;
            this.cmbWorkMachine.Location = new System.Drawing.Point(89, 68);
            this.cmbWorkMachine.Name = "cmbWorkMachine";
            this.cmbWorkMachine.Size = new System.Drawing.Size(121, 20);
            this.cmbWorkMachine.TabIndex = 24;
            // 
            // cmbWorker
            // 
            this.cmbWorker.FormattingEnabled = true;
            this.cmbWorker.Location = new System.Drawing.Point(89, 23);
            this.cmbWorker.Name = "cmbWorker";
            this.cmbWorker.Size = new System.Drawing.Size(121, 20);
            this.cmbWorker.TabIndex = 23;
            // 
            // cmbWorkProduct
            // 
            this.cmbWorkProduct.FormattingEnabled = true;
            this.cmbWorkProduct.Location = new System.Drawing.Point(89, 115);
            this.cmbWorkProduct.Name = "cmbWorkProduct";
            this.cmbWorkProduct.Size = new System.Drawing.Size(121, 20);
            this.cmbWorkProduct.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 21;
            this.label5.Text = "작업수량";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 20;
            this.label6.Text = "제품명";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 19;
            this.label4.Text = "작업기계";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 18;
            this.label3.Text = "작업자";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 397);
            this.Controls.Add(this.dtpWorkDate);
            this.Controls.Add(this.btnFileSave);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.btnCencel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panWorkInfos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panWorkInfos.ResumeLayout(false);
            this.panWorkInfos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudWorkQty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCencel;
        private System.Windows.Forms.ListBox listView;
        private System.Windows.Forms.Button btnFileSave;
        private System.Windows.Forms.DateTimePicker dtpWorkDate;
        private System.Windows.Forms.Panel panWorkInfos;
        private System.Windows.Forms.NumericUpDown nudWorkQty;
        private System.Windows.Forms.ComboBox cmbWorkMachine;
        private System.Windows.Forms.ComboBox cmbWorker;
        private System.Windows.Forms.ComboBox cmbWorkProduct;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}

