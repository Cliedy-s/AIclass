using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MachineProject
{
    static class GlobalUsage
    {


        // for recursiveForChangeControls
        static public void ChangeFont(Control control)
        {
            Font font = control.Font;
            control.Font = new Font("나눔고딕", font.Size, font.Style);
        }
    }
}
