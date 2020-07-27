using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POE_19003041_PROG6211
{
    public partial class Update : Form
    {
        public Update()
        {
            InitializeComponent();
        }

        private Boolean valuesGood = true;

        //Set up screen on log in
        private void Edit_Load(object sender, EventArgs e)
        {
            updateUpdateBox();
            updateLabel.Location = new System.Drawing.Point((this.Size.Width / 2) - (updateLabel.Size.Width / 2), 39);
            loginStrip.Text = "Logged in as: " + Login.loggedInUser;
            if (editBox.Items.Count != 0)
            {
                editBox.SelectedIndex = 0;
            }
        }

        //Display details of result on click
        private void editBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            cityBox.Text = Weather.getCityName(editBox.SelectedIndex);
            dateInputBox.Value = Weather.getWeatherDate(editBox.SelectedIndex);
            minTempBox.Text = Weather.getMinTemp(editBox.SelectedIndex);
            maxTempBox.Text = Weather.getMaxTemp(editBox.SelectedIndex);
            precipBox.Text = Weather.getPrecipitation(editBox.SelectedIndex);
            humidBox.Text = Weather.getHumidity(editBox.SelectedIndex);
            windBox.Text = Weather.getWindSpeed(editBox.SelectedIndex);
        }

        //Update currently selected result with new details
        private void updateButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("This will update the selected forecast with the new information you have entered.\nAre you sure?", "Update Forecast?", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                checkValues();
                if (valuesGood == true && cityBox.Text != "")
                {
                    PasswordCheck newPasswordCheck = new PasswordCheck();
                    newPasswordCheck.ShowDialog();
                    if (PasswordCheck.allowUser == true)
                    {
                        string[] lines = System.IO.File.ReadAllLines("../../WeatherData.txt");
                        lines[editBox.SelectedIndex * 7] = cityBox.Text;
                        lines[editBox.SelectedIndex * 7 + 1] = Convert.ToString(dateInputBox.Value);
                        lines[editBox.SelectedIndex * 7 + 2] = Convert.ToString(minTempBox.Text);
                        lines[editBox.SelectedIndex * 7 + 3] = Convert.ToString(maxTempBox.Text);
                        lines[editBox.SelectedIndex * 7 + 4] = Convert.ToString(precipBox.Text);
                        lines[editBox.SelectedIndex * 7 + 5] = Convert.ToString(humidBox.Text);
                        lines[editBox.SelectedIndex * 7 + 6] = Convert.ToString(windBox.Text);
                        System.IO.File.WriteAllLines("../../WeatherData.txt", lines);
                        MessageBox.Show("You have successfully updated this weather entry.");
                        int oldIndex = editBox.SelectedIndex;
                        updateUpdateBox();
                        editBox.SelectedIndex = oldIndex;
                    }
                }
                else
                {
                    MessageBox.Show("The data you have entered is incorrect. \nPlease make sure that: \n- No fields are empty.\n- There are no numbers in the city input field.\n- There are no letters in the in the number fields.");
                }
            }
            else
            {
            }
        }

        //Update the result box
        private void updateUpdateBox()
        {
            editBox.Items.Clear();
            for (int i = 0; i < (Weather.TotalLines(@"../../WeatherData.txt") / 7); i++)
            {
                editBox.Items.Add(Weather.getCityName(i) + " - " + Weather.getWeatherDate(i));
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

        //Tool Strip Items
        private void exitStrip_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void logoutStrip_Click(object sender, EventArgs e)
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
            reportForm.ShowDialog();
            this.Close();
        }

        private void captureStrip_Click(object sender, EventArgs e)
        {
            this.Hide();
            Capture newCapture = new Capture();
            newCapture.ShowDialog();
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