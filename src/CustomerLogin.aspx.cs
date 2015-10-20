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
using System.Data.SqlClient;

public partial class CustomerLogin : BasePage
{
    protected void ButtonLogin_Click(object sender, EventArgs e)
    {
        string sql = @"
            SELECT * 
            FROM customers 
            WHERE username = '{0}' 
            AND password = '{1}'";

        sql = string.Format(
            sql,
            TextBoxUsername.Text, 
            TextBoxPassword.Text);

        DataTable table = doQuery(sql);

        if (table.Rows.Count > 0)
        {
            Session["customer"] = table.Rows[0]["id"];
            Response.Redirect("~/CustomerListEquip.aspx");
        }
    }
}
