using System;
using System.Collections;
using System.IO;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace POE_19003041_PROG6211
{
    public partial class Users : Form
    {
        public Users()
        {
            InitializeComponent();
        }

        private Boolean passwordButtonStatus = true;
        private ArrayList usernameList;
        private ArrayList passwordList;
        private ArrayList userType;
        private static readonly SqlConnection con = new SqlConnection();

        //Prepare form and query login details from database on user form load
        private void Users_Load(object sender, EventArgs e)
        {
            usersLabel.Location = new System.Drawing.Point((this.Size.Width / 2) - (usersLabel.Size.Width / 2), 39);
            loginStrip.Text = "Logged in as: " + Login.loggedInUser;
            String command = "SELECT * FROM TBL_LOGINDETAILS;";
            SetConnectionString();
            con.Open();
            using (con)
            {
                SqlCommand SQLusernames = new SqlCommand(command, con);
                SqlDataReader usernames = SQLusernames.ExecuteReader();
                usernameList = new ArrayList();
                passwordList = new ArrayList();
                userType = new ArrayList();
                if (usernames.HasRows)
                {
                    while (usernames.Read())
                    {
                        usernameList.Add(usernames.GetValue(0));
                        passwordList.Add(usernames.GetValue(1));
                        userType.Add(usernames.GetValue(2));
                    }
                }
            }
            UpdateUsersBox();
            userBox.SelectedIndex = 0;
        }

        //Update the username selection box
        private void UpdateUsersBox()
        {
            userBox.Items.Clear();
            for (int i = 0; i < usernameList.Count; i++)
            {
                userBox.Items.Add(usernameList[i]);
            };
        }

        //Update textbox information on username click
        private void UserBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            usernameBox.Text = Convert.ToString(usernameList[userBox.SelectedIndex]);
            passwordBox.Text = Convert.ToString(passwordList[userBox.SelectedIndex]);
            if (Convert.ToString(userType[userBox.SelectedIndex]) == "1")
            {
                userTypeBox.SelectedItem = "Forecaster";
            }
            else if (Convert.ToString(userType[userBox.SelectedIndex]) == "2")
            {
                userTypeBox.SelectedItem = "Regular";
            }
            passwordButtonStatus = false;
            ShowHidePasswordButton_Click(sender, e);
        }

        //Update button to update database with new details
        private void UpdateButton_Click(object sender, EventArgs e)
        {
            int tempType = 2;
            if (usernameBox.Text != "" && passwordBox.Text != "")
            {
                DialogResult result = MessageBox.Show("This will update this user's information with the new information you have entered.\nAre you sure?", "Update User?", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    PasswordCheck newPasswordCheck = new PasswordCheck();
                    newPasswordCheck.ShowDialog();
                    if (PasswordCheck.allowUser == true)
                    {
                        string oldName = Convert.ToString(usernameList[userBox.SelectedIndex]);
                        if (Convert.ToString(userTypeBox.SelectedItem) == "Forecaster")
                        {
                            tempType = 1;
                        }
                        if (Convert.ToString(userTypeBox.SelectedItem) == "Regular")
                        {
                            tempType = 2;
                        }
                        usernameList[userBox.SelectedIndex] = usernameBox.Text;
                        passwordList[userBox.SelectedIndex] = passwordBox.Text;
                        userType[userBox.SelectedIndex] = tempType;
                        String command = String.Format("UPDATE TBL_LOGINDETAILS SET USERNAME = '{0}', PASSWORD = '{1}', USERTYPE = '{2}' WHERE USERNAME = '{3}';", usernameBox.Text, passwordBox.Text, tempType, oldName);
                        SetConnectionString();
                        con.Open();
                        using (con)
                        {
                            SqlCommand sqlUpdate = new SqlCommand(command, con);
                            try
                            {
                                sqlUpdate.ExecuteNonQuery();
                                MessageBox.Show("User " + oldName + " successfully updated.");
                            }
                            catch
                            {
                                MessageBox.Show("There was an error performing this action.\nDatabase likely not connected.");
                            }
                        }
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

        //Delete button to remove selected username from database
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("This will delete the currently selected user.\n\nAre you sure?", "Delete User?", MessageBoxButtons.YesNo);
            DialogResult resultSame;
            Boolean logout = false;
            if (result == DialogResult.Yes)
            {
                if (Convert.ToString(usernameList[userBox.SelectedIndex]) == Login.loggedInUser)
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
                        string oldName = Convert.ToString(usernameList[userBox.SelectedIndex]);

                        usernameList.RemoveAt(userBox.SelectedIndex);
                        passwordList.RemoveAt(userBox.SelectedIndex);
                        userType.RemoveAt(userBox.SelectedIndex);

                        String command = String.Format("DELETE FROM TBL_USERCITIES WHERE USERNAME = '{0}';", oldName);
                        SetConnectionString();
                        con.Open();
                        using (con)
                        {
                            SqlCommand sqlDelete1 = new SqlCommand(command, con);
                            try
                            {
                                sqlDelete1.ExecuteNonQuery();
                            }
                            catch
                            {
                                MessageBox.Show("There was an error performing this action.\nDatabase likely not connected.");
                            }
                        }

                        String command2 = String.Format("DELETE FROM TBL_LOGINDETAILS WHERE USERNAME = '{0}';", oldName);
                        SetConnectionString();
                        con.Open();
                        using (con)
                        {
                            SqlCommand sqlDelete2 = new SqlCommand(command2, con);
                            try
                            {
                                sqlDelete2.ExecuteNonQuery();
                                MessageBox.Show("User " + oldName + " successfully deleted.");
                            }
                            catch
                            {
                                MessageBox.Show("There was an error performing this action.\nDatabase likely not connected.");
                            }
                        }
                        int tempIndex = userBox.SelectedIndex;
                        UpdateUsersBox();
                        if (tempIndex == 0)
                        {
                            userBox.SelectedIndex = tempIndex;
                        }
                        else
                        {
                            userBox.SelectedIndex = tempIndex - 1;
                        }
                        if (logout == true)
                        {
                            LogoutToolStripMenuItem_Click(sender, e);
                        }
                    }
                }
            }
        }

        //Add button to add user with information in textbox
        private void AddButton_Click(object sender, EventArgs e)
        {
            int tempType = 2;
            if (usernameBox.Text != "" && passwordBox.Text != "")
            {
                if (!usernameList.Contains(usernameBox.Text))
                {
                    DialogResult result = MessageBox.Show("This will add a user with the current information in the fields, ensure it is correct.\nWould you like to add this user?", "Add User?", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        PasswordCheck newPasswordCheck = new PasswordCheck();
                        newPasswordCheck.ShowDialog();
                        if (PasswordCheck.allowUser == true)
                        {
                            if (Convert.ToString(userTypeBox.SelectedItem) == "Forecaster")
                            {
                                tempType = 1;
                            }
                            if (Convert.ToString(userTypeBox.SelectedItem) == "Regular")
                            {
                                tempType = 2;
                            }
                            usernameList.Add(usernameBox.Text);
                            passwordList.Add(passwordBox.Text);
                            userType.Add(tempType);
                            String command = String.Format("INSERT INTO TBL_LOGINDETAILS VALUES ('{0}','{1}',{2});", usernameBox.Text, passwordBox.Text, tempType);
                            SetConnectionString();
                            con.Open();
                            using (con)
                            {
                                SqlCommand sqlAdd = new SqlCommand(command, con);
                                try
                                {
                                    sqlAdd.ExecuteNonQuery();
                                    MessageBox.Show("User " + usernameBox.Text + " successfully added.");
                                }
                                catch
                                {
                                    MessageBox.Show("There was an error performing this action.\nDatabase likely not connected.");
                                }
                            }
                            UpdateUsersBox();
                            userBox.SelectedIndex = usernameList.Count - 1;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("A user with this username already exists.\nPlease try a different username.", "Username already exists.");
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

        private static void SetConnectionString()
        {
            String path = System.IO.Path.GetFullPath(AppDomain.CurrentDomain.BaseDirectory + "../../../POE_19003041_PROG6211_WEB/App_Data");
            AppDomain.CurrentDomain.SetData("DataDirectory", path);
            con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\POE_Database.mdf;Integrated Security=True";
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