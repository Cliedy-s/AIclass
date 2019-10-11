namespace _0924_03_ListView
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("노드2");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("노드5");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("노드6");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("노드9");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("노드10");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("노드11");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("노드7", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5,
            treeNode6});
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("노드3", new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode3,
            treeNode7});
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("노드1", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode8});
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("노드12");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("노드13");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("노드14");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("노드4", new System.Windows.Forms.TreeNode[] {
            treeNode10,
            treeNode11,
            treeNode12});
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("노드8");
            this.rdoDetail = new System.Windows.Forms.RadioButton();
            this.panView = new System.Windows.Forms.Panel();
            this.rdoTile = new System.Windows.Forms.RadioButton();
            this.rdoSmallIcon = new System.Windows.Forms.RadioButton();
            this.rdoLargeIcon = new System.Windows.Forms.RadioButton();
            this.rdoList = new System.Windows.Forms.RadioButton();
            this.listView1 = new System.Windows.Forms.ListView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.panView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // rdoDetail
            // 
            this.rdoDetail.AutoSize = true;
            this.rdoDetail.Location = new System.Drawing.Point(79, 48);
            this.rdoDetail.Name = "rdoDetail";
            this.rdoDetail.Size = new System.Drawing.Size(54, 16);
            this.rdoDetail.TabIndex = 0;
            this.rdoDetail.TabStop = true;
            this.rdoDetail.Tag = System.Windows.Forms.View.Details;
            this.rdoDetail.Text = "Detail";
            this.rdoDetail.UseVisualStyleBackColor = true;
            this.rdoDetail.CheckedChanged += new System.EventHandler(this.Rdo_CheckedChanged);
            // 
            // panView
            // 
            this.panView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panView.Controls.Add(this.rdoTile);
            this.panView.Controls.Add(this.rdoSmallIcon);
            this.panView.Controls.Add(this.rdoLargeIcon);
            this.panView.Controls.Add(this.rdoList);
            this.panView.Controls.Add(this.rdoDetail);
            this.panView.Location = new System.Drawing.Point(12, 12);
            this.panView.Name = "panView";
            this.panView.Size = new System.Drawing.Size(734, 110);
            this.panView.TabIndex = 1;
            // 
            // rdoTile
            // 
            this.rdoTile.AutoSize = true;
            this.rdoTile.Location = new System.Drawing.Point(621, 48);
            this.rdoTile.Name = "rdoTile";
            this.rdoTile.Size = new System.Drawing.Size(44, 16);
            this.rdoTile.TabIndex = 4;
            this.rdoTile.TabStop = true;
            this.rdoTile.Tag = "";
            this.rdoTile.Text = "Tile";
            this.rdoTile.UseVisualStyleBackColor = true;
            // 
            // rdoSmallIcon
            // 
            this.rdoSmallIcon.AutoSize = true;
            this.rdoSmallIcon.Location = new System.Drawing.Point(468, 48);
            this.rdoSmallIcon.Name = "rdoSmallIcon";
            this.rdoSmallIcon.Size = new System.Drawing.Size(79, 16);
            this.rdoSmallIcon.TabIndex = 3;
            this.rdoSmallIcon.TabStop = true;
            this.rdoSmallIcon.Tag = "largeicon";
            this.rdoSmallIcon.Text = "SmallIcon";
            this.rdoSmallIcon.UseVisualStyleBackColor = true;
            this.rdoSmallIcon.CheckedChanged += new System.EventHandler(this.Rdo_CheckedChanged);
            // 
            // rdoLargeIcon
            // 
            this.rdoLargeIcon.AutoSize = true;
            this.rdoLargeIcon.Location = new System.Drawing.Point(318, 48);
            this.rdoLargeIcon.Name = "rdoLargeIcon";
            this.rdoLargeIcon.Size = new System.Drawing.Size(79, 16);
            this.rdoLargeIcon.TabIndex = 2;
            this.rdoLargeIcon.TabStop = true;
            this.rdoLargeIcon.Tag = "tile";
            this.rdoLargeIcon.Text = "LargeIcon";
            this.rdoLargeIcon.UseVisualStyleBackColor = true;
            this.rdoLargeIcon.CheckedChanged += new System.EventHandler(this.Rdo_CheckedChanged);
            // 
            // rdoList
            // 
            this.rdoList.AutoSize = true;
            this.rdoList.Location = new System.Drawing.Point(204, 50);
            this.rdoList.Name = "rdoList";
            this.rdoList.Size = new System.Drawing.Size(43, 16);
            this.rdoList.TabIndex = 1;
            this.rdoList.TabStop = true;
            this.rdoList.Tag = "list";
            this.rdoList.Text = "List";
            this.rdoList.UseVisualStyleBackColor = true;
            this.rdoList.CheckedChanged += new System.EventHandler(this.Rdo_CheckedChanged);
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 128);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(734, 283);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(480, 417);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(266, 21);
            this.textBox1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(436, 420);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::_0924_03_ListView.Properties.Resources.Image1;
            this.pictureBox1.Location = new System.Drawing.Point(752, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(183, 110);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(752, 128);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 32);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // treeView1
            // 
            this.treeView1.CheckBoxes = true;
            this.treeView1.Indent = 10;
            this.treeView1.ItemHeight = 20;
            this.treeView1.LineColor = System.Drawing.Color.Aquamarine;
            this.treeView1.Location = new System.Drawing.Point(941, 12);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "노드2";
            treeNode1.Text = "노드2";
            treeNode2.Name = "노드5";
            treeNode2.Text = "노드5";
            treeNode3.Name = "노드6";
            treeNode3.Text = "노드6";
            treeNode4.Name = "노드9";
            treeNode4.Text = "노드9";
            treeNode5.Name = "노드10";
            treeNode5.Text = "노드10";
            treeNode6.Name = "노드11";
            treeNode6.Text = "노드11";
            treeNode7.Name = "노드7";
            treeNode7.Text = "노드7";
            treeNode8.Name = "노드3";
            treeNode8.Text = "노드3";
            treeNode9.Name = "노드1";
            treeNode9.Text = "노드1";
            treeNode10.Name = "노드12";
            treeNode10.Text = "노드12";
            treeNode11.Name = "노드13";
            treeNode11.Text = "노드13";
            treeNode12.Name = "노드14";
            treeNode12.Text = "노드14";
            treeNode13.Name = "노드4";
            treeNode13.Text = "노드4";
            treeNode14.Name = "노드8";
            treeNode14.Text = "노드8";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode9,
            treeNode13,
            treeNode14});
            this.treeView1.Size = new System.Drawing.Size(247, 426);
            this.treeView1.TabIndex = 7;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TreeView1_AfterSelect);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 450);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.panView);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panView.ResumeLayout(false);
            this.panView.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdoDetail;
        private System.Windows.Forms.Panel panView;
        private System.Windows.Forms.RadioButton rdoSmallIcon;
        private System.Windows.Forms.RadioButton rdoLargeIcon;
        private System.Windows.Forms.RadioButton rdoList;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdoTile;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TreeView treeView1;
    }
}