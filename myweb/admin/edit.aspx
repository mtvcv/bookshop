<!--this page is to edit users' data-->
<%@ Page Language="C#" AutoEventWireup="true" CodeFile="edit.aspx.cs" Inherits="edit" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">    
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <div>
        <table align="center">
        <tr>
            <td>username:</td>
            <td><asp:TextBox ID="username" runat="server" Enabled="False"></asp:TextBox></td>
        </tr>        
        <tr>
            <td>password:</td>
            <td><asp:TextBox ID="password" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>name:</td>
            <td><asp:TextBox ID="name" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>address:</td>
            <td><asp:TextBox ID="address" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>sex:</td>
            <td>
                <asp:DropDownList ID="sex" runat="server">
                    <asp:ListItem Value="1">male</asp:ListItem>
                    <asp:ListItem Value="2">female</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>mobile:</td>
            <td><asp:TextBox ID="mobile" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>email:</td>
            <td><asp:TextBox ID="email" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>qq:</td>
            <td><asp:TextBox ID="qq" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>role:</td>
            <td>
                <asp:DropDownList ID="role" runat="server" Enabled="False">
                    <asp:ListItem Value="user">user</asp:ListItem>
                    <asp:ListItem Value="shop">shop</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>
                <asp:HiddenField ID="id" runat="server" />
            </td>
            <td><asp:Button ID="Button1" runat="server" Text="edit&saveHere" 
                    onclick="Button1_Click" /></td>
        </tr>
        </table>
    </div>
    </form>
</body>
</html>
