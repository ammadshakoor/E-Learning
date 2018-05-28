<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="teachers.aspx.cs" Inherits="teachers" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 167px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add New Teacher" />
    <asp:Button ID="btnUp" runat="server" Text="Update Teacher" OnClick="btnUp_Click" />
    <asp:Button ID="btnDel" runat="server" Text="Delete Teacher" OnClick="btnDel_Click" />
    <asp:Button ID="BtnBack" runat="server" Text="<< DashBoard" OnClick="BtnBack_Click" />    

    <br /><br />
    
    <table class="nav-justified">
        <tr>
            <td class="auto-style1">Name:</td>
            <td>
                <asp:TextBox ID="TeachName" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">Email:</td>
            <td>
                <asp:TextBox ID="TeachEmail" runat="server" TextMode="Email"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">Address:</td>
            <td>
                <asp:TextBox ID="TeachAddress" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">DOB:</td>
            <td>
                <asp:TextBox ID="TeachDOB" runat="server" TextMode="Date"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">Gender</td>
            <td>
                <asp:TextBox ID="TeachGender" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">Salary</td>
            <td>
                <asp:TextBox ID="TeachSalary" runat="server"></asp:TextBox>
            </td>
        </tr>
    </table>
    <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" Width="1032px" >
        <AlternatingRowStyle BackColor="White" />
        <EditRowStyle BackColor="#2461BF" />
        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#EFF3FB" />
        <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#F5F7FB" />
        <SortedAscendingHeaderStyle BackColor="#6D95E1" />
        <SortedDescendingCellStyle BackColor="#E9EBEF" />
        <SortedDescendingHeaderStyle BackColor="#4870BE" />
    </asp:GridView>    

    <hr />
    
    

    <asp:ListBox ID="ListBox1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged">
        <asp:ListItem Value="cat_id" Selected="True">Name</asp:ListItem>
        <asp:ListItem></asp:ListItem>
    </asp:ListBox>

    </asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
</asp:Content>

