using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

public partial class PublicError : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Response.Cookies["error_redirect"].Value != null)
        {
            LinkButtonReturn.PostBackUrl = Response.Cookies["error_redirect"].Value;
            LabelMessage.Text = Response.Cookies["error_message"].Value;
        }
        else
        {
            LinkButtonReturn.PostBackUrl = "~/Default.aspx";
            LabelMessage.Text = "خطا";
        }
    }
}
