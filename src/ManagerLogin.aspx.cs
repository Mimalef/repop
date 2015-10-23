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

public partial class ManagerLogin : BasePage
{
    protected void ButtonLogin_Click(object sender, EventArgs e)
    {
        string sql = @"
            SELECT
                id
            FROM
                managers
            WHERE
                username = '{0}'
            AND
                password = '{1}'";

        sql = string.Format(
            sql,
            TextBoxUsername.Text,
            TextBoxPassword.Text);

        DataTable table = selectQuery(sql);

        if (table.Rows.Count > 0)
        {
            Session["manager"] = table.Rows[0]["id"];
            Response.Redirect("~/ManagerPanel.aspx");
        }
    }
}
