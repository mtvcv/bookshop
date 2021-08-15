<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Books_add.aspx.cs" Inherits="admin_Books_add" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>书籍发布</title>
    <style type="text/css">
        .auto-style1 {
            width: 333px;
        }
        .style1
        {
            width: 1046px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table border="1" width="60%"><!--border是边框-->
            <tr>
                <td class="auto-style1">ISBN：</td>
                <td class="style1"><asp:TextBox ID="isbn" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td class="auto-style1">图书名称：</td>
                <td class="style1"><asp:TextBox ID="bookname" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td class="auto-style1">价格：</td>
                <td class="style1"><asp:TextBox ID="price" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td class="auto-style1">数量：</td>
                <td class="style1"><asp:TextBox ID="num" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td class="auto-style1">图片：</td>
                <td class="style1">
                <asp:FileUpload ID="img" runat="server" />
                </td>
            </tr>
            <tr>
                <td>详情：</td>
                <td class="style1">
                    <asp:TextBox ID="detail" runat="server" Height="80px" TextMode="MultiLine" Width="200px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>状态：</td>
                <td class="style1">
                     <asp:DropDownList ID="state" runat="server">
                         <asp:ListItem Value="1">上线</asp:ListItem>
                         <asp:ListItem Value="0">下线</asp:ListItem>
                     </asp:DropDownList>
                 </td>
            </tr>
        </table>
    </div>
    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="发布" BorderColor="Red" />
    </form>
</body>
</html>
