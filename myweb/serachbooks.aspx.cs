using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class serachbooks : System.Web.UI.Page
{
    string connStr = "initial catalog=xiaobai; data source=localhost; integrated security=sspi";

    protected void Page_Load(object sender, EventArgs e)
    {
        
        
            gridviewbind();
        
    }

    private void gridviewbind()
    {
        SqlConnection myConn = new SqlConnection(connStr);
        SqlDataAdapter myDa = new SqlDataAdapter("select * from t_book", myConn);
        myConn.Open();
        DataSet myDataSet = new DataSet();
        myDa.Fill(myDataSet);
        GridView1.DataSource = myDataSet.Tables[0];
        GridView1.DataBind();
        myConn.Close();
    }

    protected void procedure_Click(object sender, EventArgs e)
    {
        SqlConnection myConn = new SqlConnection(connStr);

    ​    SqlCommand myCommand = new SqlCommand("searchBook", myConn);
​
        myCommand.CommandType = CommandType.StoredProcedure;
​    
        myCommand.Parameters.Add("@price", SqlDbType.Float);


    ​    myCommand.Parameters["@price"].Value = float.Parse(Price.Text);

    ​    myCommand.Parameters["@price"].Direction = ParameterDirection.Input;

    ​    //myCommand.Parameters.Add("@rowcount", SqlDbType.Int);

    ​    //myCommand.Parameters["@rowcount"].Direction = ParameterDirection.Output;

    ​    myConn.Open();

    ​    SqlDataAdapter myDa = new SqlDataAdapter();

    ​    myDa.SelectCommand = myCommand;

    ​    DataSet myDataSet = new DataSet();

    ​    myDa.Fill(myDataSet);

    ​    GridView1.DataSource = myDataSet.Tables[0];

    ​    GridView1.DataBind();
            ​    
        myCommand .ExecuteNonQuery();

    ​    //Response.Write("查到" + myCommand.Parameters["@rowcount"].Value.ToString ()  + "条记录");

    ​    myConn.Close();
    }
    /// <summary>
    /// 翻页功能
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        //Response.Redirect(Request.Url.ToString());
        GridView1.PageIndex = e.NewPageIndex;
        gridviewbind();

    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}