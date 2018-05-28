<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="student.aspx.cs" Inherits="student" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add New Student" />
    <asp:Button ID="btnUp" runat="server" Text="Update Student" OnClick="btnUp_Click" />
    <asp:Button ID="btnDel" runat="server" Text="Delete Student" OnClick="btnDel_Click" />
    <asp:Button ID="BtnBack" runat="server" Text="<< DashBoard" OnClick="BtnBack_Click" />    

    <br /><br />
    <div class="container col-md-offset-4">
    <table class="nav-justified table table-bordered table-condensed ">
        <tr>
            <td class="auto-style1">Name:</td>
            <td>
                <asp:TextBox ID="StudName" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">Email:</td>
            <td>
                <asp:TextBox ID="StudEmail" runat="server" TextMode="Email"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">Address:</td>
            <td>
                <asp:TextBox ID="StudAddress" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">DOB:</td>
            <td>
                <asp:TextBox ID="StudDOB" runat="server" TextMode="Date"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">Gender</td>
            <td>
                <asp:TextBox ID="StudGender" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">Semester</td>
            <td>
                <asp:TextBox ID="StudSem" runat="server" TextMode="Number"></asp:TextBox>
            </td>
        </tr>
    </table>
        </div>

    <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" Width="1030px" >
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

