<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ordermanage.aspx.cs" Inherits="admin_ordermanage" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>订单管理</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
            AllowPaging="True" AllowSorting="True" BackColor="#FFFF99" PageSize="2" 
            onpageindexchanging="GridView1_PageIndexChanging" 
            onselectedindexchanged="GridView1_SelectedIndexChanged">
            <Columns>
                <asp:BoundField DataField="cartid" HeaderText="购物车id" />
                <asp:BoundField DataField="bookid" HeaderText="图书id" />
                <asp:BoundField DataField="userid" HeaderText="用户id" />
                <asp:BoundField DataField="orderid" HeaderText="订单id" />
            </Columns>
        </asp:GridView>
    </div>
    </form>
</body>
</html>
