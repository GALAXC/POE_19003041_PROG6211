<%@ Page Title="Login Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="POE_19003041_PROG6211_WEB.Login" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div>
        <label runat="server" id="lblWelcome">Welcome to the Weather Forecaster Web App!</label>
    </div>
    <div>
        <asp:Login ID="startLogin" runat="server" DisplayRememberMe="False" OnAuthenticate="StartLogin_Authenticate" BackColor="#F7F7DE" BorderColor="#CCCC99" BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana" Font-Size="10pt" TitleText="Please login with your Username &amp; Password">
            <TitleTextStyle BackColor="#6B696B" Font-Bold="True" ForeColor="#FFFFFF" />
        </asp:Login>
    </div>
</asp:Content>