namespace _1227_02_EnterNext
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
            this.team4TextBox3 = new _1227_02_EnterNext.Team4TextBox();
            this.team4TextBox4 = new _1227_02_EnterNext.Team4TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.team4TextBox5 = new _1227_02_EnterNext.Team4TextBox();
            this.team4TextBox6 = new _1227_02_EnterNext.Team4TextBox();
            this.SuspendLayout();
            // 
            // team4TextBox3
            // 
            this.team4TextBox3.BackColor = System.Drawing.Color.Yellow;
            this.team4TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.team4TextBox3.errorp = null;
            this.team4TextBox3.Location = new System.Drawing.Point(202, 158);
            this.team4TextBox3.Name = "team4TextBox3";
            this.team4TextBox3.Size = new System.Drawing.Size(100, 21);
            this.team4TextBox3.TabIndex = 2;
            this.team4TextBox3.txtType = _1227_02_EnterNext.Team4TextBox.type.Required;
            // 
            // team4TextBox4
            // 
            this.team4TextBox4.BackColor = System.Drawing.Color.White;
            this.team4TextBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.team4TextBox4.errorp = null;
            this.team4TextBox4.Location = new System.Drawing.Point(202, 185);
            this.team4TextBox4.Name = "team4TextBox4";
            this.team4TextBox4.Size = new System.Drawing.Size(100, 21);
            this.team4TextBox4.TabIndex = 3;
            this.team4TextBox4.txtType = _1227_02_EnterNext.Team4TextBox.type.Normal;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(202, 212);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // team4TextBox5
            // 
            this.team4TextBox5.BackColor = System.Drawing.Color.HotPink;
            this.team4TextBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.team4TextBox5.errorp = null;
            this.team4TextBox5.Location = new System.Drawing.Point(202, 130);
            this.team4TextBox5.Name = "team4TextBox5";
            this.team4TextBox5.Size = new System.Drawing.Size(100, 21);
            this.team4TextBox5.TabIndex = 1;
            this.team4TextBox5.txtType = _1227_02_EnterNext.Team4TextBox.type.Numeric;
            // 
            // team4TextBox6
            // 
            this.team4TextBox6.BackColor = System.Drawing.Color.White;
            this.team4TextBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.team4TextBox6.errorp = null;
            this.team4TextBox6.Location = new System.Drawing.Point(202, 103);
            this.team4TextBox6.Name = "team4TextBox6";
            this.team4TextBox6.Size = new System.Drawing.Size(100, 21);
            this.team4TextBox6.TabIndex = 0;
            this.team4TextBox6.txtType = _1227_02_EnterNext.Team4TextBox.type.Normal;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.team4TextBox5);
            this.Controls.Add(this.team4TextBox6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.team4TextBox4);
            this.Controls.Add(this.team4TextBox3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Team4TextBox team4TextBox3;
        private Team4TextBox team4TextBox4;
        private System.Windows.Forms.Button button1;
        private Team4TextBox team4TextBox5;
        private Team4TextBox team4TextBox6;
    }
}

