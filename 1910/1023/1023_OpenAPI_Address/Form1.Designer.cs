namespace _1023_OpenAPI_Address
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
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvAddressShow = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.addrUserControl1 = new _1023_OpenAPI_Address.AddrUserControl();
            this.addrUserControl2 = new _1023_OpenAPI_Address.AddrUserControl();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddressShow)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("나눔고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtSearch.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.txtSearch.Location = new System.Drawing.Point(40, 40);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(601, 29);
            this.txtSearch.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSearch.Location = new System.Drawing.Point(663, 40);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 30);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "검색";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // dgvAddressShow
            // 
            this.dgvAddressShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAddressShow.Location = new System.Drawing.Point(40, 88);
            this.dgvAddressShow.Name = "dgvAddressShow";
            this.dgvAddressShow.RowTemplate.Height = 23;
            this.dgvAddressShow.Size = new System.Drawing.Size(698, 277);
            this.dgvAddressShow.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(663, 586);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "저장";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // addrUserControl1
            // 
            this.addrUserControl1.Location = new System.Drawing.Point(40, 386);
            this.addrUserControl1.Name = "addrUserControl1";
            this.addrUserControl1.Size = new System.Drawing.Size(489, 79);
            this.addrUserControl1.TabIndex = 6;
            // 
            // addrUserControl2
            // 
            this.addrUserControl2.Location = new System.Drawing.Point(40, 486);
            this.addrUserControl2.Name = "addrUserControl2";
            this.addrUserControl2.Size = new System.Drawing.Size(489, 79);
            this.addrUserControl2.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 621);
            this.Controls.Add(this.addrUserControl2);
            this.Controls.Add(this.addrUserControl1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvAddressShow);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddressShow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvAddressShow;
        private System.Windows.Forms.Button button1;
        private AddrUserControl addrUserControl1;
        private AddrUserControl addrUserControl2;
    }
}

