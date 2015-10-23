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

public partial class PersonnelEditEquip : BasePage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["equip"] != null)
        {
            string sql = @"
                SELECT
                    type,
                    brand,
                    model,
                    status,
                    customer
                FROM
                    equipments
                WHERE
                   id = {0}";

            sql = string.Format(
                sql,
                Request.QueryString["equip"]);

            DataTable table = selectQuery(sql);

            DropDownListType.Text = table.Rows[0]["type"].ToString();
            DropDownListBrand.Text = table.Rows[0]["brand"].ToString();
            TextBoxModel.Text = table.Rows[0]["model"].ToString();
            DropDownListStatus.Text = table.Rows[0]["status"].ToString();
            TextBoxCustomer.Text = table.Rows[0]["customer"].ToString();
        }
        else
        {
            showError("خطا در دربافت اطلاعات.");
        }
    }
    protected void ButtonEdit_Click(object sender, EventArgs e)
    {
        string sql = @"
            UPDATE
                equipments
            SET
                type = N'{0}',
                brand = N'{1}',
                model = N'{2}',
                status = N'{3}',
                customer = {4}
            WHERE
                id = {5}";

        sql = string.Format(
            sql,
            DropDownListType.Text,
            DropDownListBrand.Text,
            TextBoxModel.Text,
            DropDownListStatus.Text,
            TextBoxCustomer.Text,
            Request.QueryString["equip"]);

        insertQuery(sql);
        showSuccess("عملیات با موفقیت انجام شد.");
    }
}
