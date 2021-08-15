<%@ Page Language="C#" AutoEventWireup="true" CodeFile="register.aspx.cs" Inherits="register" %>

<%@ Register src="inc/usertop.ascx" tagname="usertop" tagprefix="uc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 245px;
        }
    </style>
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
            <td class="style1">username:</td>
            <td><asp:TextBox ID="username" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td class="style1">password:</td>
            <td><asp:TextBox ID="password" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td class="style1">name:</td>
            <td><asp:TextBox ID="name" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td class="style1">address:</td>
            <td><asp:TextBox ID="address" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td class="style1">sex:</td>
            <td>
                <asp:DropDownList ID="sex" runat="server">
                    <asp:ListItem Value="1">male</asp:ListItem>
                    <asp:ListItem Value="2">female</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="style1">mobile:</td>
            <td><asp:TextBox ID="mobile" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td class="style1">email:</td>
            <td><asp:TextBox ID="email" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td class="style1">qq:</td>
            <td><asp:TextBox ID="qq" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td class="style1">role:</td>
            <td>
                <asp:DropDownList ID="role" runat="server">
                    <asp:ListItem Value="user">user</asp:ListItem>
                    <asp:ListItem Value="shop">shop</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="style1">register:</td>
            <td><asp:Button ID="Button1" runat="server" Text="registerHere" 
                    onclick="Button1_Click" /></td>
        </tr>        
        </table>  
    </center>
    </div>
    </form>
</body>
</html>
