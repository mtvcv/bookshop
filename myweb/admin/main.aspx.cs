using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_main : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        YF.Model.User myuser = new YF.Model.User();

        myuser = (YF.Model.User)YF.SessionHelper.GetSesstion("user"); // 读取我们在login.aspx.cs刚刚保存的值 

        if (myuser.Role == "shop")
            YF.JsHelper.Alert("Permissions enough!");
        else
            YF.JsHelper.AlertAndRedirect("Insufficient permissions!", "/myweb/bookShop.aspx");
        //Response.Redirect("");
        // 判断商家登陆的话，直接跳转到管理界面，否则跳转到书店主业
    }
}