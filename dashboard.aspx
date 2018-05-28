<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="dashboard.aspx.cs" Inherits="dashboard"
    Culture="en-US" UICulture="auto:en-US" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <link href="style.css" rel="stylesheet" />
    <script src="jquery-3.2.1.min.js"></script>

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">
        <asp:Label ID="LblName" runat="server" Font-Size="Larger" ForeColor="Red" >Label</asp:Label>
    <div class="col-md-offset-2 grid-view">
        <div class="col-md-2">
            <div class="nested-grid">
                <img src="images/student.png" />
                <br />
                <a href="student.aspx">
                    <asp:Label ID="Label1" runat="server" 
                        Text="<%$ Resources:Resource, txt1 %>"></asp:Label>
                </a>
            </div>
        </div>
        <div class="col-md-2">
            <div class="nested-grid">
                <img src="images/ustad.ico" />
                <br />
                <a href="Teachers.aspx">
                    <asp:Label ID="Label2" runat="server" 
                        Text="<%$ Resources:Resource, txt2 %>"></asp:Label>
                </a>
            </div>
        </div>
        <div class="col-md-2">
            <div class="nested-grid">
                <img src="images/attandance.png" />
                <br />
                <a href="Attendance.aspx">
                    <asp:Label ID="Label3" runat="server" 
                        Text="<%$ Resources:Resource, txt3 %>" ></asp:Label>
                </a>
            </div>
        </div>
        <div class="col-md-2">
            <div class="nested-grid">
                <img src="images/language.png" />
                <br />
                <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                    <asp:ListItem Value="en-US">English</asp:ListItem>
                    <asp:ListItem Value="ur">Urdu</asp:ListItem>
                    <asp:ListItem Value="ar">Arabic</asp:ListItem>
                    <asp:ListItem Value="ps">Pashto</asp:ListItem>
                </asp:DropDownList>
            </div>
        </div>
        <div class="col-md-2">
            <div class="nested-grid">
                <img src="images/theme.png" />
                <br />
                <asp:DropDownList ID="ddlTheme" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlTheme_SelectedIndexChanged">
                    <asp:ListItem Value="FristTheme">FirstTheme</asp:ListItem>
                    <asp:ListItem Value="SecondTheme">SecondTheme</asp:ListItem>
                    <asp:ListItem></asp:ListItem>
                </asp:DropDownList>

            </div>
        </div>
    </div>
  
  

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="container">
        <asp:Button ID="BtnLogout" runat="server"  CssClass="btn-danger" text="Logout" OnClick="BtnLogout_Click" Font-Size="Larger" />
    </div>
</asp:Content>

