<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Attendance.aspx.cs" Inherits="Attendance" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 309px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    
    <asp:Button ID="btnAdd" runat="server" Text="Add Attendance" OnClick="btnAdd_Click" />
    <asp:Button ID="btnBack" runat="server" Text="<< Dashboard" OnClick="btnBack_Click" /><br /><br />
    <table class="auto-style1">
        <tr>
            <td class="auto-style2">Name:</td>
            <td>
                <asp:TextBox ID="StudName" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">Attendance</td>
            <td>
                <asp:TextBox ID="StudAttend" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
    
    <hr />
    
    

    <asp:ListBox ID="ListBox1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged">
        <asp:ListItem Value="cat_id" Selected="True">Name</asp:ListItem>
        <asp:ListItem></asp:ListItem>
    </asp:ListBox>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
</asp:Content>

