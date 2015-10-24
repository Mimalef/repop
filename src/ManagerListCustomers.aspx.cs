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

public partial class ManagerListCustomers : BasePage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string sql = @"
            SELECT
                id AS 'کد',
                first_name AS 'نام',
                last_name AS 'فامیل',
                telephone AS 'تلفن',
                address AS 'آدرس',
                username AS 'کاربری',
                password AS 'گذرواژه'
            FROM
                customers";

        sql = string.Format(sql);

        fillTable(sql, ref TableCustomers);
    }
}
