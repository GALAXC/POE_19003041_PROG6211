using System;
using System.Collections;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace POE_19003041_PROG6211
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        public static String loggedInUser = "";
        public static Boolean isUserAdmin = false;
        private Boolean passwordButtonStatus = true;
        private static readonly SqlConnection con = new SqlConnection();
        private ArrayList usernameList;
        private ArrayList passwordList;
        private ArrayList userType;

        //Center welcome label
        private void Login_Load(object sender, EventArgs e)
        {
            loginWelcomeLabel.Location = new System.Drawing.Point((this.Size.Width / 2) - (loginWelcomeLabel.Size.Width / 2), 9);
            String command = "SELECT * FROM TBL_LOGINDETAILS;";
            //Section for temporary local database storage for use in both projects (WEB + WINDOWS)
            String path = System.IO.Path.GetFullPath(AppDomain.CurrentDomain.BaseDirectory + "../../../POE_19003041_PROG6211_WEB/App_Data");
            AppDomain.CurrentDomain.SetData("DataDirectory", path);
            //

            con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\POE_Database.mdf;Integrated Security=True";
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
        }

        private void LoginQuitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Read LoginDetails.txt file and compare it against user entered login details
        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (loginUsernameBox.Text != "" && loginPasswordBox.Text != "")
            {
                if (usernameList.Contains(loginUsernameBox.Text))
                {
                    if (loginPasswordBox.Text == Convert.ToString(passwordList[usernameList.IndexOf(loginUsernameBox.Text)]))
                    {
                        loggedInUser = loginUsernameBox.Text;
                        if (Convert.ToString(userType[usernameList.IndexOf(loginUsernameBox.Text)]) == "1")
                        {
                            isUserAdmin = true;
                        }
                        else
                        {
                            isUserAdmin = false;
                        }
                        this.Hide();
                        Report newReport = new Report();
                        newReport.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Login failed. \nPlease ensure the details you have entered are correct and try again.");
                    }
                }
                else
                {
                    MessageBox.Show("Login failed. \nPlease ensure the details you have entered are correct and try again.");
                }
            }
            else
            {
                MessageBox.Show("One or more fields have been left blank.\nPlease make sure the correct details are input before attempting to log in.");
            }
        }

        //Show/Hide the password
        private void ShowHidePasswordButton_Click(object sender, EventArgs e)
        {
            //Password button status = True if the password is hidden
            if (passwordButtonStatus == true)
            {
                passwordButtonStatus = false;
                loginPasswordBox.UseSystemPasswordChar = false;
                showHidePasswordButton.BackgroundImage = POE_19003041_PROG6211.Properties.Resources.HidePassword;
            }
            else
            {
                passwordButtonStatus = true;
                loginPasswordBox.UseSystemPasswordChar = true;
                showHidePasswordButton.BackgroundImage = POE_19003041_PROG6211.Properties.Resources.ShowPassword;
            }
        }
    }
}