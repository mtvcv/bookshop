<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Books.aspx.cs" Inherits="admin_Books" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>图书总览页面</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table width="1000" align="center" border="1">
                <tr border="1" align="center">
                    <td>编号</td>
                    <td>ISBN</td>
                    <td>名称</td>
                    <td>封面</td>
                    <td>价格</td>
                    <td>数量</td>
                    <td>添加时间</td>
                    
                </tr>
              <%--读取数据--%>
              <%
                    List<YF.Model.Books> list = YF.BLL.Books.list();
                    for (int i = 0; i < list.Count; i++)
                    {
              %>
                <tr border="1" align="center">
                    <td><%=i + 1 %></td>
                    <td><%=list[i].Isbn %></td>
                    <td><%=list[i].Bookname %></td>
                    <td><img src="img/<%=list[i].Img %>/ " width="100" height="100"/></td>
                    <td><%=list[i].Price %></td>
                    <td><%=list[i].Num %></td>
                    <td><%=list[i].Adddate %></td>
                    
                </tr>
              <%
                    } 
              %>
            </table>
        </div>
    </form>
</body>
</html>
