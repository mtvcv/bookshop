using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using YF;

public partial class register : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    /// <summary>
    /// 把用户类和前台
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void Button1_Click(object sender, EventArgs e)
    {
        YF.Model.User user = new YF.Model.User();
        user.Username = this.username.Text;
        user.Password = this.password.Text;
        user.Name = this.name.Text;
        user.Address = this.address.Text;
        user.Sex = int.Parse(this.sex.Text);
        user.Mobile = this.mobile.Text;
        user.Email = this.email.Text;
        user.Qq = this.qq.Text;
        user.Adddate = DateTime.Now;
        user.Role = this.role.Text;
        // when username already exists
        if (YF.BLL.User.usernameSearch(this.username.Text) == false)
        {
            YF.JsHelper.AlertAndRedirect("warning!username is already used!please change username and register again!", "register.aspx");
        }
        else
        {
            if (YF.BLL.User.add(user) == true)
            {
                YF.JsHelper.AlertAndRedirect("Congratulation!register successfully!", "login.aspx");
            }
            else
            {
                YF.JsHelper.AlertAndRedirect("warning!fail to register!", "register.aspx");
            }
        }        
    }
}