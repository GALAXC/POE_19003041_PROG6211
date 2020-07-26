using System;
using System.Collections;
using System.Diagnostics;
using System.IO;
using System.Linq;
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
        private ArrayList userCities = new ArrayList(File.ReadAllLines("../../UserCities.txt"));
        private int userLine;
        private ArrayList citiesSelected = new ArrayList();
        private string[] userCitiesFile;

        //Prepare report screen based on various details
        private void Report_Load(object sender, EventArgs e)
        {
            populateCityComboBox();
            loginStrip.Text = "Logged in as: " + Login.loggedInUser;
            getUsualCities();
            updateCityBox();
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
        }

        //
        //Code for Report section
        //

        //Populate the report city selection combo box
        private void populateCityComboBox()
        {
            cityComboBox.Items.Clear();
            for (int i = 0; i < (Weather.getCityNameCount()); i++)
            {
                if (cityComboBox.Items.Contains(Weather.getCityName(i)))
                {
                }
                else
                {
                    cityComboBox.Items.Add(Weather.getCityName(i));
                }
            }
        }

        //Update cities on click
        private void cityComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            getUsualCities();
            if (citiesSelected.Contains(cityComboBox.SelectedItem))
            {
                citiesSelected.Remove(cityComboBox.SelectedItem);
            }
            else
            {
                citiesSelected.Add(cityComboBox.SelectedItem);
            }
            userCities[userLine] = "";
            for (int i = 0; i < citiesSelected.Count; i++)
            {
                if (i == 0)
                {
                    userCities[userLine] += Convert.ToString(citiesSelected[0]);
                }
                else
                {
                    userCities[userLine] += "," + Convert.ToString(citiesSelected[i]);
                }
            }
            userCitiesFile = (string[])userCities.ToArray(typeof(string));
            File.WriteAllLines("../../UserCities.txt", userCitiesFile);
            updateCityBox();
        }

        //Store cities user selects for next login
        private void getUsualCities()
        {
            citiesSelected.Clear();
            if (userCities.Contains(Login.loggedInUser))
            {
                for (int i = 0; i < userCities.Count; i++)
                {
                    if (Login.loggedInUser == Convert.ToString(userCities[i]))
                    {
                        userLine = i + 1;
                        if (Convert.ToString(userCities[i + 1]) == "None")
                        {
                        }
                        else
                        {
                            citiesSelected = new ArrayList(Convert.ToString(userCities[i + 1]).Split(','));
                            break;
                        }
                    }
                }
            }
            else
            {
                userLine = userCities.Count + 1;
                userCities.Add(Login.loggedInUser);
                userCities.Add("Cape Town,Johannesburg");
                citiesSelected = new ArrayList { "Cape Town", "Johannesburg" };
            }
        }

        //Update selected cities
        private void updateCityBox()
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

        //Button to clear cities selected
        private void clearCitiesSelected_Click(object sender, EventArgs e)
        {
            citiesSelected.Clear();
            userCities[userLine] = "None";
            userCitiesFile = (string[])userCities.ToArray(typeof(string));
            File.WriteAllLines("../../UserCities.txt", userCitiesFile);
            updateCityBox();
            cityReportBox.Text = "None";
        }

        //Update start date selected
        private void startDateBox_ValueChanged(object sender, EventArgs e)
        {
            datesSelected.Text = startDateBox.Value.ToString("yyyy/MM/dd") + " - " + endDateBox.Value.ToString("yyyy/MM/dd");
        }

        //Update end date selected
        private void endDateBox_ValueChanged(object sender, EventArgs e)
        {
            datesSelected.Text = startDateBox.Value.ToString("yyyy/MM/dd") + " - " + endDateBox.Value.ToString("yyyy/MM/dd");
        }

        //Initiate process to retrieve report results
        private void searchButton_Click(object sender, EventArgs e)
        {
            cityComboBox.Text = "Select City...";
            populateReportTable();
        }

        //Retrieve and compare the results for the weather report
        private void populateReportTable()
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
                    for (int j = 0; j < Weather.getCityNameCount(); j++)
                    {
                        if (Weather.getCityName(j) == Convert.ToString(citiesSelected[i]))
                        {
                            if (Weather.getWeatherDate(j) >= startDateBox.Value && Weather.getWeatherDate(j) <= endDateBox.Value)
                            {
                                if (reportTable.Rows.Count == 0)
                                {
                                    //Initiate values in the lowest and highest section
                                    lowMinTemp = Convert.ToInt32(Weather.getMinTemp(j));
                                    highMinTemp = Convert.ToInt32(Weather.getMinTemp(j));
                                    lowMaxTemp = Convert.ToInt32(Weather.getMaxTemp(j));
                                    highMaxTemp = Convert.ToInt32(Weather.getMaxTemp(j));
                                    lowPrecip = Convert.ToInt32(Weather.getPrecipitation(j));
                                    highPrecip = Convert.ToInt32(Weather.getPrecipitation(j));
                                    lowHumid = Convert.ToInt32(Weather.getHumidity(j));
                                    highHumid = Convert.ToInt32(Weather.getHumidity(j));
                                    lowSpeed = Convert.ToInt32(Weather.getWindSpeed(j));
                                    highSpeed = Convert.ToInt32(Weather.getWindSpeed(j));
                                }
                                else
                                {
                                    //Update values if lowest and highest section not empty
                                    if (Convert.ToInt32(Weather.getMinTemp(j)) < lowMinTemp)
                                    {
                                        lowMinTemp = Convert.ToInt32(Weather.getMinTemp(j));
                                    }

                                    if (Convert.ToInt32(Weather.getMinTemp(j)) > highMinTemp)
                                    {
                                        highMinTemp = Convert.ToInt32(Weather.getMinTemp(j));
                                    }

                                    if (Convert.ToInt32(Weather.getMaxTemp(j)) < lowMaxTemp)
                                    {
                                        lowMaxTemp = Convert.ToInt32(Weather.getMaxTemp(j));
                                    }

                                    if (Convert.ToInt32(Weather.getMaxTemp(j)) > highMaxTemp)
                                    {
                                        highMaxTemp = Convert.ToInt32(Weather.getMaxTemp(j));
                                    }

                                    if (Convert.ToInt32(Weather.getPrecipitation(j)) < lowPrecip)
                                    {
                                        lowPrecip = Convert.ToInt32(Weather.getPrecipitation(j));
                                    }

                                    if (Convert.ToInt32(Weather.getPrecipitation(j)) > highPrecip)
                                    {
                                        highPrecip = Convert.ToInt32(Weather.getPrecipitation(j));
                                    }

                                    if (Convert.ToInt32(Weather.getHumidity(j)) < lowHumid)
                                    {
                                        lowHumid = Convert.ToInt32(Weather.getHumidity(j));
                                    }

                                    if (Convert.ToInt32(Weather.getHumidity(j)) > highHumid)
                                    {
                                        highHumid = Convert.ToInt32(Weather.getHumidity(j));
                                    }

                                    if (Convert.ToInt32(Weather.getWindSpeed(j)) < lowSpeed)
                                    {
                                        lowSpeed = Convert.ToInt32(Weather.getWindSpeed(j));
                                    }

                                    if (Convert.ToInt32(Weather.getWindSpeed(j)) > highSpeed)
                                    {
                                        highSpeed = Convert.ToInt32(Weather.getWindSpeed(j));
                                    }
                                }
                                //Populate the table with the report
                                reportTable.Rows.Add(Weather.getCityName(j), Weather.getWeatherDate(j).ToShortDateString(), Weather.getMinTemp(j) + "°C", Weather.getMaxTemp(j) + "°C", Weather.getPrecipitation(j) + "%", Weather.getHumidity(j) + "%", Weather.getWindSpeed(j) + "km/h");

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
        private void printReportButton_Click(object sender, EventArgs e)
        {
            searchButton_Click(sender, e);
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
                        rsw.Write(string.Format("{0,-18}", $"{reportTable.Rows[i].Cells[0].Value.ToString()}"));
                        rsw.Write(string.Format("{0,-13:d}", $"{reportTable.Rows[i].Cells[1].Value.ToString()}"));
                        rsw.Write(string.Format("{0,-10}", $"{reportTable.Rows[i].Cells[2].Value.ToString()}"));
                        rsw.Write(string.Format("{0,-10}", $"{reportTable.Rows[i].Cells[3].Value.ToString()}"));
                        rsw.Write(string.Format("{0,-15}", $"{reportTable.Rows[i].Cells[4].Value.ToString()}"));
                        rsw.Write(string.Format("{0,-10}", $"{reportTable.Rows[i].Cells[5].Value.ToString()}"));
                        rsw.Write(string.Format("{0,-12}", $"{reportTable.Rows[i].Cells[6].Value.ToString()}"));
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

        //Tool strip menus
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            firstTimeLoad = true;
            this.Hide();
            Login newLogin = new Login();
            newLogin.ShowDialog();
            this.Close();
        }

        private void captureStrip_Click(object sender, EventArgs e)
        {
            this.Hide();
            Capture newCapture = new Capture();
            newCapture.ShowDialog();
            this.Close();
        }

        private void updateStrip_Click(object sender, EventArgs e)
        {
            this.Hide();
            Update newUpdate = new Update();
            newUpdate.ShowDialog();
            this.Close();
        }

        private void usersStrip_Click(object sender, EventArgs e)
        {
            this.Hide();
            Users newUsers = new Users();
            newUsers.ShowDialog();
            this.Close();
        }
    }
}