using System;
using System.Windows.Forms;

namespace POE_19003041_PROG6211
{
    public partial class PasswordCheck : Form
    {
        public PasswordCheck()
        {
            InitializeComponent();
        }

        public static Boolean allowUser = false;
        private Boolean passwordButtonStatus = true;

        //Form for security checking the password
        private void PasswordCheck_Load(object sender, EventArgs e)
        {
            passwordCheckLabel.Text = "Please enter the password for: " + Login.loggedInUser;
            passwordCheckLabel.Location = new System.Drawing.Point(((this.Size.Width / 2) - (passwordCheckLabel.Size.Width / 2)) - 8, 26);
            passwordBox.Location = new System.Drawing.Point(((this.Size.Width / 2) - (passwordBox.Size.Width / 2)) - 8, 67);
            allowUser = false;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            allowUser = false;
            this.Close();
        }

        //Compare password and allow/disallow access
        private void OkButton_Click(object sender, EventArgs e)
        {
            if (Weather.GetPassword(Weather.GetIndexOfUsername(Login.loggedInUser)) == passwordBox.Text)
            {
                allowUser = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("The password you have entered is incorrect.");
            }
        }

        //Show/Hide password
        private void ShowHidePasswordButton_Click(object sender, EventArgs e)
        {
            //Password button status = True if the password is hidden
            if (passwordButtonStatus == true)
            {
                passwordButtonStatus = false;
                passwordBox.UseSystemPasswordChar = false;
                showHidePasswordButton.BackgroundImage = POE_19003041_PROG6211.Properties.Resources.HidePassword;
            }
            else
            {
                passwordButtonStatus = true;
                passwordBox.UseSystemPasswordChar = true;
                showHidePasswordButton.BackgroundImage = POE_19003041_PROG6211.Properties.Resources.ShowPassword;
            }
        }
    }
}