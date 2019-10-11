namespace _0924_01_ComboBox
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
            this.txtClass01 = new System.Windows.Forms.TextBox();
            this.txtClass02 = new System.Windows.Forms.TextBox();
            this.txtClass03 = new System.Windows.Forms.TextBox();
            this.txtClass04 = new System.Windows.Forms.TextBox();
            this.txtClass05 = new System.Windows.Forms.TextBox();
            this.txtClass06 = new System.Windows.Forms.TextBox();
            this.txtClass07 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGetResult = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.cmbPoint01 = new System.Windows.Forms.ComboBox();
            this.cmbPoint02 = new System.Windows.Forms.ComboBox();
            this.cmbPoint03 = new System.Windows.Forms.ComboBox();
            this.cmbPoint04 = new System.Windows.Forms.ComboBox();
            this.cmbPoint05 = new System.Windows.Forms.ComboBox();
            this.cmbPoint06 = new System.Windows.Forms.ComboBox();
            this.cmbPoint07 = new System.Windows.Forms.ComboBox();
            this.cmbScore03 = new System.Windows.Forms.ComboBox();
            this.cmbScore01 = new System.Windows.Forms.ComboBox();
            this.cmbScore02 = new System.Windows.Forms.ComboBox();
            this.cmbScore04 = new System.Windows.Forms.ComboBox();
            this.cmbScore05 = new System.Windows.Forms.ComboBox();
            this.cmbScore06 = new System.Windows.Forms.ComboBox();
            this.cmbScore07 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "과목명";
            // 
            // txtClass01
            // 
            this.txtClass01.Location = new System.Drawing.Point(26, 57);
            this.txtClass01.Name = "txtClass01";
            this.txtClass01.Size = new System.Drawing.Size(190, 21);
            this.txtClass01.TabIndex = 1;
            // 
            // txtClass02
            // 
            this.txtClass02.Location = new System.Drawing.Point(26, 84);
            this.txtClass02.Name = "txtClass02";
            this.txtClass02.Size = new System.Drawing.Size(190, 21);
            this.txtClass02.TabIndex = 4;
            // 
            // txtClass03
            // 
            this.txtClass03.Location = new System.Drawing.Point(26, 111);
            this.txtClass03.Name = "txtClass03";
            this.txtClass03.Size = new System.Drawing.Size(190, 21);
            this.txtClass03.TabIndex = 7;
            // 
            // txtClass04
            // 
            this.txtClass04.Location = new System.Drawing.Point(26, 138);
            this.txtClass04.Name = "txtClass04";
            this.txtClass04.Size = new System.Drawing.Size(190, 21);
            this.txtClass04.TabIndex = 10;
            // 
            // txtClass05
            // 
            this.txtClass05.Location = new System.Drawing.Point(26, 165);
            this.txtClass05.Name = "txtClass05";
            this.txtClass05.Size = new System.Drawing.Size(190, 21);
            this.txtClass05.TabIndex = 13;
            // 
            // txtClass06
            // 
            this.txtClass06.Location = new System.Drawing.Point(26, 192);
            this.txtClass06.Name = "txtClass06";
            this.txtClass06.Size = new System.Drawing.Size(190, 21);
            this.txtClass06.TabIndex = 16;
            // 
            // txtClass07
            // 
            this.txtClass07.Location = new System.Drawing.Point(26, 219);
            this.txtClass07.Name = "txtClass07";
            this.txtClass07.Size = new System.Drawing.Size(190, 21);
            this.txtClass07.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(259, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 22;
            this.label2.Text = "학점";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(385, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 23;
            this.label3.Text = "성적";
            // 
            // btnGetResult
            // 
            this.btnGetResult.Location = new System.Drawing.Point(268, 262);
            this.btnGetResult.Name = "btnGetResult";
            this.btnGetResult.Size = new System.Drawing.Size(75, 23);
            this.btnGetResult.TabIndex = 24;
            this.btnGetResult.Text = "학점계산";
            this.btnGetResult.UseVisualStyleBackColor = true;
            this.btnGetResult.Click += new System.EventHandler(this.BtnGetResult_Click);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(387, 262);
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(83, 21);
            this.txtResult.TabIndex = 25;
            // 
            // cmbPoint01
            // 
            this.cmbPoint01.FormattingEnabled = true;
            this.cmbPoint01.Location = new System.Drawing.Point(222, 57);
            this.cmbPoint01.Name = "cmbPoint01";
            this.cmbPoint01.Size = new System.Drawing.Size(121, 20);
            this.cmbPoint01.TabIndex = 26;
            this.cmbPoint01.Tag = "point";
            // 
            // cmbPoint02
            // 
            this.cmbPoint02.FormattingEnabled = true;
            this.cmbPoint02.Location = new System.Drawing.Point(222, 84);
            this.cmbPoint02.Name = "cmbPoint02";
            this.cmbPoint02.Size = new System.Drawing.Size(121, 20);
            this.cmbPoint02.TabIndex = 27;
            this.cmbPoint02.Tag = "point";
            // 
            // cmbPoint03
            // 
            this.cmbPoint03.FormattingEnabled = true;
            this.cmbPoint03.Location = new System.Drawing.Point(222, 111);
            this.cmbPoint03.Name = "cmbPoint03";
            this.cmbPoint03.Size = new System.Drawing.Size(121, 20);
            this.cmbPoint03.TabIndex = 28;
            this.cmbPoint03.Tag = "point";
            // 
            // cmbPoint04
            // 
            this.cmbPoint04.FormattingEnabled = true;
            this.cmbPoint04.Location = new System.Drawing.Point(222, 138);
            this.cmbPoint04.Name = "cmbPoint04";
            this.cmbPoint04.Size = new System.Drawing.Size(121, 20);
            this.cmbPoint04.TabIndex = 29;
            this.cmbPoint04.Tag = "point";
            // 
            // cmbPoint05
            // 
            this.cmbPoint05.FormattingEnabled = true;
            this.cmbPoint05.Location = new System.Drawing.Point(222, 165);
            this.cmbPoint05.Name = "cmbPoint05";
            this.cmbPoint05.Size = new System.Drawing.Size(121, 20);
            this.cmbPoint05.TabIndex = 30;
            this.cmbPoint05.Tag = "point";
            // 
            // cmbPoint06
            // 
            this.cmbPoint06.FormattingEnabled = true;
            this.cmbPoint06.Location = new System.Drawing.Point(222, 192);
            this.cmbPoint06.Name = "cmbPoint06";
            this.cmbPoint06.Size = new System.Drawing.Size(121, 20);
            this.cmbPoint06.TabIndex = 31;
            this.cmbPoint06.Tag = "point";
            // 
            // cmbPoint07
            // 
            this.cmbPoint07.FormattingEnabled = true;
            this.cmbPoint07.Location = new System.Drawing.Point(222, 219);
            this.cmbPoint07.Name = "cmbPoint07";
            this.cmbPoint07.Size = new System.Drawing.Size(121, 20);
            this.cmbPoint07.TabIndex = 32;
            this.cmbPoint07.Tag = "point";
            // 
            // cmbScore03
            // 
            this.cmbScore03.FormattingEnabled = true;
            this.cmbScore03.Location = new System.Drawing.Point(349, 111);
            this.cmbScore03.Name = "cmbScore03";
            this.cmbScore03.Size = new System.Drawing.Size(121, 20);
            this.cmbScore03.TabIndex = 35;
            this.cmbScore03.Tag = "score";
            // 
            // cmbScore01
            // 
            this.cmbScore01.FormattingEnabled = true;
            this.cmbScore01.Location = new System.Drawing.Point(349, 57);
            this.cmbScore01.Name = "cmbScore01";
            this.cmbScore01.Size = new System.Drawing.Size(121, 20);
            this.cmbScore01.TabIndex = 33;
            this.cmbScore01.Tag = "score";
            // 
            // cmbScore02
            // 
            this.cmbScore02.FormattingEnabled = true;
            this.cmbScore02.Location = new System.Drawing.Point(349, 84);
            this.cmbScore02.Name = "cmbScore02";
            this.cmbScore02.Size = new System.Drawing.Size(121, 20);
            this.cmbScore02.TabIndex = 34;
            this.cmbScore02.Tag = "score";
            // 
            // cmbScore04
            // 
            this.cmbScore04.FormattingEnabled = true;
            this.cmbScore04.Location = new System.Drawing.Point(349, 138);
            this.cmbScore04.Name = "cmbScore04";
            this.cmbScore04.Size = new System.Drawing.Size(121, 20);
            this.cmbScore04.TabIndex = 36;
            this.cmbScore04.Tag = "score";
            // 
            // cmbScore05
            // 
            this.cmbScore05.FormattingEnabled = true;
            this.cmbScore05.Location = new System.Drawing.Point(349, 165);
            this.cmbScore05.Name = "cmbScore05";
            this.cmbScore05.Size = new System.Drawing.Size(121, 20);
            this.cmbScore05.TabIndex = 37;
            this.cmbScore05.Tag = "score";
            // 
            // cmbScore06
            // 
            this.cmbScore06.FormattingEnabled = true;
            this.cmbScore06.Location = new System.Drawing.Point(349, 192);
            this.cmbScore06.Name = "cmbScore06";
            this.cmbScore06.Size = new System.Drawing.Size(121, 20);
            this.cmbScore06.TabIndex = 38;
            this.cmbScore06.Tag = "score";
            // 
            // cmbScore07
            // 
            this.cmbScore07.FormattingEnabled = true;
            this.cmbScore07.Location = new System.Drawing.Point(349, 219);
            this.cmbScore07.Name = "cmbScore07";
            this.cmbScore07.Size = new System.Drawing.Size(121, 20);
            this.cmbScore07.TabIndex = 39;
            this.cmbScore07.Tag = "score";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 306);
            this.Controls.Add(this.cmbScore03);
            this.Controls.Add(this.cmbScore01);
            this.Controls.Add(this.cmbScore02);
            this.Controls.Add(this.cmbScore04);
            this.Controls.Add(this.cmbScore05);
            this.Controls.Add(this.cmbScore06);
            this.Controls.Add(this.cmbScore07);
            this.Controls.Add(this.cmbPoint01);
            this.Controls.Add(this.cmbPoint02);
            this.Controls.Add(this.cmbPoint03);
            this.Controls.Add(this.cmbPoint04);
            this.Controls.Add(this.cmbPoint05);
            this.Controls.Add(this.cmbPoint06);
            this.Controls.Add(this.cmbPoint07);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btnGetResult);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtClass07);
            this.Controls.Add(this.txtClass06);
            this.Controls.Add(this.txtClass05);
            this.Controls.Add(this.txtClass04);
            this.Controls.Add(this.txtClass03);
            this.Controls.Add(this.txtClass02);
            this.Controls.Add(this.txtClass01);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtClass01;
        private System.Windows.Forms.TextBox txtClass02;
        private System.Windows.Forms.TextBox txtClass03;
        private System.Windows.Forms.TextBox txtClass04;
        private System.Windows.Forms.TextBox txtClass05;
        private System.Windows.Forms.TextBox txtClass06;
        private System.Windows.Forms.TextBox txtClass07;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGetResult;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.ComboBox cmbPoint01;
        private System.Windows.Forms.ComboBox cmbPoint02;
        private System.Windows.Forms.ComboBox cmbPoint03;
        private System.Windows.Forms.ComboBox cmbPoint04;
        private System.Windows.Forms.ComboBox cmbPoint05;
        private System.Windows.Forms.ComboBox cmbPoint06;
        private System.Windows.Forms.ComboBox cmbPoint07;
        private System.Windows.Forms.ComboBox cmbScore03;
        private System.Windows.Forms.ComboBox cmbScore01;
        private System.Windows.Forms.ComboBox cmbScore02;
        private System.Windows.Forms.ComboBox cmbScore04;
        private System.Windows.Forms.ComboBox cmbScore05;
        private System.Windows.Forms.ComboBox cmbScore06;
        private System.Windows.Forms.ComboBox cmbScore07;
    }
}

