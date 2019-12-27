using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _1223_01_WebForm
{
    public partial class WebForm1 : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                TextBox1.Text = "이름을 입력해주세요";
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            this.Label1.Text = "UserName";
            this.myspan.InnerText = "";
            this.textinput.Value = "";
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}