using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Web.UI.WebControls;
using System.Collections;

namespace POE_19003041_PROG6211_WEB
{
    public partial class Login : System.Web.UI.Page
    {
        private static SqlConnection con = new SqlConnection();
        private ArrayList usernameList;
        private ArrayList passwordList;

        protected void Page_Load(object sender, EventArgs e)
        {
            String command = "SELECT * FROM TBL_LOGINDETAILS;";
            con.ConnectionString = ConfigurationManager.ConnectionStrings["POEConnection"].ConnectionString;
            con.Open();
            using (con)
            {
                SqlCommand SQLusernames = new SqlCommand(command, con);
                SqlDataReader usernames = SQLusernames.ExecuteReader();
                usernameList = new ArrayList();
                passwordList = new ArrayList();
                if (usernames.HasRows)
                {
                    while (usernames.Read())
                    {
                        usernameList.Add(usernames.GetValue(0));
                        passwordList.Add(usernames.GetValue(1));
                    }
                }
            }
        }

        protected void startLogin_Authenticate(object sender, AuthenticateEventArgs e)
        {
            if (usernameList.Contains(startLogin.UserName))
            {
                startLogin.FailureText = "Your login attempt was not successful. Please try again.";
                if (startLogin.Password == Convert.ToString(passwordList[usernameList.IndexOf(startLogin.UserName)]))
                {
                    Response.Redirect("~/About");
                }
            }
        }
    }
}