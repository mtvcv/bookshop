<%@ Page Language="C#" AutoEventWireup="true" CodeFile="order.aspx.cs" Inherits="user_order" %>

<%@ Register src="../inc/usermenu.ascx" tagname="usermenu" tagprefix="uc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>用户订单界面</title>
</head>
<body>
    <!--上方图片-->
    <table border="0" width="1000" align="center" >
        <tr>
            <td><img src="../images/注册顶部.PNG" width="1500" height="190" /></td>
        </tr>
    </table>

    <form id="form2" runat="server">
    
    <div>
    <table>
        <tr>
            <td><uc1:usermenu ID="usermenu1" runat="server" /></td>
            <td>
                <table width="100%" align="center" border="1">
                    <tr align="center">
                        <td>订单编号</td><td>总价格</td><td>下单日期</td>
                    </tr>

                    <!--读取数据-->
                    
                    <%
                    string id = Request.QueryString["id"];
                        if (id != null)
                        {
                            YF.BLL.Cart.delete(int.Parse(id));
                            YF.JsHelper.AlertAndRedirect("delete successfully!!!", "/myweb/user/cart.aspx");
                        }
                        // 获取当前用户信息
                        YF.Model.User myuser = new YF.Model.User();
                        myuser = (YF.Model.User)YF.SessionHelper.GetSesstion("user"); //读取 强制转
                        
                        List<YF.Model.Order> list = YF.BLL.Order.list(myuser.Id); // 此用户的购物车列表,保证购物车是当前用户的
                        for (int i = 0; i < list.Count; i++)
                        {
                    %>
                    <tr align="center">
                        <td>
                            <%=list[i].Id %>
                        </td>
                        <td>
                            <%=list[i].Amount%>
                        </td>
                        <td>
                            <%=list[i].Adddate %>
                        </td>
                    </tr>
                  <%} %>

                </table> 
                
            </td>                             
        </tr>
    </table>
    </div>
    </form>
</body>
</html>