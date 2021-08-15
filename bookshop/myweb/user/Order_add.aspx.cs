using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class user_Order_add : System.Web.UI.Page
{
    /// <summary>
    /// 当跳转到此页面时
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void Page_Load(object sender, EventArgs e)
    {
        // 声明变量 总价
        float total = 0;

        // 获取当前未下单用户的信息（通过session对象）
        YF.Model.User myuser = new YF.Model.User();
        // 强制转换为User实体类型
        myuser = (YF.Model.User)YF.SessionHelper.GetSesstion("user");

        // 通过用户id,查询此用户购物车信息
        List<YF.Model.Cart> list = YF.BLL.Cart.list(myuser.Id);

        // 遍历求和 计算总价
        for (int i = 0; i < list.Count; i++)
        {
            total = total + list[i].Books.Price * list[i].Num; //i=i+1
        }

        // 把总价返回到前台显示出来
        this.total.Text = total.ToString();
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        //订单信息保存到后台
        //正式下单

        // 通过用户id,查询此用户购物车信息
        YF.Model.User myuser = new YF.Model.User();
        myuser = (YF.Model.User)YF.SessionHelper.GetSesstion("user");

        // 生成订单编号，通过时间
        string orderid = DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() + DateTime.Now.Hour.ToString() + DateTime.Now.Second.ToString() + DateTime.Now.Millisecond.ToString();
        
        // 声明空的订单对象
        YF.Model.Order myorder = new YF.Model.Order();

        //给订单对象赋值
        myorder.Id = orderid;//赋值订单编号
        myorder.User = myuser;//赋值当前用户信息
        myorder.Amount = float.Parse(this.total.Text);//赋值总价
        myorder.State = 1;//订单状态，0表示未付款
        myorder.Adddate = DateTime.Now;//订单时间

        // 更新库存
        List<YF.Model.Cart> list = YF.BLL.Cart.list(myuser.Id);//用户id/通过用户id,查询购物车信息，算出总价

        if (YF.BLL.Order.add(myorder))//把订单对象，调用业务层，插入数据
        {
            //遍历更新库存
            for (int i = 0; i < list.Count; i++)
            {
                YF.BLL.Books.update(list[i].Books.Id); //
            }

            //更新 清空 购物车
            YF.BLL.Order.update(orderid, myuser.Id, 0);
            

            YF.JsHelper.AlertAndRedirect("下单成功", "/myweb/user/order.aspx");
        }
        else
        {
            YF.JsHelper.AlertAndRedirect("下单失败", "/myweb/user/Order_add.aspx");
        }           
    }
}