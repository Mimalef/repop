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

public partial class PersonnelAddEquip : BasePage
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void ButtonAdd_Click(object sender, EventArgs e)
    {
        string sql = @"
            INSERT INTO equipments (
                type,
                brand,
                model,
                status,
                customer)
            VALUES (
                N'{0}',
                N'{1}',
                N'{2}',
                N'{3}',
                {4})";

        sql = string.Format(
            sql,
            DropDownListType.Text,
            DropDownListBrand.Text,
            TextBoxModel.Text,
            DropDownListStatus.Text,
            TextBoxCustomer.Text);

        insertQuery(sql);
        showSuccess("عملیات با موفقیت انجام شد.");
    }
}
