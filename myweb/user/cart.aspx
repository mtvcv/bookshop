<%@ Page Language="C#" AutoEventWireup="true" CodeFile="cart.aspx.cs" Inherits="user_cart" %>

<%@ Register src="../inc/usermenu.ascx" tagname="usermenu" tagprefix="uc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>购物车</title>
</head>
<body>
    <!--上方图片-->
    <table border="0" width="1000" align="center" >
        <tr>
            <td><img src="../images/注册顶部.PNG" width="1500" height="190" /></td>
        </tr>
    </table>

    <form id="form1" runat="server">
    
    <div>
    <table>
        <tr>
            <td><uc1:usermenu ID="usermenu1" runat="server" /></td>
            <td>
                <table width="100%" align="center" border="1">
                    <tr align="center">
                        <td>ISBN编号</td><td>图书名称</td><td>封面</td><td>价格</td><td>数量</td><td>操作</td>
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
                        
                        List<YF.Model.Cart> list = YF.BLL.Cart.list(myuser.Id); // 此用户的购物车列表,保证购物车是当前用户的
                        for (int i = 0; i < list.Count; i++)
                        {
                    %>
                    <tr align="center">
                        <td>
                            <%=list[i].Books.Isbn %>
                        </td>
                        <td>
                            <%=list[i].Books.Bookname %>
                        </td>
                        <td>
                            <img src="../admin/img/<%=list[i].Books.Img%>" width="50" height="50" />
                        </td>
                        <td>
                            <%=list[i].Books.Price %>
                        </td>
                        <td>
                            <%=list[i].Num %>
                        </td>
                        <td>
                            <a href="cart.aspx?id=<%=list[i].Id %>">删除</a>
                        </td>
                    </tr>
                  <%} %>

                </table>   

                <table width="100%" align="center" border="1">
                    <tr>
                        <td align="right">
                            <asp:Button ID="Button1" runat="server" Text="我要下单" OnClick="Button1_Click" />
                        </td>
                    </tr>
                </table>
            </td>                             
        </tr>
    </table>
    </div>
    </form>
</body>
</html>