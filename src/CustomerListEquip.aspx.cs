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

public partial class CustomerListEquip : BasePage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string sql = @"
            SELECT
                id,
                type,
                brand,
                model,
                status,
                customer
            FROM
                equipments
            WHERE
                customer = '{0}'";

        sql = string.Format(
            sql,
            Session["customer"]);

        fillTable(sql, ref TableEquipments);
    }
}
