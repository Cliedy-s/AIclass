﻿namespace IceCreamManager
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
        this.txtSearch = new System.Windows.Forms.TextBox();
        this.btnSearch = new System.Windows.Forms.Button();
        this.dgvSearchData = new System.Windows.Forms.DataGridView();
        this.btnRoad = new System.Windows.Forms.Button();
        this.txtRoadAddr1 = new System.Windows.Forms.TextBox();
        this.txtRoadZipCode = new System.Windows.Forms.TextBox();
        this.txtRoadAddr2 = new System.Windows.Forms.TextBox();
        this.label4 = new System.Windows.Forms.Label();
        ((System.ComponentModel.ISupportInitialize)(this.dgvSearchData)).BeginInit();
        this.SuspendLayout();
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
        this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
        this.btnSearch.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
        this.btnSearch.Location = new System.Drawing.Point(399, 17);
        this.btnSearch.Name = "btnSearch";
        this.btnSearch.Size = new System.Drawing.Size(75, 23);
        this.btnSearch.TabIndex = 2;
        this.btnSearch.Text = "검색";
        this.btnSearch.UseVisualStyleBackColor = false;
        this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
        // 
        // dgvSearchData
        // 
        this.dgvSearchData.BackgroundColor = System.Drawing.Color.White;
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
        this.btnRoad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
        this.btnRoad.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
        this.btnRoad.Location = new System.Drawing.Point(400, 315);
        this.btnRoad.Name = "btnRoad";
        this.btnRoad.Size = new System.Drawing.Size(75, 50);
        this.btnRoad.TabIndex = 4;
        this.btnRoad.Text = "확인";
        this.btnRoad.UseVisualStyleBackColor = false;
        this.btnRoad.Click += new System.EventHandler(this.BtnRoad_Click);
        // 
        // txtRoadAddr1
        // 
        this.txtRoadAddr1.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
        this.txtRoadAddr1.Location = new System.Drawing.Point(38, 316);
        this.txtRoadAddr1.Name = "txtRoadAddr1";
        this.txtRoadAddr1.Size = new System.Drawing.Size(356, 22);
        this.txtRoadAddr1.TabIndex = 5;
        // 
        // txtRoadZipCode
        // 
        this.txtRoadZipCode.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
        this.txtRoadZipCode.Location = new System.Drawing.Point(38, 343);
        this.txtRoadZipCode.Name = "txtRoadZipCode";
        this.txtRoadZipCode.Size = new System.Drawing.Size(100, 22);
        this.txtRoadZipCode.TabIndex = 6;
        // 
        // txtRoadAddr2
        // 
        this.txtRoadAddr2.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
        this.txtRoadAddr2.Location = new System.Drawing.Point(144, 343);
        this.txtRoadAddr2.Name = "txtRoadAddr2";
        this.txtRoadAddr2.Size = new System.Drawing.Size(250, 22);
        this.txtRoadAddr2.TabIndex = 7;
        // 
        // label4
        // 
        this.label4.AutoSize = true;
        this.label4.Font = new System.Drawing.Font("맑은 고딕", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
        this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
        this.label4.Location = new System.Drawing.Point(35, 22);
        this.label4.Name = "label4";
        this.label4.Size = new System.Drawing.Size(131, 15);
        this.label4.TabIndex = 87;
        this.label4.Text = "도로명(지번) 주소 검색";
        // 
        // AddressSearchForm
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
        this.ClientSize = new System.Drawing.Size(505, 388);
        this.Controls.Add(this.label4);
        this.Controls.Add(this.txtRoadAddr2);
        this.Controls.Add(this.txtRoadZipCode);
        this.Controls.Add(this.txtRoadAddr1);
        this.Controls.Add(this.btnRoad);
        this.Controls.Add(this.dgvSearchData);
        this.Controls.Add(this.btnSearch);
        this.Controls.Add(this.txtSearch);
        this.Name = "AddressSearchForm";
        this.Text = "AddrSearchForm";
        this.Load += new System.EventHandler(this.AddrSearchForm_Load);
        ((System.ComponentModel.ISupportInitialize)(this.dgvSearchData)).EndInit();
        this.ResumeLayout(false);
        this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.TextBox txtSearch;
    private System.Windows.Forms.Button btnSearch;
    private System.Windows.Forms.DataGridView dgvSearchData;
    private System.Windows.Forms.Button btnRoad;
    private System.Windows.Forms.TextBox txtRoadAddr1;
    private System.Windows.Forms.TextBox txtRoadZipCode;
    private System.Windows.Forms.TextBox txtRoadAddr2;
    private System.Windows.Forms.Label label4;
}
}