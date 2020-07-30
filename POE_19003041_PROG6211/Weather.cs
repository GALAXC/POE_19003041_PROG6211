using System;
using System.Collections;
using System.Data.SqlClient;
using System.IO;

namespace POE_19003041_PROG6211
{
    public static class Weather
    {
        private static readonly ArrayList cityNames = new ArrayList();
        private static readonly ArrayList weatherDates = new ArrayList();
        private static readonly ArrayList minTemps = new ArrayList();
        private static readonly ArrayList maxTemps = new ArrayList();
        private static readonly ArrayList precips = new ArrayList();
        private static readonly ArrayList humidities = new ArrayList();
        private static readonly ArrayList windSpeeds = new ArrayList();
        private static readonly ArrayList newEntry = new ArrayList();
        private static readonly SqlConnection con = new SqlConnection();
        private static readonly ArrayList usernameList = new ArrayList();
        private static readonly ArrayList passwordList = new ArrayList();
        private static readonly ArrayList userType = new ArrayList();
        private static Boolean conStatus;
        private static int usernameIndex;

        //Getters and Setters
        //City
        public static void AddCityName(object value)
        {
            cityNames.Add(value);
        }

        public static string GetCityName(int value)
        {
            return Convert.ToString(cityNames[value]);
        }

        public static int GetCityNameCount()
        {
            return cityNames.Count;
        }

        //Weather Date
        public static void AddWeatherDate(object value)
        {
            newEntry.Add(true);
            weatherDates.Add(value);
        }

        public static DateTime GetWeatherDate(int value)
        {
            return Convert.ToDateTime(weatherDates[value]);
        }

        //Min Temp
        public static void AddMinTemp(object value)
        {
            minTemps.Add(value);
        }

        public static string GetMinTemp(int value)
        {
            return Convert.ToString(minTemps[value]);
        }

        //Max Temp
        public static void AddMaxTemp(object value)
        {
            maxTemps.Add(value);
        }

        public static string GetMaxTemp(int value)
        {
            return Convert.ToString(maxTemps[value]);
        }

        //Precipitation
        public static void AddPrecipitation(object value)
        {
            precips.Add(value);
        }

        public static string GetPrecipitation(int value)
        {
            return Convert.ToString(precips[value]);
        }

        //Humidity
        public static void AddHumidity(object value)
        {
            humidities.Add(value);
        }

        public static string GetHumidity(int value)
        {
            return Convert.ToString(humidities[value]);
        }

        //Wind Speed
        public static void AddWindSpeed(object value)
        {
            windSpeeds.Add(value);
        }

        public static string GetWindSpeed(int value)
        {
            return Convert.ToString(windSpeeds[value]);
        }

        //Username List
        public static void AddUsername(object value)
        {
            usernameList.Add(value);
        }

        public static string GetUsername(int value)
        {
            return Convert.ToString(usernameList[value]);
        }

        //Password List
        public static void AddPassword(object value)
        {
            passwordList.Add(value);
        }

        public static string GetPassword(int value)
        {
            return Convert.ToString(passwordList[value]);
        }

        //User Type
        public static void AddUserType(object value)
        {
            userType.Add(value);
        }

        public static string GetUserType(int value)
        {
            return Convert.ToString(userType[value]);
        }

        //Update Local Arrays with Values from File
        public static void PopulateWeatherArrayLists()
        {
            cityNames.Clear();
            weatherDates.Clear();
            minTemps.Clear();
            maxTemps.Clear();
            precips.Clear();
            humidities.Clear();
            windSpeeds.Clear();

            String command = "SELECT * FROM TBL_WEATHER";
            SetConnectionString();
            con.Open();
            using (con)
            {
                SqlCommand sqlWeather = new SqlCommand(command, con);
                SqlDataReader weather = sqlWeather.ExecuteReader();
                if (weather.HasRows)
                {
                    while (weather.Read())
                    {
                        cityNames.Add(weather.GetValue(0));
                        weatherDates.Add(weather.GetValue(1));
                        minTemps.Add(weather.GetValue(2));
                        maxTemps.Add(weather.GetValue(3));
                        precips.Add(weather.GetValue(4));
                        humidities.Add(weather.GetValue(5));
                        windSpeeds.Add(weather.GetValue(6));
                        newEntry.Add(false);
                    }
                }
            }
        }

        //Temporary method for interacting with local database located in Web Form App Project
        private static void SetConnectionString()
        {
            String path = System.IO.Path.GetFullPath(AppDomain.CurrentDomain.BaseDirectory + "../../../POE_19003041_PROG6211_WEB/App_Data");
            AppDomain.CurrentDomain.SetData("DataDirectory", path);
            con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\POE_Database.mdf;Integrated Security=True";
        }

        //Update database with new values based on if it was in the database before or not
        public static void AddWeatherDatabase()
        {
            if (newEntry.Contains(true))
            {
                SetConnectionString();
                con.Open();
                using (con)
                {
                    for (int i = 0; i < newEntry.Count; i++)
                    {
                        if (Convert.ToBoolean(newEntry[i]) == true)
                        {
                            String command = String.Format("INSERT INTO TBL_WEATHER VALUES ('{0}','{1}',{2},{3},{4},{5},{6})", Weather.GetCityName(i), Weather.GetWeatherDate(i), Weather.GetMinTemp(i), Weather.GetMaxTemp(i), Weather.GetPrecipitation(i), Weather.GetHumidity(i), Weather.GetWindSpeed(i));
                            SqlCommand sqlWeather = new SqlCommand(command, con);
                            sqlWeather.ExecuteNonQuery();
                            newEntry[i] = false;
                        }
                    }
                }
            }
        }

        public static Boolean UpdateWeatherDatabase(String city, DateTime date, String min, String max, String precip, String humid, String wind, String oldCity, DateTime oldDate)
        {
            String command = String.Format("UPDATE TBL_WEATHER SET CITYNAME = '{0}', \"DATE\" = '{1}', MINTEMP = {2}, MAXTEMP = {3}, PRECIPITATION = {4}, HUMIDITY = {5}, WINDSPEED = {6} WHERE (CITYNAME = '{7}') AND (DATE = '{8}');", city, date, min, max, precip, humid, wind, oldCity, oldDate);
            con.Open();
            using (con)
            {
                SqlCommand sqlWeather = new SqlCommand(command, con);
                try
                {
                    sqlWeather.ExecuteNonQuery();
                    PopulateWeatherArrayLists();
                    conStatus = true;
                }
                catch
                {
                    conStatus = false;
                }
            }

            return conStatus;
        }

        public static Boolean PopulateLoginArrayLists()
        {
            String command = "SELECT * FROM TBL_LOGINDETAILS;";
            SetConnectionString();
            con.Open();
            using (con)
            {
                SqlCommand SQLusernames = new SqlCommand(command, con);
                try
                {
                    SqlDataReader usernames = SQLusernames.ExecuteReader();
                    if (usernames.HasRows)
                    {
                        while (usernames.Read())
                        {
                            usernameList.Add(usernames.GetValue(0));
                            passwordList.Add(usernames.GetValue(1));
                            userType.Add(usernames.GetValue(2));
                        }
                    }
                    conStatus = true;
                }
                catch
                {
                    conStatus = false;
                }
            }
            return conStatus;
        }

        public static int GetIndexOfUsername(String username)
        {
            usernameIndex = usernameList.IndexOf(username);
            return usernameIndex;
        }
    }
}