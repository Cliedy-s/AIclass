using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1001_03_CustomControl
{
    public partial class FIleFinderUserControl : UserControl
    {
        string fileName = string.Empty;

        //[Browsable(true)]
        //[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        //[EditorBrowsable(EditorBrowsableState.Always)]
        public string FileName { get => fileName; }

        public FIleFinderUserControl()
        {
            InitializeComponent();
        }


        public event EventHandler FileSelected; // 이벤트 등록
        private void BtnFileName_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.RestoreDirectory = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtFileName.Text = openFileDialog.FileName;
                fileName = openFileDialog.FileName;

                //if(FileFinderDelegate != null)
                //{
                //    FileFinderDelegate(this, new FileFinderEventArgs(e));
                //}
                FileSelected?.Invoke(this, new FileFinderEventArgs(e));
            }
        }
    }
    public class FileFinderEventArgs : EventArgs
    {
        public FileFinderEventArgs(EventArgs e)
        {

        }

    }
}
