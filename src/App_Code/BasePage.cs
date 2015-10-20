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
    public string ConnectionString = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;

    public DataTable doQuery(string sql)
    {
        DataTable table = new DataTable();
        SqlDataAdapter adpr;
        SqlConnection cnn;
        SqlCommand cmd;

        cnn = new SqlConnection(this.ConnectionString);
        cmd = new SqlCommand(sql, cnn);

        using (adpr = new SqlDataAdapter(cmd))
        {
            adpr.Fill(table);
        }

        return table;
    }
}
