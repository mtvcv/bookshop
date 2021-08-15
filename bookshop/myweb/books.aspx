<!--这个界面是单本图书详情页-->
<%@ Page Language="C#" AutoEventWireup="true" CodeFile="books.aspx.cs" Inherits="books" %>

<%@ Register src="inc/top.ascx" tagname="top" tagprefix="uc1" %>

<%@ Register src="inc/bottom.ascx" tagname="bottom" tagprefix="uc2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            height: 24px;
        }
        .style3
        {
            width: 194px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <uc1:top ID="top1" runat="server" />
    <div>
        <table width="1000" align="center" border="0">
            <tr>
                <td rowspan="5" class="style3">
                    <asp:Image ID="img" runat="server" />
                </td>
            </tr>
            <tr>           
                <td class="style1">名称:</td>
                <td class="style1">
                    <asp:Label ID="bookname" runat="server"></asp:Label>
                </td>
            </tr>
                             
            <tr>
                <td class="style1">价格:</td>
                <td class="style1"><asp:Label ID="price" runat="server"></asp:Label></td>
            </tr>

            <tr>
                <td class="style1">库存:</td>
                <td class="style1"><asp:Label ID="num" runat="server" ></asp:Label></td>
            </tr>
                 
            <tr>
                <td class="style1">ISBN:</td>
                <td class="style1"><asp:Label ID="isbn" runat="server"></asp:Label></td>
            </tr>
                 
            <tr align="center">
                <td class="style3"></td>
                <!--通过id确定图书-->
                <td><a href="user/cartadd.aspx?id=<%=Request.QueryString["id"] %>">购买</a></td> 
            </tr>  
            
                 
        </table>

        <table width="1000" align="center" border="0">
            <tr>
                <td class="text-align:right;"><strong>图书详情:</strong></td>
                <td class="style1">
                    <asp:Label ID="detail" runat="server" Text="图书详情"></asp:Label>
                </td>
            </tr>
        </table>         
    </div>
    <uc2:bottom ID="bottom1" runat="server" />
    </form>
</body>
</html>
