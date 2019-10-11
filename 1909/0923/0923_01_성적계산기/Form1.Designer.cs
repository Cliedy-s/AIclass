namespace _0923_01_성적계산기
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtEngScore = new System.Windows.Forms.TextBox();
            this.txtMathScore = new System.Windows.Forms.TextBox();
            this.txtKorScore = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtAverage = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTotalResult = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Submit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtEngScore);
            this.groupBox1.Controls.Add(this.txtMathScore);
            this.groupBox1.Controls.Add(this.txtKorScore);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(46, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 187);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "성적입력";
            // 
            // txtEngScore
            // 
            this.txtEngScore.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.txtEngScore.Location = new System.Drawing.Point(78, 133);
            this.txtEngScore.Name = "txtEngScore";
            this.txtEngScore.Size = new System.Drawing.Size(100, 21);
            this.txtEngScore.TabIndex = 3;
            this.txtEngScore.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtScore_KeyPress);
            // 
            // txtMathScore
            // 
            this.txtMathScore.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.txtMathScore.Location = new System.Drawing.Point(78, 86);
            this.txtMathScore.Name = "txtMathScore";
            this.txtMathScore.Size = new System.Drawing.Size(100, 21);
            this.txtMathScore.TabIndex = 2;
            this.txtMathScore.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtScore_KeyPress);
            // 
            // txtKorScore
            // 
            this.txtKorScore.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.txtKorScore.Location = new System.Drawing.Point(78, 39);
            this.txtKorScore.Name = "txtKorScore";
            this.txtKorScore.Size = new System.Drawing.Size(100, 21);
            this.txtKorScore.TabIndex = 1;
            this.txtKorScore.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtScore_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 11;
            this.label4.Text = "영어";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 10;
            this.label3.Text = "수학";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 9;
            this.label2.Text = "국어";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtAverage);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtTotalResult);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(292, 50);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 125);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "결과";
            // 
            // txtAverage
            // 
            this.txtAverage.Location = new System.Drawing.Point(80, 82);
            this.txtAverage.Name = "txtAverage";
            this.txtAverage.ReadOnly = true;
            this.txtAverage.Size = new System.Drawing.Size(100, 21);
            this.txtAverage.TabIndex = 16;
            this.txtAverage.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 8;
            this.label6.Text = "평균";
            // 
            // txtTotalResult
            // 
            this.txtTotalResult.Location = new System.Drawing.Point(80, 35);
            this.txtTotalResult.Name = "txtTotalResult";
            this.txtTotalResult.ReadOnly = true;
            this.txtTotalResult.Size = new System.Drawing.Size(100, 21);
            this.txtTotalResult.TabIndex = 15;
            this.txtTotalResult.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 7;
            this.label7.Text = "총점";
            // 
            // Submit
            // 
            this.Submit.Location = new System.Drawing.Point(372, 213);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(100, 23);
            this.Submit.TabIndex = 4;
            this.Submit.Text = "계산";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 297);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "성적계산기";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtEngScore;
        private System.Windows.Forms.TextBox txtMathScore;
        private System.Windows.Forms.TextBox txtKorScore;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtAverage;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTotalResult;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Submit;
    }
}

