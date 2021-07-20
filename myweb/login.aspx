<!--这是用户登陆界面-->
<%@ Page Language="C#" AutoEventWireup="true" CodeFile="login.aspx.cs" Inherits="login" %>

<%@ Register src="inc/usertop.ascx" tagname="usertop" tagprefix="uc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>用户登录</title>
</head>
<body>
    <form id="form1" runat="server">
    <br />
    <br />
    <br />
    <br />
    <uc1:usertop ID="usertop1" runat="server" />
    <div>
    <center>
        <table>
            <tr>
                <td>username:</td>
                <td><asp:TextBox ID="username" runat="server"></asp:TextBox></td>                
            </tr>
            <tr>
                <td>password:</td>    
                <td><asp:TextBox ID="password" runat="server" TextMode="Password"></asp:TextBox></td>
                
            </tr>
            <tr>
                <td>role:</td>    
                <td>
                    <asp:DropDownList ID="role" runat="server">
                        <asp:ListItem>user</asp:ListItem>
                        <asp:ListItem>shop</asp:ListItem>
                    </asp:DropDownList>
                </td>
                
            </tr>
            <tr align="left">
                <td></td>
                <td><asp:Button ID="Button1" runat="server" Text="login" onclick="Button1_Click" /></td>    
            </tr>
            <tr>
                <td>没有账号？点击这里去注册</td>
                <td><asp:Button ID="Button2" runat="server" Text="goto register" onclick="Button2_Click" /></td>
            </tr>
        </table>
    </center>
    </div>
    </form>
</body>
</html>
