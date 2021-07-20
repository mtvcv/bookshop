using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class user_cartadd : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //向后台数据库加入记录，点击购买，购物车加
        YF.Model.User myuser = new YF.Model.User();
        myuser = (YF.Model.User)YF.SessionHelper.GetSesstion("user");//读取当前用户信息  //强制转为用户实体类型
        if (myuser != null)
        {
            YF.Model.Cart cart = new YF.Model.Cart(); // 声明空的购物车对象，然后要对购物车对象进行赋值
            // 通过id来查询
            int id = int.Parse(Request.QueryString["id"].ToString());

            YF.Model.Books books = YF.BLL.Books.GetBooks(id); // 通过我们传过来的商品id，找到商品实体

            cart.Books = books;
            cart.User = myuser;
            cart.Num = 1;
            cart.State = 0; // 0 代表还没有下单，只是加购物车
            cart.Adddate = DateTime.Now;
            
            // 当图书数量为0时，退出，重新选购
            if (books.Num <= 0)
            {
                YF.JsHelper.AlertAndRedirect("fail to add cart! Connect with shop!", "/myweb/bookshop.aspx");//库存为0，添加失败返回图书详情页面
            }

            if (YF.BLL.Cart.list(books.Id, myuser.Id, 0).Count > 0) // 当不是第一次插入的时候，只是更新数量就可以
            {
                YF.BLL.Cart.updatenum(books.Id, myuser.Id, 0);//修改数量
                YF.JsHelper.AlertAndRedirect("add cart successfully!!!", "/myweb/user/cart.aspx");//3，添加成功返回购物车页面
            }
            else // 第一次插入
            {
                if (YF.BLL.Cart.addbooks(cart))
                {

                    YF.JsHelper.AlertAndRedirect("add cart successfully!!!", "/myweb/user/cart.aspx");
                }
                else
                {
                    YF.JsHelper.AlertAndRedirect("fail to add cart successfully!!!", "/myweb/books.aspx");
                }
            }
            
        }
        else
        {
            YF.JsHelper.AlertAndRedirect("no member!please login in!!!", "/myweb/login.aspx");
        }

    }
}