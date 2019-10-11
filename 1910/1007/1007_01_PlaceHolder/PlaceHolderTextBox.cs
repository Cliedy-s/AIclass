using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CLIP.eForm.Consent.Standard.Management.UI
{
    public partial class PlaceHolderTextBox : TextBox
    {
        bool isPlaceHolder = true;
        string _placeHolderText;
        Font placeHolderTextFont = new Font(FontFamily.GenericSansSerif, 1.2f, FontStyle.Italic);
        Color placeHolderTextColor = Color.Gray;

        public string PlaceHolderText
        {
            get { return _placeHolderText; }
            set
            {
                _placeHolderText = value;
                setPlaceholder();
            }
        }

        public new string Text
        {
            get { return (isPlaceHolder) ? string.Empty : base.Text; }
            set { base.Text = value; }
        }

        private void setPlaceholder()
        {
            if (string.IsNullOrEmpty(base.Text))
            {
                base.Text = PlaceHolderText;
                this.ForeColor = placeHolderTextColor;
                this.Font = placeHolderTextFont;
                isPlaceHolder = true;
            }
        }

        //when the control is focused, the placeholder is removed
        private void removePlaceHolder()
        {

            if (isPlaceHolder)
            {
                base.Text = "";
                //this.ForeColor = System.Drawing.SystemColors.WindowText;
                //this.Font = new Font(this.Font, FontStyle.Regular);
                isPlaceHolder = false;
            }
        }

        public PlaceHolderTextBox()
        {
            GotFocus += removePlaceHolder;
            LostFocus += setPlaceholder;
        }

        private void setPlaceholder(object sender, EventArgs e)
        {
            setPlaceholder();
        }

        private void removePlaceHolder(object sender, EventArgs e)
        {
            removePlaceHolder();
        }
    }
}
