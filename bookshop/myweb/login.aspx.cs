using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string username = this.username.Text, password = this.password.Text, role = this.role.Text;
        if (YF.BLL.User.loginSearch(username, password, role) == true)
        {
            YF.Model.User user = YF.BLL.User.GetUserbyname(username); //通过username 查询 返回一个实体对象user
            YF.SessionHelper.SetSession("user", user);//记住对象，保存当前用户登录身份信息
            YF.JsHelper.AlertAndRedirect("login successfully!!!", "user/member.aspx");            
            //YF.JsHelper.AlertAndRedirect("login successfully!!!", "user/member.aspx");
        }
        else
        {            
            YF.JsHelper.AlertAndRedirect("warning!!!fail to login!", "login.aspx");
        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("register.aspx");
    }
}