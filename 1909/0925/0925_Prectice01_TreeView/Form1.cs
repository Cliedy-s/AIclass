using System;
using System.Drawing;
using System.Windows.Forms;

namespace _0925_Prectice01_TreeView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void AddNodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            if (DialogResult.OK == frm2.ShowDialog())
            {
                TreeNode tree = new TreeNode();
                tree.Name = frm2.NameText;
                tree.Text = frm2.TextText;
                tree.Tag = frm2.TegText;
                treeView1.SelectedNode.Nodes.Add(tree);
            }
        }

        private void RemoveNodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            treeView1.SelectedNode.Remove();
        }

        private void Button1_Click(object sender, EventArgs e)
        { // find by Name
            ColorToWhite(treeView1.Nodes[0]);
            TreeNode[] treenodes = treeView1.Nodes[0].Nodes.Find(textBox5.Text, true);
            foreach (TreeNode treeNode in treenodes)
            {
                treeNode.BackColor = Color.Yellow;
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        { // find by Text
            ColorToWhite(treeView1.Nodes[0]);
            foreach (TreeNode item in treeView1.Nodes)
            {
                FindDestinationText(item);
            }
        }
        private void FindDestinationText(TreeNode parentnode)
        {
            foreach (TreeNode node in parentnode.Nodes)
            {
                if (node.Text == textBox6.Text) node.BackColor = Color.Yellow;
                FindDestinationText(node);
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        { // find by Tag
            ColorToWhite(treeView1.Nodes[0]);
            foreach (TreeNode item in treeView1.Nodes)
            {
                FindDestinationTag(item);
            }

        }
        private void FindDestinationTag(TreeNode parentnode)
        {
            foreach (TreeNode node in parentnode.Nodes)
            {
                if (node.Tag.ToString() == textBox7.Text) node.BackColor = Color.Yellow;
                FindDestinationTag(node);
            }
        }

        private void ColorToWhite(TreeNode treenode)
        {
            foreach (TreeNode item in treenode.Nodes)
            {
                item.BackColor = Color.White;
                ColorToWhite(item);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            treeView1.Nodes.Add(new TreeNode("부서명"));
        }

        private void TreeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            try
            {
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";

                textBox1.Text = treeView1.SelectedNode.Name;
                textBox2.Text = treeView1.SelectedNode.Parent.Name;
                textBox3.Text = treeView1.SelectedNode.Text; 
                textBox4.Text = treeView1.SelectedNode.Tag.ToString();

            }
            catch { }
        }
    }
}
