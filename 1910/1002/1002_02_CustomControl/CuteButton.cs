using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1002_02_CustomControl
{
    public partial class CuteButton : Button
    {
        Color cuteColor1 = Color.LightGreen;
        Color cuteColor2 = Color.DarkBlue;
        int cuteColor1Transparent = 100;
        int cuteColor2Transparent = 100;
        public CuteButton()
        {
            InitializeComponent();
        }

        public Color CuteColor1 { get => cuteColor1; set
            {
                cuteColor1 = value;
                this.Invalidate();
            }
        }
        public Color CuteColor2 { get => cuteColor2; set
            {
                cuteColor2 = value;
                this.Invalidate();
            }
        }

        public int CuteColor1Transparent
        {
            get => cuteColor1Transparent;
            set {
                cuteColor1Transparent = value;
                this.Invalidate();
            }
        }
        public int CuteColor2Transparent { get => cuteColor2Transparent;
            set {
                cuteColor2Transparent = value;
                this.Invalidate();
            }
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            Color c1 = Color.FromArgb(CuteColor1Transparent, CuteColor1);
            Color c2 = Color.FromArgb(CuteColor2Transparent, CuteColor2);

            Brush brush = new System.Drawing.Drawing2D.LinearGradientBrush(ClientRectangle, c1, c2, 10);

            pe.Graphics.FillRectangle(brush, ClientRectangle);
            brush.Dispose();
        }
    }
}
