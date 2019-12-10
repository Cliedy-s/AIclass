namespace IceCreamManager
{
    partial class ProductDialogue_Form
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
            this.btnSave = new System.Windows.Forms.Button();
            this.txtProductSum = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbOffereName = new System.Windows.Forms.ComboBox();
            this.lblProductCode = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbbProductType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.nudProductNum = new System.Windows.Forms.NumericUpDown();
            this.lblType = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.rdbL = new System.Windows.Forms.RadioButton();
            this.rdbg = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.nudProductNum)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnSave.Location = new System.Drawing.Point(280, 252);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 32;
            this.btnSave.Text = "저장";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtProductSum
            // 
            this.txtProductSum.Location = new System.Drawing.Point(91, 127);
            this.txtProductSum.MaxLength = 7;
            this.txtProductSum.Name = "txtProductSum";
            this.txtProductSum.Size = new System.Drawing.Size(100, 21);
            this.txtProductSum.TabIndex = 26;
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(91, 89);
            this.txtProductName.MaxLength = 50;
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(100, 21);
            this.txtProductName.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(12, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 23;
            this.label7.Text = "코드";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(15, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 22;
            this.label6.Text = "갯수";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(15, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 19;
            this.label3.Text = "가격";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(15, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 18;
            this.label2.Text = "자재이름";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 17;
            this.label1.Text = "제조사명";
            // 
            // cbbOffereName
            // 
            this.cbbOffereName.FormattingEnabled = true;
            this.cbbOffereName.Location = new System.Drawing.Point(91, 25);
            this.cbbOffereName.Name = "cbbOffereName";
            this.cbbOffereName.Size = new System.Drawing.Size(121, 20);
            this.cbbOffereName.TabIndex = 33;
            // 
            // lblProductCode
            // 
            this.lblProductCode.AutoSize = true;
            this.lblProductCode.ForeColor = System.Drawing.Color.White;
            this.lblProductCode.Location = new System.Drawing.Point(89, 57);
            this.lblProductCode.Name = "lblProductCode";
            this.lblProductCode.Size = new System.Drawing.Size(29, 12);
            this.lblProductCode.TabIndex = 31;
            this.lblProductCode.Text = "코드";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(15, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 12);
            this.label4.TabIndex = 34;
            this.label4.Text = "자재 타입";
            // 
            // cbbProductType
            // 
            this.cbbProductType.FormattingEnabled = true;
            this.cbbProductType.Items.AddRange(new object[] {
            "완제품",
            "원제품",
            "반자재",
            "소모품"});
            this.cbbProductType.Location = new System.Drawing.Point(91, 154);
            this.cbbProductType.Name = "cbbProductType";
            this.cbbProductType.Size = new System.Drawing.Size(121, 20);
            this.cbbProductType.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(194, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 12);
            this.label5.TabIndex = 36;
            this.label5.Text = "시럽이면 그람으로 변경 ㅇㅋ";
            // 
            // nudProductNum
            // 
            this.nudProductNum.Location = new System.Drawing.Point(91, 207);
            this.nudProductNum.Name = "nudProductNum";
            this.nudProductNum.Size = new System.Drawing.Size(100, 21);
            this.nudProductNum.TabIndex = 37;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.ForeColor = System.Drawing.Color.White;
            this.lblType.Location = new System.Drawing.Point(197, 225);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(0, 12);
            this.lblType.TabIndex = 38;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(197, 130);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(17, 12);
            this.label9.TabIndex = 39;
            this.label9.Text = "원";
            // 
            // rdbL
            // 
            this.rdbL.AutoSize = true;
            this.rdbL.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rdbL.Location = new System.Drawing.Point(91, 180);
            this.rdbL.Name = "rdbL";
            this.rdbL.Size = new System.Drawing.Size(47, 16);
            this.rdbL.TabIndex = 40;
            this.rdbL.TabStop = true;
            this.rdbL.Text = "리터";
            this.rdbL.UseVisualStyleBackColor = true;
            this.rdbL.CheckedChanged += new System.EventHandler(this.rdbL_CheckedChanged);
            // 
            // rdbg
            // 
            this.rdbg.AutoSize = true;
            this.rdbg.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rdbg.Location = new System.Drawing.Point(144, 180);
            this.rdbg.Name = "rdbg";
            this.rdbg.Size = new System.Drawing.Size(47, 16);
            this.rdbg.TabIndex = 41;
            this.rdbg.TabStop = true;
            this.rdbg.Text = "개수";
            this.rdbg.UseVisualStyleBackColor = true;
            this.rdbg.CheckedChanged += new System.EventHandler(this.rdbL_CheckedChanged);
            // 
            // ProductDialogue_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(367, 313);
            this.Controls.Add(this.rdbg);
            this.Controls.Add(this.rdbL);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.nudProductNum);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbbProductType);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbbOffereName);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblProductCode);
            this.Controls.Add(this.txtProductSum);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ProductDialogue_Form";
            this.Text = "제품등록";
            ((System.ComponentModel.ISupportInitialize)(this.nudProductNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtProductSum;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbOffereName;
        private System.Windows.Forms.Label lblProductCode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbbProductType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudProductNum;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton rdbL;
        private System.Windows.Forms.RadioButton rdbg;
    }
}