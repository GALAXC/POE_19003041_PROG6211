using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace POE_19003041_PROG6211_WEB
{
    public partial class Report : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                WebWeather.PopulateWeatherArrayLists();
                DataTable dt = new DataTable();

                dt.Columns.Add(new DataColumn("City", typeof(string)));
                dt.Columns.Add(new DataColumn("Date", typeof(string)));
                dt.Columns.Add(new DataColumn("Min Temp", typeof(string)));
                dt.Columns.Add(new DataColumn("Max Temp", typeof(string)));
                dt.Columns.Add(new DataColumn("Precipitation", typeof(string)));
                dt.Columns.Add(new DataColumn("Humidity", typeof(string)));
                dt.Columns.Add(new DataColumn("Wind Speed", typeof(string)));

                DataRow row = dt.NewRow();
                dt.Rows.Add(row);
                reportGrid.DataSource = dt;
                reportGrid.DataBind();
            }
            PopulateCityComboBox();
        }

        private void GetWeatherTable()
        {
            reportGrid.DataSource = null;
            reportGrid.DataBind();
            DataTable dt = new DataTable();

            dt.Columns.Add(new DataColumn("City", typeof(string)));
            dt.Columns.Add(new DataColumn("Date", typeof(string)));
            dt.Columns.Add(new DataColumn("Min Temp", typeof(string)));
            dt.Columns.Add(new DataColumn("Max Temp", typeof(string)));
            dt.Columns.Add(new DataColumn("Precipitation", typeof(string)));
            dt.Columns.Add(new DataColumn("Humidity", typeof(string)));
            dt.Columns.Add(new DataColumn("Wind Speed", typeof(string)));

            DataRow row;

            for (int i = 0; i < WebWeather.GetCityNameCount(); i++)
            {
                row = dt.NewRow();
                row["City"] = WebWeather.GetCityName(i);
                row["Date"] = WebWeather.GetWeatherDate(i).ToShortDateString();
                row["Min Temp"] = WebWeather.GetMinTemp(i) + "°C";
                row["Max Temp"] = WebWeather.GetMaxTemp(i) + "°C";
                row["Precipitation"] = WebWeather.GetPrecipitation(i) + "%";
                row["Humidity"] = WebWeather.GetHumidity(i) + "%";
                row["Wind Speed"] = WebWeather.GetWindSpeed(i) + " km/h";
                dt.Rows.Add(row);
            }
            reportGrid.DataSource = dt;
            reportGrid.DataBind();
        }

        private void PopulateCityComboBox()
        {
            cities.Items.Clear();
            for (int i = 0; i < (WebWeather.GetCityNameCount()); i++)
            {
                if (cities.Items.Contains(new ListItem(WebWeather.GetCityName(i))))
                {
                }
                else
                {
                    cities.Items.Add(new ListItem(WebWeather.GetCityName(i)));
                }
            }
        }

        protected void ReportButton_Click(object sender, EventArgs e)
        {
            GetWeatherTable();
        }

        protected void PrintReportButton_Click(object sender, EventArgs e)
        {
        }
    }
}