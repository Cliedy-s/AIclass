using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0920_02_MyNotePad
{
    public partial class Form2 : Form
    {
        bool dirty = false;
        string editingFileName = string.Empty;
        string notDirthCaptionFormat = "{0} - Windows 메모장";
        string dirthCaptionFormat = "*{0} - Windows 메모장";

        public Form2()
        {
            InitializeComponent();
        }

        private void 새로만들기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("새로만들기 클릭");
            txtArea.Clear();
            dirty = false;
            editingFileName = string.Empty;
            UpdateFormText();
        }

        private void 열기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("열기 클릭");
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                editingFileName = openFileDialog1.FileName;

                this.txtArea.TextChanged -= new System.EventHandler(this.TxtArea_TextChanged);

                try
                {
                    StreamReader sr = new StreamReader(editingFileName, Encoding.Default);
                    txtArea.Text = sr.ReadToEnd();
                    sr.Close();

                    dirty = false;
                    UpdateFormText();
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }
                finally
                {
                    this.txtArea.TextChanged += new System.EventHandler(this.TxtArea_TextChanged);
                }
            }
        }

        private void 저장ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("저장 클릭");
            if (editingFileName.Length < 1)
            {
                SaveAs();
            }
            else
            {
                FileStream fs = null;
                try
                {
                    if (File.Exists(editingFileName))
                    {
                        fs = new FileStream(editingFileName, FileMode.Open);
                    }
                    else
                    {
                        fs = new FileStream(editingFileName, FileMode.Create);
                    }
                    fs.Close();
                    StreamWriter sw = new StreamWriter(editingFileName, false, Encoding.Default);
                    sw.Write(txtArea.Text);
                    sw.Close();
                }
                finally
                {
                    dirty = false;
                    UpdateFormText();
                }
            }
        }

        private void 다른이름으로저장ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("다른이름으로저장 클릭");
            SaveAs();
        }

        private void SaveAs()
        {
            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;
            DialogResult dr = saveFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                editingFileName = saveFileDialog1.FileName;

                FileStream fs = new FileStream(editingFileName, FileMode.Create, FileAccess.ReadWrite, FileShare.None);
                StreamWriter sw = new StreamWriter(fs);
                
                sw.Write(txtArea.Text);
                sw.Close();
                fs.Close();

                dirty = false;
                UpdateFormText();
            }
        }

        private void TxtArea_TextChanged(object sender, EventArgs e)
        {
            if (!dirty)
            {
                dirty = true;
                UpdateFormText();
            }
        }

        private void UpdateFormText()
        {
            string filename = string.Empty;
            if (editingFileName.Length > 1)
            {
                filename = editingFileName.Substring(editingFileName.LastIndexOf("\\") + 1);
            }
            else
            {
                filename = "제목없음";
            }

            if (dirty)
            {
                this.Text = string.Format(dirthCaptionFormat, filename);
            }
            else
            {
                this.Text = string.Format(notDirthCaptionFormat, filename);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            새로만들기ToolStripMenuItem.PerformClick();
        }
    }
}
