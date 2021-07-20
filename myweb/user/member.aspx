<%@ Page Language="C#" AutoEventWireup="true" CodeFile="member.aspx.cs" Inherits="user_member" %>

<%@ Register src="../inc/usermenu.ascx" tagname="usermenu" tagprefix="uc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>会员中心</title>
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
            <td>欢迎用户 <asp:Label ID="username" runat="server" Text="Label"></asp:Label> 进入会员页面</td>                        
        </tr>
    </table>
    </div>
    </form>
</body>
</html>
