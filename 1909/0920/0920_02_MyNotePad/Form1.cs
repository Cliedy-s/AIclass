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
    public partial class Form1 : Form
    {
        string editingFileName = string.Empty;
        bool dirty = false;
        string dirthCaptionFormat = "*{0} - Windows 메모장";
        string notDirthCaptionFormat = "{0} - Windows 메모장";
        public Form1()
        {
            InitializeComponent();
            새로만들기.PerformClick();
        }

        private void 열기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.txtArea.TextChanged -= new System.EventHandler(this.TxtArea_TextChanged);
            // MessageBox.Show("열기");
            openFileDialog1.FileName = string.Empty;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                editingFileName = openFileDialog1.FileName;
                try
                {
                    StreamReader sr = new StreamReader(editingFileName, Encoding.Default);
                    txtArea.Text = sr.ReadToEnd();
                    sr.Close();

                    dirty = false;
                    UpdateFormText();
                }
                catch (Exception err) { MessageBox.Show(err.Message); }
                finally
                {
                    this.txtArea.TextChanged += new System.EventHandler(this.TxtArea_TextChanged);
                }
            }

        }

        private void whatever(object sender, EventArgs e)
        {
        }
        private void 저장ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (editingFileName.Length < 1)
            {
                saveAs();
            }
            else
            {
                FileStream fs;
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
                catch { }
                finally
                {
                    dirty = false;
                    UpdateFormText();
                }
            }
        }

        private void 다른이름으로저장ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveAs();
        }

        private void saveAs()
        {
            saveFileDialog1.Filter = "txt Files (*.txt)|*.txt|All Files(*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;
            saveFileDialog1.FileName = editingFileName.Substring(editingFileName.LastIndexOf(@"\") + 1);
            DialogResult dr = saveFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                editingFileName = saveFileDialog1.FileName;

                FileStream fs = new FileStream(editingFileName, FileMode.Create);
                fs.Close();
                StreamWriter streamWriter = new StreamWriter(editingFileName, false, Encoding.UTF8);
                streamWriter.Write(txtArea.Text);
                streamWriter.Close();

                dirty = false;
                UpdateFormText();
            }

        }
        private void 새로만들기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("새로만들기");
            txtArea.Clear();
            editingFileName = string.Empty;
            dirty = false;
            UpdateFormText();
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
                filename = "파일명"; // 파일명 주기
                filename = editingFileName.Substring(editingFileName.LastIndexOf(@"\") + 1);
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
    }
}
