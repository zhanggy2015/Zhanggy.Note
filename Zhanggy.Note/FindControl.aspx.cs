using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Zhanggy.Note
{
    public partial class FindControl : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            foreach (System.Web.UI.Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    TextBox tb = (TextBox)control;
                    tb.Text = String.Empty;
                }
            }
        }
    }
}
