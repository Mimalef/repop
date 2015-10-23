using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Data.SqlClient;

public class BasePage : System.Web.UI.Page
{
    private string connectionString = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
    private string currentUrl = HttpContext.Current.Request.Url.AbsolutePath;

    private void sqlError()
    {
        Response.Cookies["error_message"].Value = "خطای پایگاه داده.";
        Response.Cookies["error_redirect"].Value = this.currentUrl;
        Response.Redirect("PublicError.aspx");
    }

    public void insertQuery(string sql)
    {
        SqlConnection cnn;
        SqlCommand cmd;

        cnn = new SqlConnection(this.connectionString);

        try
        {    
            cnn.Open();

            cmd = new SqlCommand(sql, cnn);
            cmd.ExecuteNonQuery();
        }
        catch
        {
            sqlError();
        }
        finally
        {
            cnn.Close();
        }
    }

    public DataTable selectQuery(string sql)
    {
        DataTable table = new DataTable();
        SqlDataAdapter adpr;
        SqlConnection cnn;
        SqlCommand cmd;

        cnn = new SqlConnection(this.connectionString);

        try
        {
            cnn.Open();

            cmd = new SqlCommand(sql, cnn);
            adpr = new SqlDataAdapter(cmd);
            adpr.Fill(table);
        }
        catch
        {
            sqlError();
        }
        finally
        {
            cnn.Close();
        }

        return table;
    }

    public void fillTable(string sql, ref Table table)
    {
        DataTable dataTable = selectQuery(sql);
        
        foreach (DataRow row in dataTable.Rows)
        {
            TableRow trow = new TableRow();

            for (int i = 0; i < dataTable.Columns.Count; i++)
            {
                TableCell cell = new TableCell();

                cell.Text = row[i].ToString();

                trow.Cells.Add(cell);
            }

            if (table.ID == "TableEquip")
            {
                TableCell cell = new TableCell();
                LinkButton edit = new LinkButton();
                
                edit.PostBackUrl = "~/PersonnelEditEquip.aspx?equip=";
                edit.PostBackUrl += row["id"].ToString();
                edit.Text = "ویرایش";

                cell.Controls.Add(edit);
                trow.Cells.Add(cell);
            }

            table.Rows.Add(trow);
        }
    }
}
