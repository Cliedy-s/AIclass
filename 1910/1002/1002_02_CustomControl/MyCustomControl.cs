using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1002_02_CustomControl
{
    public enum TextTypes { Key, Required, Common }
    public partial class MyCustomControl : TextBox
    {
        private TextTypes type = TextTypes.Common;
        private Color keyColor = Color.Red;
        private Color requiredColor = Color.Yellow;
        private Color commonColor = SystemColors.Window;
        public TextTypes Types
        {
            get => type;
            set
            {
                type = value;
                Color color = Color.Red;
                switch (type)
                {
                    case TextTypes.Key:
                        this.BackColor = KeyColor;
                        break;
                    case TextTypes.Required:
                        this.BackColor = RequiredColor;
                        break;
                    case TextTypes.Common:
                        this.BackColor = CommonColor;
                        break;
                    default:
                        this.BackColor = SystemColors.Window;
                        break;
                }
            }
        }

        public Color KeyColor { get => keyColor; set { keyColor = value; if (type == TextTypes.Key) this.BackColor = KeyColor; } }
        public Color RequiredColor { get => requiredColor; set { requiredColor = value; if (type == TextTypes.Required) this.BackColor = RequiredColor; } }
        public Color CommonColor { get => commonColor; set { commonColor = value; if (type == TextTypes.Common) this.BackColor = CommonColor; } }

        private Dictionary<string, Color> dicTypeColors = new Dictionary<string, Color>();
        //private void GetColors(Dictionary<string, Color> dic)
        //{
        //    string[] strs;
        //    Color color;
        //    strs = ConfigurationManager.AppSettings["KeyColor"].Split(',');
        //    color = Color.FromArgb(int.Parse(strs[0]), int.Parse(strs[1]), int.Parse(strs[2]));
        //    dic.Add("KeyColor", color);
        //    strs = ConfigurationManager.AppSettings["RequireColor"].Split(',');
        //    color = Color.FromArgb(int.Parse(strs[0]), int.Parse(strs[1]), int.Parse(strs[2]));
        //    dic.Add("RequireColor", color);
        //    strs = ConfigurationManager.AppSettings["CommonColor"].Split(',');
        //    color = Color.FromArgb(int.Parse(strs[0]), int.Parse(strs[1]), int.Parse(strs[2]));
        //    dic.Add("CommonColor", color);
        //}

        public MyCustomControl()
        {
            // AppSettings를 여기서 못쓰는 이유 : AppSettings를 실행시에 갖고옴
            // 이 위치는 디자인시
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }

    }
}
