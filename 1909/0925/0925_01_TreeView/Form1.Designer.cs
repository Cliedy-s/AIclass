namespace _0925_01_TreeView
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("노드1");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("노드0", new System.Windows.Forms.TreeNode[] {
            treeNode1});
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmnuAddNode = new System.Windows.Forms.ToolStripMenuItem();
            this.cmnuRemoveNode = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnNodeTagSearch = new System.Windows.Forms.Button();
            this.txtTagSearch = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gbxSearchByText = new System.Windows.Forms.GroupBox();
            this.btnNodeTextSearch = new System.Windows.Forms.Button();
            this.txtNodeTextSearch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gbxNodeSearch = new System.Windows.Forms.GroupBox();
            this.btnFindNode = new System.Windows.Forms.Button();
            this.txtNodeSearch = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.gbxNodeInfo = new System.Windows.Forms.GroupBox();
            this.txtTag = new System.Windows.Forms.TextBox();
            this.txtText = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtParentName = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbxSearchByText.SuspendLayout();
            this.gbxNodeSearch.SuspendLayout();
            this.gbxNodeInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.treeView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel2.Controls.Add(this.gbxSearchByText);
            this.splitContainer1.Panel2.Controls.Add(this.gbxNodeSearch);
            this.splitContainer1.Panel2.Controls.Add(this.gbxNodeInfo);
            this.splitContainer1.Size = new System.Drawing.Size(701, 438);
            this.splitContainer1.SplitterDistance = 232;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 0;
            // 
            // treeView1
            // 
            this.treeView1.ContextMenuStrip = this.contextMenuStrip1;
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "노드1";
            treeNode1.Text = "노드1";
            treeNode2.Name = "노드0";
            treeNode2.Text = "노드0";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2});
            this.treeView1.Size = new System.Drawing.Size(232, 438);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            this.treeView1.Click += new System.EventHandler(this.treeView1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmnuAddNode,
            this.cmnuRemoveNode});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(151, 48);
            // 
            // cmnuAddNode
            // 
            this.cmnuAddNode.Name = "cmnuAddNode";
            this.cmnuAddNode.Size = new System.Drawing.Size(150, 22);
            this.cmnuAddNode.Text = "Add Node";
            this.cmnuAddNode.Click += new System.EventHandler(this.cmnuAddNode_Click);
            // 
            // cmnuRemoveNode
            // 
            this.cmnuRemoveNode.Name = "cmnuRemoveNode";
            this.cmnuRemoveNode.Size = new System.Drawing.Size(150, 22);
            this.cmnuRemoveNode.Text = "Remove Node";
            this.cmnuRemoveNode.Click += new System.EventHandler(this.cmnuRemoveNode_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnNodeTagSearch);
            this.groupBox1.Controls.Add(this.txtTagSearch);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(17, 324);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(429, 79);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Node Search (By Tag)";
            // 
            // btnNodeTagSearch
            // 
            this.btnNodeTagSearch.Location = new System.Drawing.Point(266, 51);
            this.btnNodeTagSearch.Name = "btnNodeTagSearch";
            this.btnNodeTagSearch.Size = new System.Drawing.Size(87, 21);
            this.btnNodeTagSearch.TabIndex = 7;
            this.btnNodeTagSearch.Text = "Find";
            this.btnNodeTagSearch.UseVisualStyleBackColor = true;
            this.btnNodeTagSearch.Click += new System.EventHandler(this.btnNodeTagSearch_Click);
            // 
            // txtTagSearch
            // 
            this.txtTagSearch.Location = new System.Drawing.Point(113, 26);
            this.txtTagSearch.Name = "txtTagSearch";
            this.txtTagSearch.Size = new System.Drawing.Size(241, 21);
            this.txtTagSearch.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(75, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tag:";
            // 
            // gbxSearchByText
            // 
            this.gbxSearchByText.Controls.Add(this.btnNodeTextSearch);
            this.gbxSearchByText.Controls.Add(this.txtNodeTextSearch);
            this.gbxSearchByText.Controls.Add(this.label3);
            this.gbxSearchByText.Location = new System.Drawing.Point(17, 236);
            this.gbxSearchByText.Name = "gbxSearchByText";
            this.gbxSearchByText.Size = new System.Drawing.Size(429, 82);
            this.gbxSearchByText.TabIndex = 2;
            this.gbxSearchByText.TabStop = false;
            this.gbxSearchByText.Text = "Node Search (By Text)";
            // 
            // btnNodeTextSearch
            // 
            this.btnNodeTextSearch.Location = new System.Drawing.Point(266, 51);
            this.btnNodeTextSearch.Name = "btnNodeTextSearch";
            this.btnNodeTextSearch.Size = new System.Drawing.Size(87, 21);
            this.btnNodeTextSearch.TabIndex = 7;
            this.btnNodeTextSearch.Text = "Find";
            this.btnNodeTextSearch.UseVisualStyleBackColor = true;
            this.btnNodeTextSearch.Click += new System.EventHandler(this.btnNodeTextSearch_Click);
            // 
            // txtNodeTextSearch
            // 
            this.txtNodeTextSearch.Location = new System.Drawing.Point(113, 26);
            this.txtNodeTextSearch.Name = "txtNodeTextSearch";
            this.txtNodeTextSearch.Size = new System.Drawing.Size(241, 21);
            this.txtNodeTextSearch.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "Text:";
            // 
            // gbxNodeSearch
            // 
            this.gbxNodeSearch.Controls.Add(this.btnFindNode);
            this.gbxNodeSearch.Controls.Add(this.txtNodeSearch);
            this.gbxNodeSearch.Controls.Add(this.label5);
            this.gbxNodeSearch.Location = new System.Drawing.Point(17, 149);
            this.gbxNodeSearch.Name = "gbxNodeSearch";
            this.gbxNodeSearch.Size = new System.Drawing.Size(429, 82);
            this.gbxNodeSearch.TabIndex = 1;
            this.gbxNodeSearch.TabStop = false;
            this.gbxNodeSearch.Text = "Node Search (By Name)";
            // 
            // btnFindNode
            // 
            this.btnFindNode.Location = new System.Drawing.Point(266, 51);
            this.btnFindNode.Name = "btnFindNode";
            this.btnFindNode.Size = new System.Drawing.Size(87, 21);
            this.btnFindNode.TabIndex = 7;
            this.btnFindNode.Text = "Find";
            this.btnFindNode.UseVisualStyleBackColor = true;
            this.btnFindNode.Click += new System.EventHandler(this.btnFindNode_Click);
            // 
            // txtNodeSearch
            // 
            this.txtNodeSearch.Location = new System.Drawing.Point(113, 26);
            this.txtNodeSearch.Name = "txtNodeSearch";
            this.txtNodeSearch.Size = new System.Drawing.Size(241, 21);
            this.txtNodeSearch.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(66, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 12);
            this.label5.TabIndex = 5;
            this.label5.Text = "Name:";
            // 
            // gbxNodeInfo
            // 
            this.gbxNodeInfo.Controls.Add(this.txtTag);
            this.gbxNodeInfo.Controls.Add(this.txtText);
            this.gbxNodeInfo.Controls.Add(this.label6);
            this.gbxNodeInfo.Controls.Add(this.label7);
            this.gbxNodeInfo.Controls.Add(this.txtParentName);
            this.gbxNodeInfo.Controls.Add(this.txtName);
            this.gbxNodeInfo.Controls.Add(this.label2);
            this.gbxNodeInfo.Controls.Add(this.label1);
            this.gbxNodeInfo.Location = new System.Drawing.Point(17, 21);
            this.gbxNodeInfo.Name = "gbxNodeInfo";
            this.gbxNodeInfo.Size = new System.Drawing.Size(429, 122);
            this.gbxNodeInfo.TabIndex = 0;
            this.gbxNodeInfo.TabStop = false;
            this.gbxNodeInfo.Text = "선택된 노드 정보";
            // 
            // txtTag
            // 
            this.txtTag.Location = new System.Drawing.Point(113, 96);
            this.txtTag.Name = "txtTag";
            this.txtTag.Size = new System.Drawing.Size(275, 21);
            this.txtTag.TabIndex = 9;
            // 
            // txtText
            // 
            this.txtText.Location = new System.Drawing.Point(113, 71);
            this.txtText.Name = "txtText";
            this.txtText.Size = new System.Drawing.Size(275, 21);
            this.txtText.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(77, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 12);
            this.label6.TabIndex = 7;
            this.label6.Text = "Tag:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(75, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 12);
            this.label7.TabIndex = 6;
            this.label7.Text = "Text:";
            // 
            // txtParentName
            // 
            this.txtParentName.Location = new System.Drawing.Point(113, 47);
            this.txtParentName.Name = "txtParentName";
            this.txtParentName.Size = new System.Drawing.Size(275, 21);
            this.txtParentName.TabIndex = 5;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(113, 22);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(275, 21);
            this.txtName.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "Parent Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 438);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "TreeNode Test";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbxSearchByText.ResumeLayout(false);
            this.gbxSearchByText.PerformLayout();
            this.gbxNodeSearch.ResumeLayout(false);
            this.gbxNodeSearch.PerformLayout();
            this.gbxNodeInfo.ResumeLayout(false);
            this.gbxNodeInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.GroupBox gbxNodeSearch;
        private System.Windows.Forms.GroupBox gbxNodeInfo;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cmnuAddNode;
        private System.Windows.Forms.ToolStripMenuItem cmnuRemoveNode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNodeSearch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtParentName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnFindNode;
        private System.Windows.Forms.GroupBox gbxSearchByText;
        private System.Windows.Forms.Button btnNodeTextSearch;
        private System.Windows.Forms.TextBox txtNodeTextSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnNodeTagSearch;
        private System.Windows.Forms.TextBox txtTagSearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTag;
        private System.Windows.Forms.TextBox txtText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

