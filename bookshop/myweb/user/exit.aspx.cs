using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using YF;

public partial class user_exit : System.Web.UI.Page
{
    /// <summary>
    /// 此页面不需要前台
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void Page_Load(object sender, EventArgs e)
    {
        //当前保存对象清空
        YF.SessionHelper.SetSession("user", null);//把刚刚保存对象的对象赋空就可
        YF.JsHelper.Redirect("/myweb/login.aspx");
    }
}