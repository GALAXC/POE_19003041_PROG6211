using System;
using System.Collections;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace POE_19003041_PROG6211
{
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
        }

        public static Boolean firstTimeLoad = true;
        private readonly ArrayList userCities = new ArrayList();
        private readonly ArrayList users = new ArrayList();
        private readonly ArrayList editMade = new ArrayList();
        private readonly ArrayList newUser = new ArrayList();
        private ArrayList citiesSelected = new ArrayList();
        private static readonly SqlConnection con = new SqlConnection();

        //Prepare report screen based on various details
        private void Report_Load(object sender, EventArgs e)
        {
            PopulateCityComboBox();
            loginStrip.Text = "Logged in as: " + Login.loggedInUser;
            UpdateCityBox();
            if (firstTimeLoad == true)
            {
                label6.Text = "Welcome, " + Login.loggedInUser + ".";
                label6.Location = new System.Drawing.Point((557 - (label6.Size.Width / 2)), 37);
                firstTimeLoad = false;
            }
            if (Login.isUserAdmin == false)
            {
                printReportButton.Visible = false;
                userTypeLoginStrip.Text = "User Type: Regular";
                viewStrip.Visible = false;
                searchButton.Location = new System.Drawing.Point(65, 319);
            }
            GetUsualCities();
            UpdateCityBox();
        }

        //
        //Code for Report section
        //

        //Populate the report city selection combo box
        private void PopulateCityComboBox()
        {
            cityComboBox.Items.Clear();
            for (int i = 0; i < (Weather.GetCityNameCount()); i++)
            {
                if (cityComboBox.Items.Contains(Weather.GetCityName(i)))
                {
                }
                else
                {
                    cityComboBox.Items.Add(Weather.GetCityName(i));
                }
            }
        }

        //Update cities on click
        private void CityComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (citiesSelected.Contains(cityComboBox.SelectedItem))
            {
                citiesSelected.Remove(cityComboBox.SelectedItem);
            }
            else
            {
                citiesSelected.Add(cityComboBox.SelectedItem);
            }
            editMade[users.IndexOf(Login.loggedInUser)] = true;
            UpdateDBArrayLists();
            UpdateCityBox();
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

        //Store cities user selects for next login
        private void GetUsualCities()
        {
            citiesSelected.Clear();
            users.Clear();
            userCities.Clear();
            newUser.Clear();
            editMade.Clear();
            String command = String.Format("SELECT * FROM TBL_USERCITIES");
            SetConnectionString();
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

        //Update selected cities box
        private void UpdateCityBox()
        {
            cityReportBox.Clear();
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

        //Update database with user cities selected
        public void UpdateUserCityDB()
        {
            for (int i = 0; i < newUser.Count; i++)
            {
                if (Convert.ToBoolean(newUser[i]) == true)
                {
                    String command = String.Format("INSERT INTO TBL_USERCITIES VALUES ('{0}','{1}');", Login.loggedInUser, userCities[i]);
                    SetConnectionString();
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
                        SetConnectionString();
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

        //Button to clear cities selected
        private void ClearCitiesSelected_Click(object sender, EventArgs e)
        {
            citiesSelected.Clear();
            UpdateDBArrayLists();
            editMade[users.IndexOf(Login.loggedInUser)] = true;
            cityReportBox.Text = "None";
        }

        //Update start date selected
        private void StartDateBox_ValueChanged(object sender, EventArgs e)
        {
            datesSelected.Text = startDateBox.Value.ToString("yyyy/MM/dd") + " - " + endDateBox.Value.ToString("yyyy/MM/dd");
        }

        //Update end date selected
        private void EndDateBox_ValueChanged(object sender, EventArgs e)
        {
            datesSelected.Text = startDateBox.Value.ToString("yyyy/MM/dd") + " - " + endDateBox.Value.ToString("yyyy/MM/dd");
        }

        //Retrieve report results
        private void SearchButton_Click(object sender, EventArgs e)
        {
            cityComboBox.Text = "Select City...";
            PopulateReportTable();
        }

        //Retrieve and compare the results for the weather report
        private void PopulateReportTable()
        {
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
            reportTable.Rows.Clear();
            if (citiesSelected.Count != 0)
            {
                for (int i = 0; i < citiesSelected.Count; i++)
                {
                    for (int j = 0; j < Weather.GetCityNameCount(); j++)
                    {
                        if (Weather.GetCityName(j) == Convert.ToString(citiesSelected[i]))
                        {
                            if (Weather.GetWeatherDate(j) >= startDateBox.Value && Weather.GetWeatherDate(j) <= endDateBox.Value)
                            {
                                if (reportTable.Rows.Count == 0)
                                {
                                    //Initiate values in the lowest and highest section
                                    lowMinTemp = Convert.ToInt32(Weather.GetMinTemp(j));
                                    highMinTemp = Convert.ToInt32(Weather.GetMinTemp(j));
                                    lowMaxTemp = Convert.ToInt32(Weather.GetMaxTemp(j));
                                    highMaxTemp = Convert.ToInt32(Weather.GetMaxTemp(j));
                                    lowPrecip = Convert.ToInt32(Weather.GetPrecipitation(j));
                                    highPrecip = Convert.ToInt32(Weather.GetPrecipitation(j));
                                    lowHumid = Convert.ToInt32(Weather.GetHumidity(j));
                                    highHumid = Convert.ToInt32(Weather.GetHumidity(j));
                                    lowSpeed = Convert.ToInt32(Weather.GetWindSpeed(j));
                                    highSpeed = Convert.ToInt32(Weather.GetWindSpeed(j));
                                }
                                else
                                {
                                    //Update values if lowest and highest section not empty
                                    if (Convert.ToInt32(Weather.GetMinTemp(j)) < lowMinTemp)
                                    {
                                        lowMinTemp = Convert.ToInt32(Weather.GetMinTemp(j));
                                    }

                                    if (Convert.ToInt32(Weather.GetMinTemp(j)) > highMinTemp)
                                    {
                                        highMinTemp = Convert.ToInt32(Weather.GetMinTemp(j));
                                    }

                                    if (Convert.ToInt32(Weather.GetMaxTemp(j)) < lowMaxTemp)
                                    {
                                        lowMaxTemp = Convert.ToInt32(Weather.GetMaxTemp(j));
                                    }

                                    if (Convert.ToInt32(Weather.GetMaxTemp(j)) > highMaxTemp)
                                    {
                                        highMaxTemp = Convert.ToInt32(Weather.GetMaxTemp(j));
                                    }

                                    if (Convert.ToInt32(Weather.GetPrecipitation(j)) < lowPrecip)
                                    {
                                        lowPrecip = Convert.ToInt32(Weather.GetPrecipitation(j));
                                    }

                                    if (Convert.ToInt32(Weather.GetPrecipitation(j)) > highPrecip)
                                    {
                                        highPrecip = Convert.ToInt32(Weather.GetPrecipitation(j));
                                    }

                                    if (Convert.ToInt32(Weather.GetHumidity(j)) < lowHumid)
                                    {
                                        lowHumid = Convert.ToInt32(Weather.GetHumidity(j));
                                    }

                                    if (Convert.ToInt32(Weather.GetHumidity(j)) > highHumid)
                                    {
                                        highHumid = Convert.ToInt32(Weather.GetHumidity(j));
                                    }

                                    if (Convert.ToInt32(Weather.GetWindSpeed(j)) < lowSpeed)
                                    {
                                        lowSpeed = Convert.ToInt32(Weather.GetWindSpeed(j));
                                    }

                                    if (Convert.ToInt32(Weather.GetWindSpeed(j)) > highSpeed)
                                    {
                                        highSpeed = Convert.ToInt32(Weather.GetWindSpeed(j));
                                    }
                                }
                                //Populate the table with the report
                                reportTable.Rows.Add(Weather.GetCityName(j), Weather.GetWeatherDate(j).ToShortDateString(), Weather.GetMinTemp(j) + "°C", Weather.GetMaxTemp(j) + "°C", Weather.GetPrecipitation(j) + "%", Weather.GetHumidity(j) + "%", Weather.GetWindSpeed(j) + "km/h");

                                lowestMinTemp.Text = Convert.ToString(lowMinTemp) + " °C";
                                highestMinTemp.Text = Convert.ToString(highMinTemp) + " °C";

                                lowestMaxTemp.Text = Convert.ToString(lowMaxTemp) + " °C";
                                highestMaxTemp.Text = Convert.ToString(highMaxTemp) + " °C";

                                lowestPrecip.Text = Convert.ToString(lowPrecip) + " %";
                                highestPrecip.Text = Convert.ToString(highPrecip) + " %";

                                lowestHumid.Text = Convert.ToString(lowHumid) + " %";
                                highestHumid.Text = Convert.ToString(highHumid) + " %";

                                lowestWind.Text = Convert.ToString(lowSpeed) + " km/h";
                                highestWind.Text = Convert.ToString(highSpeed) + " km/h";
                            }
                        }
                    }
                }
                //Reset report and display error
                if (reportTable.Rows.Count == 0)
                {
                    lowestMinTemp.Text = "";
                    highestMinTemp.Text = "";
                    lowestMaxTemp.Text = "";
                    highestMaxTemp.Text = "";
                    lowestPrecip.Text = "";
                    highestPrecip.Text = "";
                    lowestHumid.Text = "";
                    highestHumid.Text = "";
                    lowestWind.Text = "";
                    highestWind.Text = "";
                    MessageBox.Show("No Results Found.");
                }
            }
            else
            {
                MessageBox.Show("You have not selected any cities. \nTo obtain results, please select one or more cities.");
            }
        }

        //Create and Format printable REPORT based on results requested by admin
        private void PrintReportButton_Click(object sender, EventArgs e)
        {
            SearchButton_Click(sender, e);
            if (reportTable.Rows.Count > 0)
            {
                using (StreamWriter rsw = new StreamWriter("../../PrintableReport.txt"))
                {
                    rsw.WriteLine("------------------------------");
                    rsw.WriteLine("Report Details");
                    rsw.WriteLine("------------------------------");
                    rsw.WriteLine("\nDates Selected: " + datesSelected.Text);
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
                    rsw.Write(string.Format("{0,-24}", "Min Temp: " + lowestMinTemp.Text));
                    rsw.Write(string.Format("{0,-24}", "Min Temp: " + highestMinTemp.Text));
                    rsw.WriteLine();
                    rsw.Write(string.Format("{0,-24}", "Max Temp: " + lowestMaxTemp.Text));
                    rsw.Write(string.Format("{0,-24}", "Max Temp: " + highestMaxTemp.Text));
                    rsw.WriteLine();
                    rsw.Write(string.Format("{0,-24}", "Precipitation: " + lowestPrecip.Text));
                    rsw.Write(string.Format("{0,-24}", "Precipitation: " + highestPrecip.Text));
                    rsw.WriteLine();
                    rsw.Write(string.Format("{0,-24}", "Humidity: " + lowestHumid.Text));
                    rsw.Write(string.Format("{0,-24}", "Humidity: " + highestHumid.Text));
                    rsw.WriteLine();
                    rsw.Write(string.Format("{0,-24}", "Wind Speed: " + lowestHumid.Text));
                    rsw.Write(string.Format("{0,-24}", "Wind Speed: " + highestHumid.Text));
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
                    for (int i = 0; i < reportTable.Rows.Count; i++)
                    {
                        rsw.Write(string.Format("{0,-18}", $"{reportTable.Rows[i].Cells[0].Value}"));
                        rsw.Write(string.Format("{0,-13:d}", $"{reportTable.Rows[i].Cells[1].Value}"));
                        rsw.Write(string.Format("{0,-10}", $"{reportTable.Rows[i].Cells[2].Value}"));
                        rsw.Write(string.Format("{0,-10}", $"{reportTable.Rows[i].Cells[3].Value}"));
                        rsw.Write(string.Format("{0,-15}", $"{reportTable.Rows[i].Cells[4].Value}"));
                        rsw.Write(string.Format("{0,-10}", $"{reportTable.Rows[i].Cells[5].Value}"));
                        rsw.Write(string.Format("{0,-12}", $"{reportTable.Rows[i].Cells[6].Value}"));
                        rsw.WriteLine();
                    }
                }
                DialogResult result = MessageBox.Show("Report successfully created with " + reportTable.Rows.Count + " results.\n\nThis report can be found at: \n\n" + Path.GetFullPath("../../PrintableReport.txt") + "\n\nWould you like to open the report now?", "Report Created", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    Process.Start(@Path.GetFullPath("../../PrintableReport.txt"));
                }
                else
                {
                }
            }
            else
            {
                MessageBox.Show("Report not created! There are no results found in the report table. Please search for existing results and try again.");
            }
        }

        //Setting up database connection
        private static void SetConnectionString()
        {
            String path = System.IO.Path.GetFullPath(AppDomain.CurrentDomain.BaseDirectory + "../../../POE_19003041_PROG6211_WEB/App_Data");
            AppDomain.CurrentDomain.SetData("DataDirectory", path);
            con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\POE_Database.mdf;Integrated Security=True";
        }

        //Tool strip menus
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateUserCityDB();
            this.Close();
        }

        private void LogoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateUserCityDB();
            firstTimeLoad = true;
            this.Hide();
            Login newLogin = new Login();
            newLogin.ShowDialog();
            this.Close();
        }

        private void CaptureStrip_Click(object sender, EventArgs e)
        {
            UpdateUserCityDB();
            this.Hide();
            Capture newCapture = new Capture();
            newCapture.ShowDialog();
            this.Close();
        }

        private void UpdateStrip_Click(object sender, EventArgs e)
        {
            UpdateUserCityDB();
            this.Hide();
            Update newUpdate = new Update();
            newUpdate.ShowDialog();
            this.Close();
        }

        private void UsersStrip_Click(object sender, EventArgs e)
        {
            UpdateUserCityDB();
            this.Hide();
            Users newUsers = new Users();
            newUsers.ShowDialog();
            this.Close();
        }
    }
}