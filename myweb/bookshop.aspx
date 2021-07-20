<%@ Page Language="C#" AutoEventWireup="true" CodeFile="bookshop.aspx.cs" Inherits="bookShop" %>

<%@ Register src="inc/top.ascx" tagname="top" tagprefix="uc1" %>

<%@ Register src="inc/bottom.ascx" tagname="bottom" tagprefix="uc2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>书店首页</title>
    <style type="text/css">
        .auto-style2
        {
            height: 214px;
            width: 176px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <center>
        <uc1:top ID="top1" runat="server" />
        welcome to kun's bookshop
        <div style="width:1000px; margin:0 auto;">
            <!--传上数据-->
                <ul style="list-style:none;margin:0;padding:0;">
                <%
                    List<YF.Model.Books> list = YF.BLL.Books.list();
                    for (int i = 0; i < list.Count; i++)
                    { %>                    
                        <li style="float:left; height:250px; width:220px; text-align:center;border:#DEDEDE solid 1px;margin:10px 10px 10px 10px;">                            
                            <img src="admin/img/<%=list[i].Img %>" class="auto-style2"/>
                            <br />
                            <a href="books.aspx?id=<%=list[i].Id %>" target="_blank"> 
                            《<%=list[i].Bookname%>》
                            </a>                                
                        </li>
                 <% } %>
                </ul>
        </div>
        <uc2:bottom ID="bottom1" runat="server" />
    </center>
    </div>
    </form>
</body>
</html>
