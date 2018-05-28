<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Index.aspx.cs" Inherits="Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>20fingers</title>
    <script src="jquery-3.2.1.min.js"></script>
    <style type="text/css">
        body{
            background-color:#ccc;
        }
        .formClass{
            padding:20px;
            margin:0px auto;
            background-color:#fff;
            width:200px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="formClass">
        <asp:Label ID="Label1" runat="server" Text="Usernamme"></asp:Label>
        <asp:TextBox ID="TextBoxUser" CssClass="form-control" runat="server"></asp:TextBox>
        <br /><br />
        <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label>
        <asp:TextBox ID="TextBoxPass" CssClass="form-control" runat="server" TextMode="Password"></asp:TextBox>
        <br /><br />
        <asp:Button ID="BtnLogin" runat="server" Text="Login >>" OnClick="BtnLogin_Click" />
        <asp:Label ID="LblMsg" runat="server" ForeColor="Red"></asp:Label>
    </div>
    </form>
</body>
</html>
