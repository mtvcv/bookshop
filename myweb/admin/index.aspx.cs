using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class index : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        //YF.JsHelper.AlertAndRedirect("welcome to kun's bookshop", "bookShop.aspx");
        //Response.Redirect("bookShop.aspx");
        Server.Transfer("bookshop.aspx");
    }
}