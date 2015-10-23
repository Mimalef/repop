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

public partial class ManagerAddPersonnel : BasePage
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void ButtonAdd_Click(object sender, EventArgs e)
    {
        string sql = @"
            INSERT INTO personnels (
                first_name,
                last_name,
                telephone,
                username,
                password)
            VALUES (
                N'{0}',
                N'{1}',
                {2},
                N'{3}',
                N'{4}')";

        sql = string.Format(
            sql,
            TextBoxFirsName.Text,
            TextBoxLastName.Text,
            TextBoxTelephone.Text,
            TextBoxUsername.Text,
            TextBoxPassword.Text);

        insertQuery(sql);
        showSuccess("عملیات با موفقیت انجام شد.");
    }
}
