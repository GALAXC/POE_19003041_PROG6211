using System;
using System.Data;
using System.Web.UI.WebControls;
using System.Collections;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;
using System.Text;
using System.Web;

namespace POE_19003041_PROG6211_WEB
{
    public partial class Report : System.Web.UI.Page
    {
        public static Boolean firstTimeLoad = true;
        private readonly ArrayList userCities = new ArrayList();
        private readonly ArrayList users = new ArrayList();
        private readonly ArrayList editMade = new ArrayList();
        private readonly ArrayList newUser = new ArrayList();
        private ArrayList citiesSelected = new ArrayList();
        private static readonly SqlConnection con = new SqlConnection();
        private DataTable dt = new DataTable();

        //Perform housekeeping on page load
        protected void Page_Load(object sender, EventArgs e)
        {
            if (WebWeather.allowUser == false)
            {
                Response.Redirect("~/Login");
            }
            else
            {
                if (!IsPostBack)
                {
                    WebWeather.PopulateWeatherArrayLists();
                    dt = new DataTable();
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
                    SecondDate_SelectionChanged(sender, e);
                    PopulateCityComboBox();
                }
                GetUsualCities();
                UpdateCityBox();
            }
        }

        //Update gridview with requested weather data
        private void GetWeatherTable()
        {
            reportGrid.DataSource = null;
            reportGrid.DataBind();
            dt = new DataTable();

            dt.Columns.Add(new DataColumn("City", typeof(string)));
            dt.Columns.Add(new DataColumn("Date", typeof(string)));
            dt.Columns.Add(new DataColumn("Min Temp", typeof(string)));
            dt.Columns.Add(new DataColumn("Max Temp", typeof(string)));
            dt.Columns.Add(new DataColumn("Precipitation", typeof(string)));
            dt.Columns.Add(new DataColumn("Humidity", typeof(string)));
            dt.Columns.Add(new DataColumn("Wind Speed", typeof(string)));

            DataRow row;

            int lowMinTemp = 0;
            int highMinTemp = 0;
            int lowMaxTemp = 0;
            int highMaxTemp = 0;
            int lowPrecip = 0;
            int highPrecip = 0;
            int lowHumid = 0;
            int highHumid = 0;
            int lowSpeed = 0;
            int highSpeed = 0;

            for (int j = 0; j < citiesSelected.Count; j++)
            {
                for (int i = 0; i < WebWeather.GetCityNameCount(); i++)
                {
                    if (WebWeather.GetCityName(i) == Convert.ToString(citiesSelected[j]))
                    {
                        if (WebWeather.GetWeatherDate(i) >= firstDate.SelectedDate && WebWeather.GetWeatherDate(i) <= secondDate.SelectedDate)
                        {
                            if (dt.Rows.Count == 0)
                            {
                                //Initiate values in the lowest and highest section
                                lowMinTemp = Convert.ToInt32(WebWeather.GetMinTemp(i));
                                highMinTemp = Convert.ToInt32(WebWeather.GetMinTemp(i));
                                lowMaxTemp = Convert.ToInt32(WebWeather.GetMaxTemp(i));
                                highMaxTemp = Convert.ToInt32(WebWeather.GetMaxTemp(i));
                                lowPrecip = Convert.ToInt32(WebWeather.GetPrecipitation(i));
                                highPrecip = Convert.ToInt32(WebWeather.GetPrecipitation(i));
                                lowHumid = Convert.ToInt32(WebWeather.GetHumidity(i));
                                highHumid = Convert.ToInt32(WebWeather.GetHumidity(i));
                                lowSpeed = Convert.ToInt32(WebWeather.GetWindSpeed(i));
                                highSpeed = Convert.ToInt32(WebWeather.GetWindSpeed(i));
                            }
                            else
                            {
                                //Update values if lowest and highest section not empty
                                if (Convert.ToInt32(WebWeather.GetMinTemp(i)) < lowMinTemp)
                                {
                                    lowMinTemp = Convert.ToInt32(WebWeather.GetMinTemp(i));
                                }

                                if (Convert.ToInt32(WebWeather.GetMinTemp(i)) > highMinTemp)
                                {
                                    highMinTemp = Convert.ToInt32(WebWeather.GetMinTemp(i));
                                }

                                if (Convert.ToInt32(WebWeather.GetMaxTemp(i)) < lowMaxTemp)
                                {
                                    lowMaxTemp = Convert.ToInt32(WebWeather.GetMaxTemp(i));
                                }

                                if (Convert.ToInt32(WebWeather.GetMaxTemp(i)) > highMaxTemp)
                                {
                                    highMaxTemp = Convert.ToInt32(WebWeather.GetMaxTemp(i));
                                }

                                if (Convert.ToInt32(WebWeather.GetPrecipitation(i)) < lowPrecip)
                                {
                                    lowPrecip = Convert.ToInt32(WebWeather.GetPrecipitation(i));
                                }

                                if (Convert.ToInt32(WebWeather.GetPrecipitation(i)) > highPrecip)
                                {
                                    highPrecip = Convert.ToInt32(WebWeather.GetPrecipitation(i));
                                }

                                if (Convert.ToInt32(WebWeather.GetHumidity(i)) < lowHumid)
                                {
                                    lowHumid = Convert.ToInt32(WebWeather.GetHumidity(i));
                                }

                                if (Convert.ToInt32(WebWeather.GetHumidity(i)) > highHumid)
                                {
                                    highHumid = Convert.ToInt32(WebWeather.GetHumidity(i));
                                }

                                if (Convert.ToInt32(WebWeather.GetWindSpeed(i)) < lowSpeed)
                                {
                                    lowSpeed = Convert.ToInt32(WebWeather.GetWindSpeed(i));
                                }

                                if (Convert.ToInt32(WebWeather.GetWindSpeed(i)) > highSpeed)
                                {
                                    highSpeed = Convert.ToInt32(WebWeather.GetWindSpeed(i));
                                }
                            }
                            row = dt.NewRow();
                            row["City"] = WebWeather.GetCityName(i);
                            row["Date"] = WebWeather.GetWeatherDate(i).ToShortDateString();
                            row["Min Temp"] = WebWeather.GetMinTemp(i) + "°C";
                            row["Max Temp"] = WebWeather.GetMaxTemp(i) + "°C";
                            row["Precipitation"] = WebWeather.GetPrecipitation(i) + "%";
                            row["Humidity"] = WebWeather.GetHumidity(i) + "%";
                            row["Wind Speed"] = WebWeather.GetWindSpeed(i) + " km/h";
                            dt.Rows.Add(row);

                            //Update Lowest/Highest section
                            lowestMinTemp.Text = "Min Temp: " + Convert.ToString(lowMinTemp) + " °C";
                            highestMinTemp.Text = "Min Temp: " + Convert.ToString(highMinTemp) + " °C";

                            lowestMaxTemp.Text = "Max Temp: " + Convert.ToString(lowMaxTemp) + " °C";
                            highestMaxTemp.Text = "Max Temp: " + Convert.ToString(highMaxTemp) + " °C";

                            lowestPrecip.Text = "Precipitation: " + Convert.ToString(lowPrecip) + " %";
                            highestPrecip.Text = "Precipitation: " + Convert.ToString(highPrecip) + " %";

                            lowestHumid.Text = "Humidity: " + Convert.ToString(lowHumid) + " %";
                            highestHumid.Text = "Humidity: " + Convert.ToString(highHumid) + " %";

                            lowestWind.Text = "Wind Speed: " + Convert.ToString(lowSpeed) + " km/h";
                            highestWind.Text = "Wind Speed: " + Convert.ToString(highSpeed) + " km/h";
                        }
                    }
                }
            }
            //Reset report and display error
            if (dt.Rows.Count == 0)
            {
                lowestMinTemp.Text = "Min Temp: ";
                highestMinTemp.Text = "Min Temp: ";
                lowestMaxTemp.Text = "Max Temp: ";
                highestMaxTemp.Text = "Max Temp: ";
                lowestPrecip.Text = "Precipitation: ";
                highestPrecip.Text = "Precipitation: ";
                lowestHumid.Text = "Humidity: ";
                highestHumid.Text = "Humidity: ";
                lowestWind.Text = "Wind Speed: ";
                highestWind.Text = "Wind Speed: ";
                //MessageBox.Show("No Results Found.");
            }
            reportGrid.DataSource = dt;
            reportGrid.DataBind();
        }

        //Populate the report city selection combo box
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
            cities.Items.Add(new ListItem("Select a City..."));
            cities.SelectedValue = "Select a City...";
        }

        //Update selected cities box
        private void UpdateCityBox()
        {
            cityReportBox.Text = "";
            for (int j = 0; j < citiesSelected.Count; j++)
            {
                if (j == 0)
                {
                    cityReportBox.Text += citiesSelected[j];
                }
                else
                {
                    cityReportBox.Text += ", " + citiesSelected[j];
                }
            }
            if (cityReportBox.Text == "")
            {
                cityReportBox.Text = "None";
            }
        }

        //Store cities user selects for next login
        private void GetUsualCities()
        {
            citiesSelected.Clear();
            users.Clear();
            userCities.Clear();
            newUser.Clear();
            editMade.Clear();
            String command = String.Format("SELECT * FROM TBL_USERCITIES");
            con.ConnectionString = ConfigurationManager.ConnectionStrings["POEConnection"].ConnectionString;
            con.Open();
            using (con)
            {
                SqlCommand sqlUserCities = new SqlCommand(command, con);
                SqlDataReader userCitiesSelected = sqlUserCities.ExecuteReader();
                if (userCitiesSelected.HasRows)
                {
                    while (userCitiesSelected.Read())
                    {
                        users.Add(userCitiesSelected.GetValue(0));
                        userCities.Add(userCitiesSelected.GetValue(1));
                        newUser.Add(false);
                        editMade.Add(false);
                    }
                }
            }

            if (users.Contains(Login.loggedInUser))
            {
                if (Convert.ToString(userCities[users.IndexOf(Login.loggedInUser)]) == "")
                {
                }
                else
                {
                    citiesSelected = new ArrayList(Convert.ToString(userCities[users.IndexOf(Login.loggedInUser)]).Split(','));
                }
            }
            else
            {
                newUser.Add(true);
                editMade.Add(false);
                users.Add(Login.loggedInUser);
                userCities.Add("Cape Town,Johannesburg");
                citiesSelected = new ArrayList { "Cape Town", "Johannesburg" };
            }
        }

        //Update database with user cities selected
        public void UpdateUserCityDB()
        {
            for (int i = 0; i < newUser.Count; i++)
            {
                if (Convert.ToBoolean(newUser[i]) == true)
                {
                    String command = String.Format("INSERT INTO TBL_USERCITIES VALUES ('{0}','{1}');", Login.loggedInUser, userCities[i]);
                    con.ConnectionString = ConfigurationManager.ConnectionStrings["POEConnection"].ConnectionString;
                    con.Open();
                    using (con)
                    {
                        SqlCommand sqlNewUser = new SqlCommand(command, con);
                        sqlNewUser.ExecuteNonQuery();
                    }
                }
                else
                {
                    if (Convert.ToBoolean(editMade[i]) == true)
                    {
                        String command2 = String.Format("UPDATE TBL_USERCITIES SET SELECTED = '{0}' WHERE USERNAME = '{1}'", userCities[i], Login.loggedInUser);
                        con.ConnectionString = ConfigurationManager.ConnectionStrings["POEConnection"].ConnectionString;
                        con.Open();
                        using (con)
                        {
                            SqlCommand sqlEditMade = new SqlCommand(command2, con);
                            sqlEditMade.ExecuteNonQuery();
                        }
                    }
                }
            }
        }

        //Update local variables with city selection changes
        private void UpdateDBArrayLists()
        {
            userCities[users.IndexOf(Login.loggedInUser)] = "";
            if (citiesSelected.Count != 0)
            {
                for (int i = 0; i < citiesSelected.Count; i++)
                {
                    if (i == 0)
                    {
                        userCities[users.IndexOf(Login.loggedInUser)] = citiesSelected[0];
                    }
                    else
                    {
                        userCities[users.IndexOf(Login.loggedInUser)] += "," + citiesSelected[i];
                    }
                }
            }
        }

        //Update cities on click
        protected void CityComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cities.SelectedValue != "Select a City...")
            {
                if (citiesSelected.Contains(cities.SelectedValue))
                {
                    citiesSelected.Remove(cities.SelectedValue);
                }
                else
                {
                    citiesSelected.Add(cities.SelectedValue);
                }
                editMade[users.IndexOf(Login.loggedInUser)] = true;
                UpdateDBArrayLists();
                UpdateCityBox();
                UpdateUserCityDB();
                cities.SelectedValue = "Select a City...";
            }
        }

        //Track first calendar date change
        protected void FirstDate_SelectionChanged(object sender, EventArgs e)
        {
            lblDateSelect.Text = "Dates Selected: " + Convert.ToString(firstDate.SelectedDate.ToShortDateString()) + " - " + Convert.ToString(secondDate.SelectedDate.ToShortDateString());
        }

        //Track second calendar date change
        protected void SecondDate_SelectionChanged(object sender, EventArgs e)
        {
            lblDateSelect.Text = "Dates Selected: " + Convert.ToString(firstDate.SelectedDate.ToShortDateString()) + " - " + Convert.ToString(secondDate.SelectedDate.ToShortDateString());
        }

        //
        // Buttons
        //

        //Update gridview on click
        protected void ReportButton_Click(object sender, EventArgs e)
        {
            GetWeatherTable();
        }

        //Create a report on click
        protected void PrintReportButton_Click(object sender, EventArgs e)
        {
            ReportButton_Click(sender, e);
            Response.Clear();
            Response.AddHeader("content-disposition", "attachment; filename=Printable Report.txt");
            Response.AddHeader("content-type", "text/plain");

            using (StreamWriter rsw = new StreamWriter(Response.OutputStream))
            {
                rsw.WriteLine("------------------------------");
                rsw.WriteLine("Report Details");
                rsw.WriteLine("------------------------------");
                rsw.WriteLine("\nDates Selected: " + lblDateSelect.Text);
                rsw.WriteLine("\nCities Selected: " + cityReportBox.Text + "\n");
                rsw.Write(string.Format("{0,-24}", "--------------------"));
                rsw.Write(string.Format("{0,-24}", "--------------------"));
                rsw.WriteLine();
                rsw.Write(string.Format("{0,-24}", "Lowest"));
                rsw.Write(string.Format("{0,-24}", "Highest"));
                rsw.WriteLine();
                rsw.Write(string.Format("{0,-24}", "--------------------"));
                rsw.Write(string.Format("{0,-24}", "--------------------"));
                rsw.WriteLine();
                rsw.Write(string.Format("{0,-24}", lowestMinTemp.Text));
                rsw.Write(string.Format("{0,-24}", highestMinTemp.Text));
                rsw.WriteLine();
                rsw.Write(string.Format("{0,-24}", lowestMaxTemp.Text));
                rsw.Write(string.Format("{0,-24}", highestMaxTemp.Text));
                rsw.WriteLine();
                rsw.Write(string.Format("{0,-24}", lowestPrecip.Text));
                rsw.Write(string.Format("{0,-24}", highestPrecip.Text));
                rsw.WriteLine();
                rsw.Write(string.Format("{0,-24}", lowestHumid.Text));
                rsw.Write(string.Format("{0,-24}", highestHumid.Text));
                rsw.WriteLine();
                rsw.Write(string.Format("{0,-24}", lowestHumid.Text));
                rsw.Write(string.Format("{0,-24}", highestHumid.Text));
                rsw.WriteLine("\n");
                rsw.WriteLine("------------------------------");
                rsw.WriteLine("All Results");
                rsw.WriteLine("------------------------------");
                rsw.Write(string.Format("{0,-18}", "City"));
                rsw.Write(string.Format("{0,-13}", "Date"));
                rsw.Write(string.Format("{0,-10}", "Min Temp"));
                rsw.Write(string.Format("{0,-10}", "Max Temp"));
                rsw.Write(string.Format("{0,-15}", "Precipitation"));
                rsw.Write(string.Format("{0,-10}", "Humidity"));
                rsw.Write(string.Format("{0,-12}", "Wind Speed"));
                rsw.WriteLine();
                rsw.WriteLine();
                for (int i = 0; i < reportGrid.Rows.Count; i++)
                {
                    rsw.Write(string.Format("{0,-18}", $"{reportGrid.Rows[i].Cells[0].Text}"));
                    rsw.Write(string.Format("{0,-13:d}", $"{reportGrid.Rows[i].Cells[1].Text}"));
                    rsw.Write(string.Format("{0,-10}", $"{HttpUtility.HtmlDecode(reportGrid.Rows[i].Cells[2].Text)}"));
                    rsw.Write(string.Format("{0,-10}", $"{HttpUtility.HtmlDecode(reportGrid.Rows[i].Cells[3].Text)}"));
                    rsw.Write(string.Format("{0,-15}", $"{reportGrid.Rows[i].Cells[4].Text}"));
                    rsw.Write(string.Format("{0,-10}", $"{reportGrid.Rows[i].Cells[5].Text}"));
                    rsw.Write(string.Format("{0,-12}", $"{reportGrid.Rows[i].Cells[6].Text}"));
                    rsw.WriteLine();
                }
            }
            Response.End();
        }

        //Clear the cities selected and update the DB
        protected void ClearButton_Click(object sender, EventArgs e)
        {
            citiesSelected.Clear();
            UpdateDBArrayLists();
            editMade[users.IndexOf(Login.loggedInUser)] = true;
            UpdateUserCityDB();
            cityReportBox.Text = "None";
        }
    }
}