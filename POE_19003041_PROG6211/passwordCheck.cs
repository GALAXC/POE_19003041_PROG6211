using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        private void passwordCheck_Load(object sender, EventArgs e)
        {
            passwordCheckLabel.Text = "Please enter the password for: " + Login.loggedInUser;
            passwordCheckLabel.Location = new System.Drawing.Point(((this.Size.Width / 2) - (passwordCheckLabel.Size.Width / 2)) - 8, 26);
            passwordBox.Location = new System.Drawing.Point(((this.Size.Width / 2) - (passwordBox.Size.Width / 2)) - 8, 67);
            allowUser = false;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            allowUser = false;
            this.Close();
        }

        //Compare password and allow/disallow access
        private void okButton_Click(object sender, EventArgs e)
        {
            string[] login = System.IO.File.ReadAllLines("../../LoginDetails.txt");
            for (int i = 0; i < login.Length; i++)
            {
                if (Login.loggedInUser == login[i])
                {
                    if (login[i + 1] == passwordBox.Text)
                    {
                        allowUser = true;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("The password you have entered is incorrect.");
                    }
                }
            }
        }

        //Show/Hide password
        private void showHidePasswordButton_Click(object sender, EventArgs e)
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