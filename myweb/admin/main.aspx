<%@ Page Language="C#" AutoEventWireup="true" CodeFile="main.aspx.cs" Inherits="admin_main" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns ="http://www.w3.org/1999/xhtml">
    <head id ="Head1" runat ="server">
        <title>书店总后台</title>
    </head>
    <frameset rows ="100, *" cols ="*" frameborder="no" border ="0" framespacing ="0">
        <frame src ="top.aspx" name ="topFrame" scrolling ="No" noresize="noresize" id ="topFrame" />
        <frameset cols="200,*" frameborder="no" border ="0" framespacing="0">
            <frame src ="menu.aspx" name ="leftFrame" scrolling ="No" noresize="noresize" id="leftFrame" />
            <frame src ="" name ="bookshop" id="mainFrame" />
        </frameset>
    </frameset>
</html>