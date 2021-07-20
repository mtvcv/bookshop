<!--this page is to manage users' data-->
<%@ Page Language="C#" AutoEventWireup="true" CodeFile="index.aspx.cs" Inherits="index" %>

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
    <center>
        welcome to kun's bookshop
    </center>
    <center>
    <table align = "center">
        <tr align="center" bgcolor="yellow">
            <td>id</td>
            <td>username</td>
            <td>password</td>
            <td>name</td>
            <td>address</td>
            <td>sex</td>
            <td>mobile</td>
            <td>email</td>
            <td>adddate</td>
            <td>delete</td>
            <td>role</td>
        </tr>
        <%
            string id = Request.QueryString["id"];
            if (id != null)
            {
                YF.BLL.User.delData(int.Parse(id));
                YF.JsHelper.AlertAndRedirect("delete successfully!", "index.aspx");
                
            }
            List<YF.Model.User> list = YF.DAL.User.List();
             %>
        <%                     
            for (int i = 0; i < list.Count; i++)
            {
                // 写一个判断sex==1时，为男性
                string sex = "";
                if (list[i].Sex == 1)
                {
                    sex = "male";
                }
                else
                {
                    sex = "female";
                }                
                %>
            <tr align="center" bgcolor="silver">
                <td><%=list[i].Id %></td>
                <td><%=list[i].Username %></td>
                <td><%=list[i].Password %></td>
                <td><%=list[i].Name %></td>
                <td><%=list[i].Address %></td>
                <td><%=sex %></td>
                <td><%=list[i].Mobile %></td>
                <td><%=list[i].Email %></td>
                <td><%=list[i].Adddate %></td>
                <td><a href="index.aspx?id=<%=list[i].Id %>">delete</a>|<a href="edit.aspx?id=<%=list[i].Id %>">edit</a></td>
                <td><%=list[i].Role %></td>
            </tr>
        <%
            }%>
    </table>
    </center>
    </div>
    </form>
</body>
</html>
