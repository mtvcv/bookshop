<%@ Page Language="C#" AutoEventWireup="true" CodeFile="useredit.aspx.cs" Inherits="user_useredit" %>

<%@ Register src="../inc/usermenu.ascx" tagname="usermenu" tagprefix="uc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>会员修改信息</title>
    <style type="text/css">
        .style1
        {
            height: 28px;
        }
        .style2
        {
            height: 193px;
        }
        .style3
        {
            height: 193px;
            width: 242px;
        }
    </style>
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
    <table width="100%" align="left">
        <tr>
            <td class="style3"><uc1:usermenu ID="usermenu1" runat="server" /></td>
            
            <td>    
            <table class="style3" align="left">
                <tr >
                    <td>username:</td>
                    <td><asp:TextBox ID="username" runat="server" Enabled="False" 
                            style="margin-left: 0px"></asp:TextBox></td>
                </tr>        
                <tr>
                    <td class="style1">password:</td>
                    <td class="style1"><asp:TextBox ID="password" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>name:</td>
                    <td><asp:TextBox ID="name" runat="server" style="margin-left: 0px"></asp:TextBox></td>
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
                    <td><asp:Button ID="Button1" runat="server" Text="saveHere" 
                            onclick="Button1_Click" />
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
