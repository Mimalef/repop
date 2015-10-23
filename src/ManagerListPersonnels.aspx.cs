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

public partial class ManagerListPersonnel : BasePage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string sql = @"
            SELECT
                id,
                first_name,
                last_name,
                telephone,
                username,
                password
            FROM
                personnels";

        sql = string.Format(sql);

        fillTable(sql, ref TablePersonnels);
    }
}
