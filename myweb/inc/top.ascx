<!--自定义控件-->
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="top.ascx.cs" Inherits="inc_top" %>
<!--上方图片-->
<table border="0" width="1000" align="center" >
    <tr>
        <td><img src="images/书店首页.jpg"  width="1000" height="350" /></td>
    </tr>
</table>
<!---->
<table border="0" width="1000" align="center" style="background:#ffcc33">
    <tr align="center">
        <td><a href="admin/Books.aspx" target="_blank">图书列表</a></td>
        <td><a href="/myweb/serachbooks.aspx" target="_blank">按价寻书</a></td>
        <td><a href="user/member.aspx" target="_blank" >会员中心</a></td>
        <td><a href="admin/main.aspx" target="_blank">后台管理</a></td>        
    </tr>
</table>