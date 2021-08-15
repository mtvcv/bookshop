using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class admin_ordermanage : System.Web.UI.Page
{
    string connStr = "initial catalog=xiaobai; data source=localhost; integrated security=sspi";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)       //第一次请求时加载
        {
            gridviewbind();
        }

    }
    private void gridviewbind()
    {
        SqlConnection myConn = new SqlConnection(connStr);
        SqlDataAdapter myDa = new SqlDataAdapter("select * from View_1", myConn);
        myConn.Open();
        DataSet myDataSet = new DataSet();
        myDa.Fill(myDataSet);
        GridView1.DataSource = myDataSet.Tables[0];
        GridView1.DataBind();
        myConn.Close();
    }
    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView1.PageIndex = e.NewPageIndex;
        gridviewbind();
    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}