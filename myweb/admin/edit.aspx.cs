using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class edit : System.Web.UI.Page
{
    /// <summary>
    /// when user click 'edit' button, the page will be loaded 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void Page_Load(object sender, EventArgs e)
    {
        // IsPostBack 使得返回管理界面时数据已经刷新
        if (!IsPostBack)
        {
            string id = Request.QueryString["id"];
            // get user's all properties and data 
            YF.Model.User user = YF.BLL.User.Getuser(int.Parse(id));
            this.username.Text = user.Username;
            this.password.Text = user.Password;
            this.name.Text = user.Name;
            this.address.Text = user.Address;
            this.sex.Text = user.Sex.ToString();
            this.mobile.Text = user.Mobile;
            this.email.Text = user.Email;
            this.qq.Text = user.Qq;
            this.id.Value = user.Id.ToString();
            this.role.Text = user.Role.ToString();
        }            
    }
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
        user.Id = int.Parse(this.id.Value);
        user.Role = this.role.Text;
        // when edit successfully
        if (YF.BLL.User.updateData(user) == true)
        {
            YF.JsHelper.AlertAndRedirect("edit successfully!", "index.aspx");
        }
        else
        {
            YF.JsHelper.AlertAndRedirect("fail to edit!", "index.aspx");
        }
    }
}