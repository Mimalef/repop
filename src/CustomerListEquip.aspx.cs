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
            SELECT * 
            FROM equipments 
            WHERE customer = '{0}'";

        sql = string.Format(
            sql,
            Session["customer"]);

        DataTable table = doQuery(sql);

        foreach(DataRow row in table.Rows)
        {
            TableRow trow = new TableRow();

            for (int i = 0; i < table.Columns.Count; i++)
            {
                if (table.Columns[i].ColumnName == "customer") continue;
                if (table.Columns[i].ColumnName == "id") continue;
                
                TableCell cell = new TableCell();

                cell.Text = row[i].ToString();
                
                trow.Cells.Add(cell);
            }

            TableEquipments.Rows.Add(trow);
        }
    }
}
