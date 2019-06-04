<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="AgroGreen._Default" %>

<script runat="server">

    protected void Button1_Click(object sender, EventArgs e)
    {

    }
</script>


<asp:Content runat="server" ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent">
    </asp:Content>
<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; -----This is My Simple Application&nbsp;final 
        change-----</p>
    <p>
        &nbsp;</p>
    <table class="auto-style1" align="center">
        <tr>
            <td class="auto-style2">User Name</td>
            <td class="auto-style3">
                <asp:TextBox ID="TextBox1" runat="server" Height="25px" Width="212px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">Password</td>
            <td class="auto-style3">
                <asp:TextBox ID="TextBox2" runat="server" Height="25px" Width="214px" ></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">
                <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            </td>
            <td class="auto-style3">
                <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="LogIn" />
                <asp:Button ID="Button2" runat="server" Text="SignUp" OnClick="Button2_Click" PostBackUrl="~/Registration.aspx" />
            </td>
        </tr>
    </table>
    <p>
        &nbsp;</p>
    <p>
        <br />
    </p>
    <p>
    </p>
    <p>
    </p>
    <p>
    </p>
</asp:Content>
<asp:Content ID="Content1" runat="server" contentplaceholderid="HeadContent">
    <style type="text/css">
        .auto-style1
        {
            width: 51%;
            height: 145px;
        }
        .auto-style2
        {
            width: 213px;
        }
        .auto-style3
        {
            width: 354px;
        }
    </style>
</asp:Content>

