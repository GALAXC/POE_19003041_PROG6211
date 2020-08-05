<%@ Page Title="Report Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Report.aspx.cs" Inherits="POE_19003041_PROG6211_WEB.Report" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="mainWrapper">

        <%--Side column--%>
        <div class="column side">
            <div id="cityName">
                <asp:Label runat="server" ID="lblCity" Style="width: 200px">Add or Remove Cities:</asp:Label>
                <asp:DropDownList ID="cities" runat="server" Style="width: 200px"></asp:DropDownList>
            </div>
            <div id="date1">
                <asp:Label runat="server" ID="lblDate1" Style="width: 200px">Starting Date:</asp:Label>
                <asp:Calendar ID="firstDate" runat="server"></asp:Calendar>
            </div>
            <div id="date2">
                <asp:Label runat="server" ID="lblDate2" Style="width: 200px">Ending Date:</asp:Label>
                <asp:Calendar ID="secondDate" runat="server"></asp:Calendar>
            </div>
            <div id="buttons">
                <div id="print">
                    <asp:Button ID="btnPrintReport" runat="server" OnClick="PrintReportButton_Click" Text="Print Report" />
                </div>
                <div id="search">
                    <asp:Button ID="btnSearch" runat="server" OnClick="ReportButton_Click" Text="Search" />
                </div>
            </div>
        </div>

        <%--Middle column--%>
        <div class="column middle">
            <div class="topMiddle">
                <div class="citiesBox">
                    <asp:Label ID="Label1" runat="server" Text="Cities Selected:" CssClass="Label1"></asp:Label>
                    <asp:TextBox ID="cityReportBox" runat="server" CssClass="cityReportBox" TextMode="MultiLine" ReadOnly="True" ToolTip="The cities you have selected"></asp:TextBox>
                </div>
                <div class="clearButton">
                    <asp:Button ID="clearButton" runat="server" Text="Clear" />
                </div>
            </div>
            <div>
                <asp:GridView ID="reportGrid" runat="server" AutoGenerateColumns="False">
                    <Columns>
                        <asp:BoundField DataField="City" HeaderText="City" ItemStyle-Width="175" ReadOnly="True" />
                        <asp:BoundField DataField="Date" HeaderText="Date" ItemStyle-Width="150" ReadOnly="True" />
                        <asp:BoundField DataField="Min Temp" HeaderText="Min Temp" ItemStyle-Width="100" ReadOnly="True" />
                        <asp:BoundField DataField="Max Temp" HeaderText="Max Temp" ItemStyle-Width="100" ReadOnly="True" />
                        <asp:BoundField DataField="Precipitation" HeaderText="Precipitation" ItemStyle-Width="100" ReadOnly="True" />
                        <asp:BoundField DataField="Humidity" HeaderText="Humidity" ItemStyle-Width="100" ReadOnly="True" />
                        <asp:BoundField DataField="Wind Speed" HeaderText="Wind Speed" ItemStyle-Width="100" ReadOnly="True" />
                    </Columns>
                </asp:GridView>
            </div>
        </div>

        <%--Side column--%>
        <div class="column side">
            Statistics
        </div>
    </div>
</asp:Content>