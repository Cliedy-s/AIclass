﻿namespace IceCreamManager
{
    partial class UserLogin
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
            this.label3 = new System.Windows.Forms.Label();
            this.btnlogin = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSigin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.linkidpwd = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.placeHolderTextBox2 = new IceCreamManager.PlaceHolderTextBox();
            this.placeHolderTextBox1 = new IceCreamManager.PlaceHolderTextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label3.Location = new System.Drawing.Point(483, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 50);
            this.label3.TabIndex = 14;
            this.label3.Text = "로그인";
            // 
            // btnlogin
            // 
            this.btnlogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnlogin.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnlogin.Location = new System.Drawing.Point(124, 179);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(289, 62);
            this.btnlogin.TabIndex = 3;
            this.btnlogin.Text = "로그인";
            this.btnlogin.UseVisualStyleBackColor = false;
            this.btnlogin.Click += new System.EventHandler(this.Btnlogin_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label2.Location = new System.Drawing.Point(27, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "비밀번호";
            // 
            // btnSigin
            // 
            this.btnSigin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnSigin.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSigin.Location = new System.Drawing.Point(124, 267);
            this.btnSigin.Name = "btnSigin";
            this.btnSigin.Size = new System.Drawing.Size(289, 62);
            this.btnSigin.TabIndex = 4;
            this.btnSigin.Text = "회원가입";
            this.btnSigin.UseVisualStyleBackColor = false;
            this.btnSigin.Click += new System.EventHandler(this.BtnSigin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(27, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "아이디 ";
            // 
            // linkidpwd
            // 
            this.linkidpwd.AutoSize = true;
            this.linkidpwd.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.linkidpwd.Location = new System.Drawing.Point(203, 363);
            this.linkidpwd.Name = "linkidpwd";
            this.linkidpwd.Size = new System.Drawing.Size(123, 12);
            this.linkidpwd.TabIndex = 5;
            this.linkidpwd.TabStop = true;
            this.linkidpwd.Text = "아이디/비밀번호 찾기";
            this.linkidpwd.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Linkidpwd_LinkClicked);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.placeHolderTextBox2);
            this.panel1.Controls.Add(this.placeHolderTextBox1);
            this.panel1.Controls.Add(this.linkidpwd);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnSigin);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnlogin);
            this.panel1.Location = new System.Drawing.Point(306, 184);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(469, 413);
            this.panel1.TabIndex = 15;
            // 
            // placeHolderTextBox2
            // 
            this.placeHolderTextBox2.Font = new System.Drawing.Font("굴림", 14.25F);
            this.placeHolderTextBox2.ForeColor = System.Drawing.Color.Gray;
            this.placeHolderTextBox2.Location = new System.Drawing.Point(124, 110);
            this.placeHolderTextBox2.Name = "placeHolderTextBox2";
            this.placeHolderTextBox2.PlaceHolderText = "*******";
            this.placeHolderTextBox2.Size = new System.Drawing.Size(289, 29);
            this.placeHolderTextBox2.TabIndex = 7;
            this.placeHolderTextBox2.Text = "*******";
            // 
            // placeHolderTextBox1
            // 
            this.placeHolderTextBox1.Font = new System.Drawing.Font("굴림", 14.25F);
            this.placeHolderTextBox1.ForeColor = System.Drawing.Color.Gray;
            this.placeHolderTextBox1.Location = new System.Drawing.Point(124, 42);
            this.placeHolderTextBox1.Name = "placeHolderTextBox1";
            this.placeHolderTextBox1.PlaceHolderText = "아이디를 입력해주세요";
            this.placeHolderTextBox1.Size = new System.Drawing.Size(289, 29);
            this.placeHolderTextBox1.TabIndex = 7;
            this.placeHolderTextBox1.Text = "아이디를 입력해주세요";
            // 
            // UserLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1165, 662);
            this.ControlBox = false;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserLogin";
            this.Text = "UserLogin";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSigin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkidpwd;
        private PlaceHolderTextBox placeHolderTextBox1;
        private PlaceHolderTextBox placeHolderTextBox2;
        private System.Windows.Forms.Panel panel1;
    }
}