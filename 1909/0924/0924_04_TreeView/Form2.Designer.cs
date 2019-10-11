namespace _0924_04_TreeView
{
    partial class Form2
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
            this.btnSubmit = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.frm2txtZip = new System.Windows.Forms.TextBox();
            this.frm2txtAddr02 = new System.Windows.Forms.TextBox();
            this.frm2txtAddr01 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSubmit.Location = new System.Drawing.Point(439, 347);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 24);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "적용";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(520, 347);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 24);
            this.button2.TabIndex = 3;
            this.button2.Text = "취소";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // frm2txtZip
            // 
            this.frm2txtZip.Location = new System.Drawing.Point(203, 214);
            this.frm2txtZip.Name = "frm2txtZip";
            this.frm2txtZip.Size = new System.Drawing.Size(160, 21);
            this.frm2txtZip.TabIndex = 7;
            // 
            // frm2txtAddr02
            // 
            this.frm2txtAddr02.Location = new System.Drawing.Point(203, 296);
            this.frm2txtAddr02.Name = "frm2txtAddr02";
            this.frm2txtAddr02.Size = new System.Drawing.Size(392, 21);
            this.frm2txtAddr02.TabIndex = 6;
            // 
            // frm2txtAddr01
            // 
            this.frm2txtAddr01.Location = new System.Drawing.Point(203, 255);
            this.frm2txtAddr01.Name = "frm2txtAddr01";
            this.frm2txtAddr01.Size = new System.Drawing.Size(392, 21);
            this.frm2txtAddr01.TabIndex = 5;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.frm2txtZip);
            this.Controls.Add(this.frm2txtAddr02);
            this.Controls.Add(this.frm2txtAddr01);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnSubmit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox frm2txtZip;
        private System.Windows.Forms.TextBox frm2txtAddr02;
        private System.Windows.Forms.TextBox frm2txtAddr01;
    }
}