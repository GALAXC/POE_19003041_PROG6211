<%@ Page Title="Report" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Report.aspx.cs" Inherits="POE_19003041_PROG6211_WEB.Report" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="mainWrapper">

        <%--Side column--%>
        <div class="column side">
            <div id="cityName">
                <asp:Label runat="server" ID="lblCity" Style="width: 200px" CssClass="label">Add or Remove Cities:</asp:Label>
                <asp:DropDownList ID="cities" runat="server" Style="width: 200px" OnSelectedIndexChanged="CityComboBox_SelectedIndexChanged" AutoPostBack="True"></asp:DropDownList>
            </div>
            <div id="date1">
                <asp:Label runat="server" ID="lblDate1" Style="width: 200px" CssClass="label">Starting Date:</asp:Label>
                <asp:Calendar ID="firstDate" runat="server" CssClass="date" OnSelectionChanged="FirstDate_SelectionChanged" SelectedDate="2020/01/01" VisibleDate="2020/01/01"></asp:Calendar>
            </div>
            <div id="date2">
                <asp:Label runat="server" ID="lblDate2" Style="width: 200px" CssClass="label">Ending Date:</asp:Label>
                <asp:Calendar ID="secondDate" runat="server" CssClass="date" OnSelectionChanged="SecondDate_SelectionChanged" SelectedDate="2020/07/01" VisibleDate="2020/07/01"></asp:Calendar>
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
                    <asp:Label ID="Label1" runat="server" Text="Cities Selected:" CssClass="label"></asp:Label>
                    <asp:TextBox ID="cityReportBox" runat="server" CssClass="cityReportBox" TextMode="MultiLine" ReadOnly="True" ToolTip="The cities you have selected"></asp:TextBox>
                </div>
                <div class="clearButton">
                    <asp:Button ID="clearButton" runat="server" Text="Clear" OnClick="ClearButton_Click" />
                </div>
                <div>
                    <asp:Label ID="lblDateSelect" runat="server" Text="Dates Selected: " CssClass="label"></asp:Label>
                </div>
            </div>
            <div class="topMiddle">
                <div class="theGrid">
                    <asp:GridView ID="reportGrid" runat="server" AutoGenerateColumns="False" CssClass="Gridview">
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
        </div>

        <%--Side column--%>
        <div class="column side">
            <div class="statistics">
                <div class="results">
                    <asp:Label ID="Label2" runat="server" Text="Lowest"></asp:Label>
                    <div class="smallResults">
                        <asp:Label ID="lowestMinTemp" runat="server" Text="Min Temp: " CssClass="stats"></asp:Label>
                        <asp:Label ID="lowestMaxTemp" runat="server" Text="Max Temp: " CssClass="stats"></asp:Label>
                        <asp:Label ID="lowestPrecip" runat="server" Text="Precipitation: " CssClass="stats"></asp:Label>
                        <asp:Label ID="lowestHumid" runat="server" Text="Humidity: " CssClass="stats"></asp:Label>
                        <asp:Label ID="lowestWind" runat="server" Text="Wind Speed: " CssClass="stats"></asp:Label>
                    </div>
                </div>

                <div class="results">
                    <asp:Label ID="Label3" runat="server" Text="Highest"></asp:Label>
                    <div class="smallResults">
                        <asp:Label ID="highestMinTemp" runat="server" Text="Min Temp: " CssClass="stats"></asp:Label>
                        <asp:Label ID="highestMaxTemp" runat="server" Text="Max Temp: " CssClass="stats"></asp:Label>
                        <asp:Label ID="highestPrecip" runat="server" Text="Precipitation: " CssClass="stats"></asp:Label>
                        <asp:Label ID="highestHumid" runat="server" Text="Humidity: " CssClass="stats"></asp:Label>
                        <asp:Label ID="highestWind" runat="server" Text="Wind Speed: " CssClass="stats"></asp:Label>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>