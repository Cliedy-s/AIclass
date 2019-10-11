namespace _0923_03_RadioButton
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
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.grpContry = new System.Windows.Forms.GroupBox();
            this.panGender = new System.Windows.Forms.Panel();
            this.rdoMale = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.panArm = new System.Windows.Forms.Panel();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.radioButton9 = new System.Windows.Forms.RadioButton();
            this.grpContry.SuspendLayout();
            this.panGender.SuspendLayout();
            this.panArm.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(49, 37);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(71, 16);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "대한민국";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(49, 74);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(47, 16);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "미국";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(49, 148);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(79, 16);
            this.radioButton3.TabIndex = 3;
            this.radioButton3.Text = "그 외 국가";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(49, 111);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(47, 16);
            this.radioButton4.TabIndex = 2;
            this.radioButton4.Text = "중국";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // grpContry
            // 
            this.grpContry.Controls.Add(this.radioButton1);
            this.grpContry.Controls.Add(this.radioButton3);
            this.grpContry.Controls.Add(this.radioButton2);
            this.grpContry.Controls.Add(this.radioButton4);
            this.grpContry.Location = new System.Drawing.Point(30, 41);
            this.grpContry.Name = "grpContry";
            this.grpContry.Size = new System.Drawing.Size(200, 194);
            this.grpContry.TabIndex = 4;
            this.grpContry.TabStop = false;
            this.grpContry.Text = "국가";
            // 
            // panGender
            // 
            this.panGender.Controls.Add(this.rdoMale);
            this.panGender.Controls.Add(this.radioButton6);
            this.panGender.Location = new System.Drawing.Point(275, 41);
            this.panGender.Name = "panGender";
            this.panGender.Size = new System.Drawing.Size(258, 68);
            this.panGender.TabIndex = 4;
            // 
            // rdoMale
            // 
            this.rdoMale.AutoSize = true;
            this.rdoMale.Location = new System.Drawing.Point(45, 28);
            this.rdoMale.Name = "rdoMale";
            this.rdoMale.Size = new System.Drawing.Size(35, 16);
            this.rdoMale.TabIndex = 4;
            this.rdoMale.Text = "남";
            this.rdoMale.UseVisualStyleBackColor = true;
            this.rdoMale.CheckedChanged += new System.EventHandler(this.RadioButton5_CheckedChanged);
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Checked = true;
            this.radioButton6.Location = new System.Drawing.Point(171, 28);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(35, 16);
            this.radioButton6.TabIndex = 5;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "여";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(330, 212);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(203, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "저장";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // panArm
            // 
            this.panArm.Controls.Add(this.radioButton9);
            this.panArm.Controls.Add(this.radioButton8);
            this.panArm.Controls.Add(this.radioButton7);
            this.panArm.Location = new System.Drawing.Point(275, 115);
            this.panArm.Name = "panArm";
            this.panArm.Size = new System.Drawing.Size(258, 79);
            this.panArm.TabIndex = 4;
            this.panArm.Visible = false;
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Location = new System.Drawing.Point(45, 37);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(47, 16);
            this.radioButton7.TabIndex = 0;
            this.radioButton7.TabStop = true;
            this.radioButton7.Text = "미필";
            this.radioButton7.UseVisualStyleBackColor = true;
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.Location = new System.Drawing.Point(108, 37);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(47, 16);
            this.radioButton8.TabIndex = 1;
            this.radioButton8.TabStop = true;
            this.radioButton8.Text = "군필";
            this.radioButton8.UseVisualStyleBackColor = true;
            // 
            // radioButton9
            // 
            this.radioButton9.AutoSize = true;
            this.radioButton9.Location = new System.Drawing.Point(171, 37);
            this.radioButton9.Name = "radioButton9";
            this.radioButton9.Size = new System.Drawing.Size(47, 16);
            this.radioButton9.TabIndex = 2;
            this.radioButton9.TabStop = true;
            this.radioButton9.Text = "면제";
            this.radioButton9.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 304);
            this.Controls.Add(this.panArm);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panGender);
            this.Controls.Add(this.grpContry);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpContry.ResumeLayout(false);
            this.grpContry.PerformLayout();
            this.panGender.ResumeLayout(false);
            this.panGender.PerformLayout();
            this.panArm.ResumeLayout(false);
            this.panArm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.GroupBox grpContry;
        private System.Windows.Forms.Panel panGender;
        private System.Windows.Forms.RadioButton rdoMale;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panArm;
        private System.Windows.Forms.RadioButton radioButton9;
        private System.Windows.Forms.RadioButton radioButton8;
        private System.Windows.Forms.RadioButton radioButton7;
    }
}

