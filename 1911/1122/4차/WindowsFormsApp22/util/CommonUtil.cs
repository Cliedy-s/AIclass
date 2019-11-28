using NorthWindVO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp22.util
{
    public class CommonUtil
    {
        public static void ComboBinding(ComboBox combo, List<ComboItemVO> list)
        {
            list.Insert(0, new ComboItemVO());
            combo.DataSource = list;
            combo.DisplayMember = "Text";
            combo.ValueMember = "Code";
        }
    }
}
