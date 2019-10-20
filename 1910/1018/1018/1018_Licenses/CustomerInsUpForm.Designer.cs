namespace _1018_Licenses
{
    partial class CustomerInsUpForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.submit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "CustomerID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "CustomerName";
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Location = new System.Drawing.Point(137, 45);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(140, 21);
            this.txtCustomerID.TabIndex = 0;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(137, 81);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(140, 21);
            this.txtCustomerName.TabIndex = 1;
            this.txtCustomerName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCustomerName_KeyPress);
            // 
            // submit
            // 
            this.submit.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.submit.Location = new System.Drawing.Point(201, 136);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(75, 23);
            this.submit.TabIndex = 2;
            this.submit.Text = "submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // CustomerInsUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 182);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.txtCustomerID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CustomerInsUpForm";
            this.Text = "CustomerInsUpForm";
            this.Load += new System.EventHandler(this.CustomerInsUpForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Button submit;
    }
}