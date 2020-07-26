using System;
using System.Windows.Forms;

namespace POE_19003041_PROG6211
{
    public partial class Capture : Form
    {
        public Capture()
        {
            InitializeComponent();
        }

        private bool valuesGood = true;
        public bool firstLoad = true;

        //Update logged in user
        private void Capture_Load(object sender, EventArgs e)
        {
            loginStrip.Text = "Logged in as: " + Login.loggedInUser;
        }

        //
        //Capture section Code
        //
        private void submitButton_Click(object sender, EventArgs e)
        {
            checkValues();
            if (valuesGood == true && cityBox.Text != "")
            {
                //Add values to relevant arrays if data is input correctly
                if (cityBox.Items.Contains(cityBox.Text))
                {
                    Weather.addCityName(cityBox.Items[cityBox.Items.IndexOf(cityBox.Text)]);
                }
                else
                {
                    Weather.addCityName(cityBox.Text);
                }
                Weather.addWeatherDate(dateInputBox.Value);
                Weather.addMinTemp(minTempBox.Text);
                Weather.addMaxTemp(maxTempBox.Text);
                Weather.addPrecipitation(precipBox.Text);
                Weather.addHumidity(humidBox.Text);
                Weather.addWindSpeed(windBox.Text);
                Weather.populateArrayLists();
                MessageBox.Show("Data Captured Successfully.");
            }
            else
            {
                MessageBox.Show("The data you have entered is incorrect. \nPlease make sure that: \n- No fields are empty.\n- There are no numbers in the city input field.\n- There are no letters in the in the number fields.");
            }
        }

        //Check if any incorrect values have been copy pasted into capture boxes
        private void checkValues()
        {
            valuesGood = true;
            valueCheckText(cityBox.Text, 0);
            valueCheck(minTempBox.Text, 0);
            valueCheck(maxTempBox.Text, 0);
            valueCheck(precipBox.Text, 0);
            valueCheck(humidBox.Text, 0);
            valueCheck(windBox.Text, 0);
        }

        //Clear the values from the capture section
        private void ClearButton_Click(object sender, EventArgs e)
        {
            cityBox.Text = "";
            minTempBox.Text = "0";
            maxTempBox.Text = "0";
            precipBox.Text = "0";
            humidBox.Text = "0";
            windBox.Text = "0";
        }

        //Check numeric values are entered correctly
        private void valueCheck(string tempVar1, int tempOut1)
        {
            if ((int.TryParse(tempVar1, out tempOut1)) && valuesGood == true)
            {
            }
            else
            {
                valuesGood = false;
            }
        }

        //Check text values are entered correctly
        private void valueCheckText(string tempVar1, int tempOut1)
        {
            if ((int.TryParse(tempVar1, out tempOut1)) && valuesGood == true)
            {
                valuesGood = false;
            }
            else
            {
            }
        }

        /*
        Prevent incorrect intial input
        */

        //For city box
        private void CityBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '-')
            {
                e.Handled = true;
                MessageBox.Show("You may only enter alphabetical letters into this box.");
            }
        }

        //For min temp box
        private void MinTempBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '-')
            {
                e.Handled = true;
                MessageBox.Show("You may only enter a temperature into this box.");
            }
            if (e.KeyChar == '-')
            {
                if (minTempBox.Text.StartsWith("-"))
                {
                    e.Handled = true;
                }
            }
        }

        private void minTempBox_TextChanged(object sender, EventArgs e)
        {
            if (minTempBox.Text == "")
            {
                minTempBox.Text = "0";
            }
            if (minTempBox.Text.IndexOf("-") > 0)
            {
                minTempBox.Text = minTempBox.Text.Remove(minTempBox.Text.IndexOf("-"), 1);
                minTempBox.Text = "-" + minTempBox.Text;
            }
        }

        //For max temp box
        private void MaxTempBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '-')
            {
                e.Handled = true;
                MessageBox.Show("You may only enter a temperature into this box.");
            }
            if (e.KeyChar == '-')
            {
                if (maxTempBox.Text.StartsWith("-"))
                {
                    e.Handled = true;
                }
            }
        }

        private void maxTempBox_TextChanged(object sender, EventArgs e)
        {
            if (maxTempBox.Text == "")
            {
                maxTempBox.Text = "0";
            }
            if (maxTempBox.Text.IndexOf("-") > 0)
            {
                maxTempBox.Text = maxTempBox.Text.Remove(maxTempBox.Text.IndexOf("-"), 1);
                maxTempBox.Text = "-" + maxTempBox.Text;
            }
        }

        //For precipitation box
        private void PrecipBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("You may only enter a number into this box.");
            }
        }

        private void PrecipBox_TextChanged(object sender, EventArgs e)
        {
            if (precipBox.Text == "")
            {
                precipBox.Text = "0";
            }
            int successInt;
            if (int.TryParse(precipBox.Text, out successInt))
            {
                if (successInt > 100)
                {
                    precipBox.Text = "100";
                }
            }
        }

        //For humidity box
        private void HumidBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("You may only enter a number into this box.");
            }
        }

        private void humidBox_TextChanged(object sender, EventArgs e)
        {
            if (humidBox.Text == "")
            {
                humidBox.Text = "0";
            }
            int successInt;
            if (int.TryParse(humidBox.Text, out successInt))
            {
                if (successInt > 100)
                {
                    humidBox.Text = "100";
                }
            }
        }

        //For wind speed box
        private void WindBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("You may only enter a number into this box.");
            }
        }

        private void windBox_TextChanged(object sender, EventArgs e)
        {
            if (windBox.Text == "")
            {
                windBox.Text = "0";
            }
        }

        //
        //End of preventing intial incorrect input
        //

        //
        //Menu Strip Items
        //
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Report.firstTimeLoad = true;
            this.Hide();
            Login newLogin = new Login();
            newLogin.ShowDialog();
            this.Close();
        }

        private void reportStrip_Click(object sender, EventArgs e)
        {
            this.Hide();
            Report reportForm = new Report();
            Weather.populateArrayLists();
            reportForm.ShowDialog();
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