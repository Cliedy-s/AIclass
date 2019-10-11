namespace _0923_02_CheckBox
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
            this.chkDog = new System.Windows.Forms.CheckBox();
            this.chkCat = new System.Windows.Forms.CheckBox();
            this.chkSnake = new System.Windows.Forms.CheckBox();
            this.chkParrot = new System.Windows.Forms.CheckBox();
            this.chkMonkey = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.Label();
            this.grpAnimals = new System.Windows.Forms.GroupBox();
            this.panAnimals = new System.Windows.Forms.Panel();
            this.chkCat02 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.grpAnimals.SuspendLayout();
            this.panAnimals.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkDog
            // 
            this.chkDog.AutoSize = true;
            this.chkDog.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkDog.Location = new System.Drawing.Point(22, 15);
            this.chkDog.Name = "chkDog";
            this.chkDog.Size = new System.Drawing.Size(21, 16);
            this.chkDog.TabIndex = 0;
            this.chkDog.Text = "개";
            this.chkDog.UseVisualStyleBackColor = true;
            // 
            // chkCat
            // 
            this.chkCat.AutoSize = true;
            this.chkCat.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkCat.Location = new System.Drawing.Point(22, 52);
            this.chkCat.Name = "chkCat";
            this.chkCat.Size = new System.Drawing.Size(45, 16);
            this.chkCat.TabIndex = 1;
            this.chkCat.Text = "고양이";
            this.chkCat.UseVisualStyleBackColor = true;
            this.chkCat.CheckedChanged += new System.EventHandler(this.ChkCat_CheckedChanged);
            // 
            // chkSnake
            // 
            this.chkSnake.AutoSize = true;
            this.chkSnake.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkSnake.Location = new System.Drawing.Point(22, 89);
            this.chkSnake.Name = "chkSnake";
            this.chkSnake.Size = new System.Drawing.Size(21, 16);
            this.chkSnake.TabIndex = 2;
            this.chkSnake.Text = "뱀";
            this.chkSnake.UseVisualStyleBackColor = true;
            // 
            // chkParrot
            // 
            this.chkParrot.AutoSize = true;
            this.chkParrot.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkParrot.Location = new System.Drawing.Point(22, 126);
            this.chkParrot.Name = "chkParrot";
            this.chkParrot.Size = new System.Drawing.Size(45, 16);
            this.chkParrot.TabIndex = 3;
            this.chkParrot.Text = "앵무새";
            this.chkParrot.UseVisualStyleBackColor = true;
            // 
            // chkMonkey
            // 
            this.chkMonkey.AutoSize = true;
            this.chkMonkey.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkMonkey.Location = new System.Drawing.Point(22, 163);
            this.chkMonkey.Name = "chkMonkey";
            this.chkMonkey.Size = new System.Drawing.Size(45, 16);
            this.chkMonkey.TabIndex = 4;
            this.chkMonkey.Text = "원숭이";
            this.chkMonkey.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "당신이 좋아하는 동물은?";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(218, 272);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "저장";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Location = new System.Drawing.Point(40, 303);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(0, 12);
            this.result.TabIndex = 7;
            // 
            // grpAnimals
            // 
            this.grpAnimals.Controls.Add(this.chkCat);
            this.grpAnimals.Controls.Add(this.chkDog);
            this.grpAnimals.Controls.Add(this.chkSnake);
            this.grpAnimals.Controls.Add(this.chkParrot);
            this.grpAnimals.Controls.Add(this.chkMonkey);
            this.grpAnimals.Location = new System.Drawing.Point(42, 80);
            this.grpAnimals.Name = "grpAnimals";
            this.grpAnimals.Size = new System.Drawing.Size(146, 188);
            this.grpAnimals.TabIndex = 8;
            this.grpAnimals.TabStop = false;
            // 
            // panAnimals
            // 
            this.panAnimals.Controls.Add(this.chkCat02);
            this.panAnimals.Controls.Add(this.checkBox2);
            this.panAnimals.Controls.Add(this.checkBox5);
            this.panAnimals.Controls.Add(this.checkBox3);
            this.panAnimals.Controls.Add(this.checkBox4);
            this.panAnimals.Location = new System.Drawing.Point(206, 85);
            this.panAnimals.Name = "panAnimals";
            this.panAnimals.Size = new System.Drawing.Size(111, 181);
            this.panAnimals.TabIndex = 5;
            // 
            // chkCat02
            // 
            this.chkCat02.AutoSize = true;
            this.chkCat02.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkCat02.Location = new System.Drawing.Point(12, 47);
            this.chkCat02.Name = "chkCat02";
            this.chkCat02.Size = new System.Drawing.Size(45, 16);
            this.chkCat02.TabIndex = 6;
            this.chkCat02.Text = "고양이";
            this.chkCat02.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox2.Location = new System.Drawing.Point(12, 10);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(21, 16);
            this.checkBox2.TabIndex = 5;
            this.checkBox2.Text = "개";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox3.Location = new System.Drawing.Point(12, 84);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(21, 16);
            this.checkBox3.TabIndex = 7;
            this.checkBox3.Text = "뱀";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox4.Location = new System.Drawing.Point(12, 121);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(45, 16);
            this.checkBox4.TabIndex = 8;
            this.checkBox4.Text = "앵무새";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox5.Location = new System.Drawing.Point(12, 158);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(45, 16);
            this.checkBox5.TabIndex = 9;
            this.checkBox5.Text = "원숭이";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(357, 80);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "안보이게";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 337);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panAnimals);
            this.Controls.Add(this.grpAnimals);
            this.Controls.Add(this.result);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "체크박스";
            this.grpAnimals.ResumeLayout(false);
            this.grpAnimals.PerformLayout();
            this.panAnimals.ResumeLayout(false);
            this.panAnimals.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkDog;
        private System.Windows.Forms.CheckBox chkCat;
        private System.Windows.Forms.CheckBox chkSnake;
        private System.Windows.Forms.CheckBox chkParrot;
        private System.Windows.Forms.CheckBox chkMonkey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.GroupBox grpAnimals;
        private System.Windows.Forms.Panel panAnimals;
        private System.Windows.Forms.CheckBox chkCat02;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.Button button1;
    }
}

