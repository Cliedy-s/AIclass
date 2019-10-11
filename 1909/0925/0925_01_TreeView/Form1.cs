using System;
using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _0925_01_TreeView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            TreeNode mainNode = new TreeNode();
            mainNode.Name = "dept";
            mainNode.Text = "부서명";
            this.treeView1.Nodes.Add(mainNode);
        }

        #region Add and Remove Nodes
        private void cmnuAddNode_Click(object sender, EventArgs e)
        {
            NewNode n = new NewNode();
            if (n.ShowDialog() == DialogResult.OK)
            {
                TreeNode nod = new TreeNode();
                nod.Name = n.NewNodeName;
                nod.Text = n.NewNodeText;
                nod.Tag = n.NewNodeTag;
                n.Close();

                treeView1.SelectedNode.Nodes.Add(nod);
                treeView1.SelectedNode.ExpandAll(); // 선택된 노드 다 펼치기
            }
        }

        private void cmnuRemoveNode_Click(object sender, EventArgs e)
        {
            treeView1.SelectedNode.Remove();
        }
        #endregion



        #region Treeview Event Handlers
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            try
            {
                // 수정페이지의 텍스트가 null값이면.. => error
                // 텍스트박스에 정보가 남아있고 다른 부분에만 정보를 넣을 수 도 있음.
                txtName.Text = "";
                txtParentName.Text = "";
                txtText.Text = "";
                txtTag.Text = "";

                txtName.Text = treeView1.SelectedNode.Name;
                txtText.Text = treeView1.SelectedNode.Text;
                txtTag.Text = treeView1.SelectedNode.Tag.ToString();
                txtParentName.Text = treeView1.SelectedNode.Parent.Text;
            }
            catch { }
        }

        private void treeView1_Click(object sender, EventArgs e)
        {
            ClearBackColor();
        }

        #endregion



        #region Find By Name

        private void btnFindNode_Click(object sender, EventArgs e)
        {
            ClearBackColor();

            try
            {
                TreeNode[] tn = treeView1.Nodes[0].Nodes.Find(txtNodeSearch.Text, true); // true : 모두 찾기, false : 하나만 찾기
                for (int i = 0; i < tn.Length; i++)
                {
                    treeView1.SelectedNode = tn[i];
                    treeView1.SelectedNode.BackColor = Color.Yellow;
                }
            }
            catch { }
        }

        #endregion



        #region Remove BackColor
        /// <summary>
        /// 전체 노드 배경색 변경
        /// </summary>
        private void ClearBackColor()
        {
            foreach (TreeNode n in treeView1.Nodes) // 루트노드 갖고오기
            {
                ClearRecursive(n);
            }
        }

        /// <summary>
        /// 재귀 호출
        /// </summary>
        /// <param name="treeNode"></param>
        private void ClearRecursive(TreeNode treeNode) // 1레벨 노드
        {
            foreach (TreeNode tn in treeNode.Nodes)
            {
                tn.BackColor = Color.White;
                ClearRecursive(tn); // 1레벨 ->2레벨 노드, 2레벨 ->3레벨 노드
            }
        }

        #endregion



        #region Find By Text
        private void btnNodeTextSearch_Click(object sender, EventArgs e)
        {
            ClearBackColor();
            FindByText();
        }

        private void FindByText()
        {
            TreeNodeCollection nodes = treeView1.Nodes;
            foreach (TreeNode n in nodes)
            {
                FindRecursive(n);
            }
        }


        private void FindRecursive(TreeNode treeNode)
        {
            foreach (TreeNode tn in treeNode.Nodes)
            {
                if (tn.Text == this.txtNodeTextSearch.Text)
                    tn.BackColor = Color.Yellow;

                FindRecursive(tn);
            }
        }

        #endregion



        #region Find By Tag
        private void btnNodeTagSearch_Click(object sender, EventArgs e)
        {
            ClearBackColor();
            FindByTag();
        }


        private void FindByTag()
        {
            TreeNodeCollection nodes = treeView1.Nodes;
            foreach (TreeNode n in nodes)
            {
                FindRecursiveTag(n);
            }
        }


        private void FindRecursiveTag(TreeNode treeNode)
        {
            foreach (TreeNode tn in treeNode.Nodes)
            {
                if (tn.Tag.ToString() == this.txtTagSearch.Text)
                    tn.BackColor = Color.Yellow;

                FindRecursiveTag(tn);
            }
        }




        #endregion
    }
}