﻿namespace _1007_01_PlaceHolder
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
            this.placeHolderTextBox1 = new CLIP.eForm.Consent.Standard.Management.UI.PlaceHolderTextBox();
            this.SuspendLayout();
            // 
            // placeHolderTextBox1
            // 
            this.placeHolderTextBox1.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.placeHolderTextBox1.ForeColor = System.Drawing.Color.DarkRed;
            this.placeHolderTextBox1.Location = new System.Drawing.Point(224, 193);
            this.placeHolderTextBox1.Name = "placeHolderTextBox1";
            this.placeHolderTextBox1.PlaceHolderText = "이름을 입력하세요";
            this.placeHolderTextBox1.Size = new System.Drawing.Size(132, 25);
            this.placeHolderTextBox1.TabIndex = 0;
            this.placeHolderTextBox1.Text = "이름을 입력하세요";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.placeHolderTextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CLIP.eForm.Consent.Standard.Management.UI.PlaceHolderTextBox placeHolderTextBox1;
    }
}

