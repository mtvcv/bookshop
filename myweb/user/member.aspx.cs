using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using YF;

public partial class user_member : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        YF.Model.User myuser = new YF.Model.User();

        myuser = (YF.Model.User)YF.SessionHelper.GetSesstion("user"); // 读取我们在login.aspx.cs刚刚保存的值 

        if (myuser != null)
            this.username.Text = myuser.Username;
        else
            YF.JsHelper.AlertAndRedirect("no member!please login in", "/myweb/login.aspx");
        // 判断会员登陆的话，直接跳转到会员中心，否则跳转到登陆界面
    }
}