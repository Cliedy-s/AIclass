namespace _1023_OpenAPI_Address
{
    partial class AddrSearchForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvSearchData = new System.Windows.Forms.DataGridView();
            this.btnRoad = new System.Windows.Forms.Button();
            this.txtRoadAddr1 = new System.Windows.Forms.TextBox();
            this.txtRoadZipCode = new System.Windows.Forms.TextBox();
            this.txtRoadAddr2 = new System.Windows.Forms.TextBox();
            this.txtJibunAddr2 = new System.Windows.Forms.TextBox();
            this.txtJibunZipCode = new System.Windows.Forms.TextBox();
            this.txtJibunAddr1 = new System.Windows.Forms.TextBox();
            this.btnJibun = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchData)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(35, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "도로명(지번) 주소 검색";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtSearch.Location = new System.Drawing.Point(187, 19);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(206, 22);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.TxtSearch_TextChanged);
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtSearch_KeyPress);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSearch.Location = new System.Drawing.Point(399, 17);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "검색";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // dgvSearchData
            // 
            this.dgvSearchData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearchData.Location = new System.Drawing.Point(37, 53);
            this.dgvSearchData.Name = "dgvSearchData";
            this.dgvSearchData.RowTemplate.Height = 23;
            this.dgvSearchData.Size = new System.Drawing.Size(437, 243);
            this.dgvSearchData.TabIndex = 3;
            this.dgvSearchData.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvSearchData_CellDoubleClick);
            // 
            // btnRoad
            // 
            this.btnRoad.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnRoad.Location = new System.Drawing.Point(37, 312);
            this.btnRoad.Name = "btnRoad";
            this.btnRoad.Size = new System.Drawing.Size(75, 50);
            this.btnRoad.TabIndex = 4;
            this.btnRoad.Text = "도로명 선택";
            this.btnRoad.UseVisualStyleBackColor = true;
            this.btnRoad.Click += new System.EventHandler(this.BtnRoad_Click);
            // 
            // txtRoadAddr1
            // 
            this.txtRoadAddr1.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtRoadAddr1.Location = new System.Drawing.Point(118, 312);
            this.txtRoadAddr1.Name = "txtRoadAddr1";
            this.txtRoadAddr1.Size = new System.Drawing.Size(356, 22);
            this.txtRoadAddr1.TabIndex = 5;
            // 
            // txtRoadZipCode
            // 
            this.txtRoadZipCode.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtRoadZipCode.Location = new System.Drawing.Point(118, 339);
            this.txtRoadZipCode.Name = "txtRoadZipCode";
            this.txtRoadZipCode.Size = new System.Drawing.Size(100, 22);
            this.txtRoadZipCode.TabIndex = 6;
            // 
            // txtRoadAddr2
            // 
            this.txtRoadAddr2.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtRoadAddr2.Location = new System.Drawing.Point(224, 339);
            this.txtRoadAddr2.Name = "txtRoadAddr2";
            this.txtRoadAddr2.Size = new System.Drawing.Size(250, 22);
            this.txtRoadAddr2.TabIndex = 7;
            // 
            // txtJibunAddr2
            // 
            this.txtJibunAddr2.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtJibunAddr2.Location = new System.Drawing.Point(224, 407);
            this.txtJibunAddr2.Name = "txtJibunAddr2";
            this.txtJibunAddr2.Size = new System.Drawing.Size(250, 22);
            this.txtJibunAddr2.TabIndex = 11;
            // 
            // txtJibunZipCode
            // 
            this.txtJibunZipCode.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtJibunZipCode.Location = new System.Drawing.Point(118, 407);
            this.txtJibunZipCode.Name = "txtJibunZipCode";
            this.txtJibunZipCode.Size = new System.Drawing.Size(100, 22);
            this.txtJibunZipCode.TabIndex = 10;
            // 
            // txtJibunAddr1
            // 
            this.txtJibunAddr1.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtJibunAddr1.Location = new System.Drawing.Point(118, 380);
            this.txtJibunAddr1.Name = "txtJibunAddr1";
            this.txtJibunAddr1.Size = new System.Drawing.Size(356, 22);
            this.txtJibunAddr1.TabIndex = 9;
            // 
            // btnJibun
            // 
            this.btnJibun.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnJibun.Location = new System.Drawing.Point(37, 380);
            this.btnJibun.Name = "btnJibun";
            this.btnJibun.Size = new System.Drawing.Size(75, 50);
            this.btnJibun.TabIndex = 8;
            this.btnJibun.Text = "지번 주소 선택";
            this.btnJibun.UseVisualStyleBackColor = true;
            this.btnJibun.Click += new System.EventHandler(this.BtnJibun_Click);
            // 
            // AddrSearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 460);
            this.Controls.Add(this.txtJibunAddr2);
            this.Controls.Add(this.txtJibunZipCode);
            this.Controls.Add(this.txtJibunAddr1);
            this.Controls.Add(this.btnJibun);
            this.Controls.Add(this.txtRoadAddr2);
            this.Controls.Add(this.txtRoadZipCode);
            this.Controls.Add(this.txtRoadAddr1);
            this.Controls.Add(this.btnRoad);
            this.Controls.Add(this.dgvSearchData);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label1);
            this.Name = "AddrSearchForm";
            this.Text = "AddrSearchForm";
            this.Load += new System.EventHandler(this.AddrSearchForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvSearchData;
        private System.Windows.Forms.Button btnRoad;
        private System.Windows.Forms.TextBox txtRoadAddr1;
        private System.Windows.Forms.TextBox txtRoadZipCode;
        private System.Windows.Forms.TextBox txtRoadAddr2;
        private System.Windows.Forms.TextBox txtJibunAddr2;
        private System.Windows.Forms.TextBox txtJibunZipCode;
        private System.Windows.Forms.TextBox txtJibunAddr1;
        private System.Windows.Forms.Button btnJibun;
    }
}