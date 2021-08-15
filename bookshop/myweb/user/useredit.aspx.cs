using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using YF;

public partial class user_useredit : System.Web.UI.Page
{   
    /// <summary>
    /// when user click 'edit' button, the page will be loaded 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)//刷新页面
        {
            //保存了用户信息，将信息拿过来
            YF.Model.User myuser = new YF.Model.User();//声明空对象
            myuser = (YF.Model.User)YF.SessionHelper.GetSesstion("user");//读取 强制转换类型
            //将信息赋值
            this.username.Text = myuser.Username;
            this.password.Text = myuser.Password;
            this.name.Text = myuser.Name;
            this.address.Text = myuser.Address;
            this.sex.Text = myuser.Sex.ToString();
            this.mobile.Text = myuser.Mobile;
            this.email.Text = myuser.Email;
            this.qq.Text = myuser.Qq;
            this.role.Text = myuser.Role.ToString();
        }
    }
    /// <summary>
    /// 把数据传回数据库
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void Button1_Click(object sender, EventArgs e)
    {
       //保存
        //当前登录对象
        YF.Model.User user = new YF.Model.User();
        user = (YF.Model.User)YF.SessionHelper.GetSesstion("user");//读取   //强制转
        //新的数据重新赋值赋值
        user.Password = this.password.Text;
        user.Name = this.name.Text;
        user.Address = this.address.Text;
        user.Sex = int.Parse(this.sex.Text);
        user.Mobile = this.mobile.Text;
        user.Email = this.email.Text;
        user.Qq = this.qq.Text;
        //调后台方法更新
        if (YF.BLL.User.updateData(user))
        {
            YF.JsHelper.AlertAndRedirect("用户信息修改成功", "/myweb/login.aspx");

        }
        else
        {
            YF.JsHelper.AlertAndRedirect("用户信息修改失败", "useredit.aspx");
        }
    }
}