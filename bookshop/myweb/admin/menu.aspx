<%@ Page Language="C#" AutoEventWireup="true" CodeFile="menu.aspx.cs" Inherits="admin_menu" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body style ="background:#DEDEDE; margin : 0; padding : 0;">
    <form id="form1" runat="server">
        <div>
            <table align ="center">
                <tr align ="center"><td><a href="index.aspx" target="bookshop">用户管理</td></tr>
                <tr align ="center"><td><a href="Books.aspx" target="bookshop">书籍管理</td></tr>
                <tr align ="center"><td><a href="Books_add.aspx" target="bookshop">书籍发布</td></tr>
                <tr align ="center"><td><a href="ordermanage.aspx" target="bookshop">订单管理</td></tr>
            </table>
        </div>
    </form>
</body>
</html>
