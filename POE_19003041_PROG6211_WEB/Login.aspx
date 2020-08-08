<%@ Page Title="Login Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="POE_19003041_PROG6211_WEB.Login" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div>
        <asp:Label ID="welcomeLbl" runat="server" Text="Welcome to the Weather Forecaster Web App!" CssClass="label"></asp:Label>
    </div>
    <div>
        <asp:Login ID="startLogin" runat="server" DisplayRememberMe="False" OnAuthenticate="StartLogin_Authenticate" BackColor="#5499C7" BorderColor="#CCCC99" BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana" Font-Size="10pt" TitleText="Please login with your Username &amp; Password">
            <TitleTextStyle BackColor="#85929E" Font-Bold="True" ForeColor="#FFFFFF" />
        </asp:Login>
    </div>
</asp:Content>