<%@ Page Language="C#" AutoEventWireup="true" CodeFile="serachbooks.aspx.cs" Inherits="serachbooks" %>

<%@ Register src="inc/top.ascx" tagname="top" tagprefix="uc1" %>
<%@ Register src="inc/bottom.ascx" tagname="bottom" tagprefix="uc2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>按价寻书</title>
</head>
<body>
    <form id="form1" runat="server">
    <uc1:top ID="top1" runat="server" />
    <div align="center">   
     
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
                BackColor="#FFFF99" AllowPaging="True" AllowSorting="True" PageSize="4" 
                onpageindexchanging="GridView1_PageIndexChanging" 
                onselectedindexchanged="GridView1_SelectedIndexChanged">
                <Columns>
                    <asp:BoundField DataField="isbn" HeaderText="ISBN" />
                    <asp:BoundField DataField="bookname" HeaderText="书名" />
                    <asp:BoundField DataField="price" HeaderText="价格" />
                    <asp:BoundField DataField="detail" HeaderText="详情介绍" />
                </Columns>
            </asp:GridView>
            
            <tr>
                <td><asp:TextBox ID="Price" runat="server"></asp:TextBox></td>
                <td>
                    <asp:Button ID="procedure" runat="server" Text="Search by stored procedures" 
            onclick="procedure_Click" />
                </td>
            </tr>
            
            
            
        
        
    </div>
    <uc2:bottom ID="bottom1" runat="server" />
    </form>
</body>
</html>
