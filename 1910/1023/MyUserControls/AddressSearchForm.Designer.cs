namespace MyUserControls
{
    partial class AddressSearchForm
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
            this.txtJibunAddr2 = new System.Windows.Forms.TextBox();
            this.txtJibunZipCode = new System.Windows.Forms.TextBox();
            this.txtJibunAddr1 = new System.Windows.Forms.TextBox();
            this.btnJibun = new System.Windows.Forms.Button();
            this.txtRoadAddr2 = new System.Windows.Forms.TextBox();
            this.txtRoadZipCode = new System.Windows.Forms.TextBox();
            this.txtRoadAddr1 = new System.Windows.Forms.TextBox();
            this.btnRoad = new System.Windows.Forms.Button();
            this.dgvSearchData = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchData)).BeginInit();
            this.SuspendLayout();
            // 
            // txtJibunAddr2
            // 
            this.txtJibunAddr2.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtJibunAddr2.Location = new System.Drawing.Point(210, 404);
            this.txtJibunAddr2.Name = "txtJibunAddr2";
            this.txtJibunAddr2.Size = new System.Drawing.Size(250, 22);
            this.txtJibunAddr2.TabIndex = 23;
            // 
            // txtJibunZipCode
            // 
            this.txtJibunZipCode.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtJibunZipCode.Location = new System.Drawing.Point(104, 404);
            this.txtJibunZipCode.Name = "txtJibunZipCode";
            this.txtJibunZipCode.Size = new System.Drawing.Size(100, 22);
            this.txtJibunZipCode.TabIndex = 22;
            // 
            // txtJibunAddr1
            // 
            this.txtJibunAddr1.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtJibunAddr1.Location = new System.Drawing.Point(104, 377);
            this.txtJibunAddr1.Name = "txtJibunAddr1";
            this.txtJibunAddr1.Size = new System.Drawing.Size(356, 22);
            this.txtJibunAddr1.TabIndex = 21;
            // 
            // btnJibun
            // 
            this.btnJibun.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnJibun.Location = new System.Drawing.Point(23, 377);
            this.btnJibun.Name = "btnJibun";
            this.btnJibun.Size = new System.Drawing.Size(75, 50);
            this.btnJibun.TabIndex = 20;
            this.btnJibun.Text = "지번 주소 선택";
            this.btnJibun.UseVisualStyleBackColor = true;
            // 
            // txtRoadAddr2
            // 
            this.txtRoadAddr2.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtRoadAddr2.Location = new System.Drawing.Point(210, 336);
            this.txtRoadAddr2.Name = "txtRoadAddr2";
            this.txtRoadAddr2.Size = new System.Drawing.Size(250, 22);
            this.txtRoadAddr2.TabIndex = 19;
            // 
            // txtRoadZipCode
            // 
            this.txtRoadZipCode.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtRoadZipCode.Location = new System.Drawing.Point(104, 336);
            this.txtRoadZipCode.Name = "txtRoadZipCode";
            this.txtRoadZipCode.Size = new System.Drawing.Size(100, 22);
            this.txtRoadZipCode.TabIndex = 18;
            // 
            // txtRoadAddr1
            // 
            this.txtRoadAddr1.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtRoadAddr1.Location = new System.Drawing.Point(104, 309);
            this.txtRoadAddr1.Name = "txtRoadAddr1";
            this.txtRoadAddr1.Size = new System.Drawing.Size(356, 22);
            this.txtRoadAddr1.TabIndex = 17;
            // 
            // btnRoad
            // 
            this.btnRoad.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnRoad.Location = new System.Drawing.Point(23, 309);
            this.btnRoad.Name = "btnRoad";
            this.btnRoad.Size = new System.Drawing.Size(75, 50);
            this.btnRoad.TabIndex = 16;
            this.btnRoad.Text = "도로명 선택";
            this.btnRoad.UseVisualStyleBackColor = true;
            // 
            // dgvSearchData
            // 
            this.dgvSearchData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearchData.Location = new System.Drawing.Point(23, 50);
            this.dgvSearchData.Name = "dgvSearchData";
            this.dgvSearchData.RowTemplate.Height = 23;
            this.dgvSearchData.Size = new System.Drawing.Size(437, 243);
            this.dgvSearchData.TabIndex = 15;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSearch.Location = new System.Drawing.Point(385, 14);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 14;
            this.btnSearch.Text = "검색";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtSearch.Location = new System.Drawing.Point(173, 16);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(206, 22);
            this.txtSearch.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(21, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "도로명(지번) 주소 검색";
            // 
            // AddressSearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 450);
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
            this.Name = "AddressSearchForm";
            this.Text = "AddressSearchForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtJibunAddr2;
        private System.Windows.Forms.TextBox txtJibunZipCode;
        private System.Windows.Forms.TextBox txtJibunAddr1;
        private System.Windows.Forms.Button btnJibun;
        private System.Windows.Forms.TextBox txtRoadAddr2;
        private System.Windows.Forms.TextBox txtRoadZipCode;
        private System.Windows.Forms.TextBox txtRoadAddr1;
        private System.Windows.Forms.Button btnRoad;
        private System.Windows.Forms.DataGridView dgvSearchData;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;
    }
}