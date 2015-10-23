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

public partial class PublicSuccess : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["message"] != null)
        {
            LinkButtonReturn.PostBackUrl = Request.QueryString["redirect"];
            LabelMessage.Text = Request.QueryString["message"];
        }
        else
        {
            LinkButtonReturn.PostBackUrl = "~/Default.aspx";
            LabelMessage.Text = "خطا";
        }
    }
}
