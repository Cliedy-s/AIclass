﻿namespace _1001_03_CustomControl
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
            this.button1 = new System.Windows.Forms.Button();
            this.fIleFinderUserControl1 = new _1001_03_CustomControl.FIleFinderUserControl();
            this.periodSearch1 = new _1001_03_CustomControl.PeriodSearch();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(495, 183);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "저장하기";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // fIleFinderUserControl1
            // 
            this.fIleFinderUserControl1.Location = new System.Drawing.Point(12, 3);
            this.fIleFinderUserControl1.Name = "fIleFinderUserControl1";
            this.fIleFinderUserControl1.Size = new System.Drawing.Size(370, 25);
            this.fIleFinderUserControl1.TabIndex = 0;
            // 
            // periodSearch1
            // 
            this.periodSearch1.EndDate = new System.DateTime(2019, 10, 2, 16, 39, 58, 208);
            this.periodSearch1.Location = new System.Drawing.Point(185, 251);
            this.periodSearch1.Name = "periodSearch1";
            this.periodSearch1.Period = _1001_03_CustomControl.Period.Week;
            this.periodSearch1.Size = new System.Drawing.Size(246, 23);
            this.periodSearch1.TabIndex = 4;
            this.periodSearch1.EndDateChanged += new System.EventHandler(this.PeriodSearch1_EndDateChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(509, 235);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.periodSearch1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.fIleFinderUserControl1);
            this.Name = "Form1";
            this.Text = "파일찾기";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FIleFinderUserControl fIleFinderUserControl1;
        private System.Windows.Forms.Button button1;
        private PeriodSearch periodSearch1;
        private System.Windows.Forms.Label label1;
    }
}

