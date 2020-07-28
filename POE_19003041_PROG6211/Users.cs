using System;
using System.Collections;
using System.IO;
using System.Windows.Forms;

namespace POE_19003041_PROG6211
{
    public partial class Users : Form
    {
        public Users()
        {
            InitializeComponent();
        }

        private string[] user;
        private ArrayList newUser;
        private Boolean passwordButtonStatus = true;

        //Prepare user form on load
        private void Users_Load(object sender, EventArgs e)
        {
            usersLabel.Location = new System.Drawing.Point((this.Size.Width / 2) - (usersLabel.Size.Width / 2), 39);
            loginStrip.Text = "Logged in as: " + Login.loggedInUser;
            UpdateUsersBox();
            userBox.SelectedIndex = 0;
        }

        //Repopulate Users Box
        private void UpdateUsersBox()
        {
            userBox.Items.Clear();
            user = System.IO.File.ReadAllLines("../../LoginDetails.txt");
            newUser = new ArrayList(user);
            for (int i = 0; i < (Weather.TotalLines(@"../../LoginDetails.txt") / 3); i++)
            {
                userBox.Items.Add(user[i * 3]);
            };
        }

        //Update information on click
        private void UserBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            usernameBox.Text = user[userBox.SelectedIndex * 3];
            passwordBox.Text = user[userBox.SelectedIndex * 3 + 1];
            if (user[userBox.SelectedIndex * 3 + 2] == "1")
            {
                userTypeBox.SelectedItem = "Forecaster";
            }
            else if (user[userBox.SelectedIndex * 3 + 2] == "2")
            {
                userTypeBox.SelectedItem = "Regular";
            }
            passwordButtonStatus = false;
            ShowHidePasswordButton_Click(sender, e);
        }

        //Update button
        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (usernameBox.Text != "" && passwordBox.Text != "")
            {
                DialogResult result = MessageBox.Show("This will update this user's information with the new information you have entered.\nAre you sure?", "Update User?", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    PasswordCheck newPasswordCheck = new PasswordCheck();
                    newPasswordCheck.ShowDialog();
                    if (PasswordCheck.allowUser == true)
                    {
                        string oldName = user[userBox.SelectedIndex * 3];
                        user[userBox.SelectedIndex * 3] = usernameBox.Text;
                        user[userBox.SelectedIndex * 3 + 1] = passwordBox.Text;
                        if (Convert.ToString(userTypeBox.SelectedItem) == "Forecaster")
                        {
                            user[userBox.SelectedIndex * 3 + 2] = "1";
                        }
                        else if (Convert.ToString(userTypeBox.SelectedItem) == "Regular")
                        {
                            user[userBox.SelectedIndex * 3 + 2] = "2";
                        }
                        System.IO.File.WriteAllLines("../../LoginDetails.txt", user);
                        MessageBox.Show("User " + oldName + " successfully updated.");
                        int tempIndex = userBox.SelectedIndex;
                        UpdateUsersBox();
                        userBox.SelectedIndex = tempIndex;
                    }
                }
            }
            else
            {
                MessageBox.Show("One or more fields are blank, please ensure the correct information is entered before updating or adding a user.", "Information Error");
            }
        }

        //Delete button
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("This will delete the currently selected user.\n\nAre you sure?", "Delete User?", MessageBoxButtons.YesNo);
            DialogResult resultSame;
            Boolean logout = false;
            if (result == DialogResult.Yes)
            {
                if (Convert.ToString(newUser[userBox.SelectedIndex * 3]) == Login.loggedInUser)
                {
                    resultSame = MessageBox.Show("Are you sure you want to delete the account you are currently logged in to?", "Delete Current Account?", MessageBoxButtons.YesNo);
                    logout = true;
                }
                else
                {
                    resultSame = DialogResult.Yes;
                }

                if (resultSame == DialogResult.Yes)
                {
                    PasswordCheck newPasswordCheck = new PasswordCheck();
                    newPasswordCheck.ShowDialog();
                    if (PasswordCheck.allowUser == true)
                    {
                        newUser.RemoveAt(userBox.SelectedIndex * 3 + 2);
                        newUser.RemoveAt(userBox.SelectedIndex * 3 + 1);
                        newUser.RemoveAt(userBox.SelectedIndex * 3);
                        user = (string[])newUser.ToArray(typeof(string));
                        File.WriteAllLines("../../LoginDetails.txt", user);
                        int tempIndex = userBox.SelectedIndex;
                        UpdateUsersBox();
                        userBox.SelectedIndex = tempIndex - 1;
                        if (logout == true)
                        {
                            LogoutToolStripMenuItem_Click(sender, e);
                        }
                    }
                }
            }
        }

        //Add (Plus) Button
        private void AddButton_Click(object sender, EventArgs e)
        {
            if (usernameBox.Text != "" && passwordBox.Text != "")
            {
                DialogResult result = MessageBox.Show("This will add a user with the current information in the fields, ensure it is correct.\nWould you like to add this user?", "Add User?", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    PasswordCheck newPasswordCheck = new PasswordCheck();
                    newPasswordCheck.ShowDialog();
                    if (PasswordCheck.allowUser == true)
                    {
                        newUser.Add(usernameBox.Text);
                        newUser.Add(passwordBox.Text);
                        if (Convert.ToString(userTypeBox.SelectedItem) == "Forecaster")
                        {
                            newUser.Add("1");
                        }
                        else if (Convert.ToString(userTypeBox.SelectedItem) == "Regular")
                        {
                            newUser.Add("2");
                        }
                        user = (string[])newUser.ToArray(typeof(string));
                        System.IO.File.WriteAllLines("../../LoginDetails.txt", user);
                        UpdateUsersBox();
                        MessageBox.Show("User " + usernameBox.Text + " successfully added.");
                        userBox.SelectedIndex = (newUser.Count / 3) - 1;
                    }
                }
            }
            else
            {
                MessageBox.Show("One or more fields are blank, please ensure the correct information is entered before updating or adding a user.", "Information Error");
            }
        }

        //Show/Hide Password Button
        private void ShowHidePasswordButton_Click(object sender, EventArgs e)
        {
            //Password button status = True if the password is hidden
            if (passwordButtonStatus == true)
            {
                PasswordCheck newPasswordCheck = new PasswordCheck();
                newPasswordCheck.ShowDialog();
                if (PasswordCheck.allowUser == true)
                {
                    passwordButtonStatus = false;
                    passwordBox.UseSystemPasswordChar = false;
                    showHidePasswordButton.BackgroundImage = POE_19003041_PROG6211.Properties.Resources.HidePassword;
                }
            }
            else
            {
                passwordButtonStatus = true;
                passwordBox.UseSystemPasswordChar = true;
                showHidePasswordButton.BackgroundImage = POE_19003041_PROG6211.Properties.Resources.ShowPassword;
            }
        }

        //Tool strip menus
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LogoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Report.firstTimeLoad = true;
            this.Hide();
            Login newLogin = new Login();
            newLogin.ShowDialog();
            this.Close();
        }

        private void CaptureStrip_Click(object sender, EventArgs e)
        {
            this.Hide();
            Capture newCapture = new Capture();
            newCapture.ShowDialog();
            this.Close();
        }

        private void ReportStrip_Click(object sender, EventArgs e)
        {
            this.Hide();
            Report reportForm = new Report();
            reportForm.ShowDialog();
            this.Close();
        }

        private void UpdateStrip_Click(object sender, EventArgs e)
        {
            this.Hide();
            Update newUpdate = new Update();
            newUpdate.ShowDialog();
            this.Close();
        }
    }
}