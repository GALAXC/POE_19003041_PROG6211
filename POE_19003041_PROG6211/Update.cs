using System;
using System.Data.SqlClient;
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
            UpdateUpdateBox();
            updateLabel.Location = new System.Drawing.Point((this.Size.Width / 2) - (updateLabel.Size.Width / 2), 39);
            loginStrip.Text = "Logged in as: " + Login.loggedInUser;
            if (editBox.Items.Count != 0)
            {
                editBox.SelectedIndex = 0;
            }
        }

        //Display details of entry on click
        private void EditBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            cityBox.Text = Weather.GetCityName(editBox.SelectedIndex);
            dateInputBox.Value = Weather.GetWeatherDate(editBox.SelectedIndex);
            minTempBox.Text = Weather.GetMinTemp(editBox.SelectedIndex);
            maxTempBox.Text = Weather.GetMaxTemp(editBox.SelectedIndex);
            precipBox.Text = Weather.GetPrecipitation(editBox.SelectedIndex);
            humidBox.Text = Weather.GetHumidity(editBox.SelectedIndex);
            windBox.Text = Weather.GetWindSpeed(editBox.SelectedIndex);
        }

        //Update currently selected result with new details in textboxes
        private void UpdateButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("This will update the selected forecast with the new information you have entered.\nAre you sure?", "Update Forecast?", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                CheckValues();
                if (valuesGood == true && cityBox.Text != "")
                {
                    PasswordCheck newPasswordCheck = new PasswordCheck();
                    newPasswordCheck.ShowDialog();
                    if (PasswordCheck.allowUser == true)
                    {                        
                        if (Weather.UpdateWeatherDatabase(cityBox.Text, dateInputBox.Value, minTempBox.Text, maxTempBox.Text, precipBox.Text, humidBox.Text, windBox.Text, Weather.GetCityName(editBox.SelectedIndex), Weather.GetWeatherDate(editBox.SelectedIndex)) == true)
                        {
                            MessageBox.Show("You have successfully updated this weather entry.");
                            int oldIndex = editBox.SelectedIndex;
                            UpdateUpdateBox();
                            editBox.SelectedIndex = oldIndex;
                        }
                        else
                        {
                            MessageBox.Show("There was an error performing this action.\nDatabase likely not connected correctly.");
                        }
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
        private void UpdateUpdateBox()
        {
            editBox.Items.Clear();
            for (int i = 0; i < Weather.GetCityNameCount(); i++)
            {
                editBox.Items.Add(Weather.GetCityName(i) + " - " + Weather.GetWeatherDate(i));
            }
        }

        //Check if any incorrect values have been copy pasted into capture boxes
        private void CheckValues()
        {
            valuesGood = true;
            ValueCheckText(cityBox.Text);
            ValueCheck(minTempBox.Text);
            ValueCheck(maxTempBox.Text);
            ValueCheck(precipBox.Text);
            ValueCheck(humidBox.Text);
            ValueCheck(windBox.Text);
        }

        //Check numeric values are entered correctly
        private void ValueCheck(string tempVar1)
        {
            if ((int.TryParse(tempVar1, out _)) && valuesGood == true)
            {
            }
            else
            {
                valuesGood = false;
            }
        }

        //Check text values are entered correctly
        private void ValueCheckText(string tempVar1)
        {
            if ((int.TryParse(tempVar1, out _)) && valuesGood == true)
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

        private void MinTempBox_TextChanged(object sender, EventArgs e)
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

        private void MaxTempBox_TextChanged(object sender, EventArgs e)
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
            if (int.TryParse(precipBox.Text, out int successInt))
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

        private void HumidBox_TextChanged(object sender, EventArgs e)
        {
            if (humidBox.Text == "")
            {
                humidBox.Text = "0";
            }
            if (int.TryParse(humidBox.Text, out int successInt))
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

        private void WindBox_TextChanged(object sender, EventArgs e)
        {
            if (windBox.Text == "")
            {
                windBox.Text = "0";
            }
        }

        //Tool Strip Items
        private void ExitStrip_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LogoutStrip_Click(object sender, EventArgs e)
        {
            Report.firstTimeLoad = true;
            this.Hide();
            Login newLogin = new Login();
            newLogin.ShowDialog();
            this.Close();
        }

        private void ReportStrip_Click(object sender, EventArgs e)
        {
            this.Hide();
            Report reportForm = new Report();
            reportForm.ShowDialog();
            this.Close();
        }

        private void CaptureStrip_Click(object sender, EventArgs e)
        {
            this.Hide();
            Capture newCapture = new Capture();
            newCapture.ShowDialog();
            this.Close();
        }

        private void UsersStrip_Click(object sender, EventArgs e)
        {
            this.Hide();
            Users newUsers = new Users();
            newUsers.ShowDialog();
            this.Close();
        }
    }
}