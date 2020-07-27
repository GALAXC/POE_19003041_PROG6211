using System;
using System.Collections;
using System.Data.SqlClient;
using System.IO;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace POE_19003041_PROG6211
{
    public static class Weather
    {
        private static ArrayList cityNames = new ArrayList();
        private static ArrayList weatherDates = new ArrayList();
        private static ArrayList minTemps = new ArrayList();
        private static ArrayList maxTemps = new ArrayList();
        private static ArrayList precips = new ArrayList();
        private static ArrayList humidities = new ArrayList();
        private static ArrayList windSpeeds = new ArrayList();
        private static ArrayList newEntry = new ArrayList();
        private static SqlConnection con = new SqlConnection();

        //Getters and Setters
        public static void addWeatherDate(object value)
        {
            newEntry.Add(true);
            weatherDates.Add(value);
        }

        public static DateTime getWeatherDate(int value)
        {
            return Convert.ToDateTime(weatherDates[value]);
        }

        public static void addMinTemp(object value)
        {
            minTemps.Add(value);
        }

        public static string getMinTemp(int value)
        {
            return Convert.ToString(minTemps[value]);
        }

        public static void addMaxTemp(object value)
        {
            maxTemps.Add(value);
        }

        public static string getMaxTemp(int value)
        {
            return Convert.ToString(maxTemps[value]);
        }

        public static void addPrecipitation(object value)
        {
            precips.Add(value);
        }

        public static string getPrecipitation(int value)
        {
            return Convert.ToString(precips[value]);
        }

        public static void addHumidity(object value)
        {
            humidities.Add(value);
        }

        public static string getHumidity(int value)
        {
            return Convert.ToString(humidities[value]);
        }

        public static void addWindSpeed(object value)
        {
            windSpeeds.Add(value);
        }

        public static string getWindSpeed(int value)
        {
            return Convert.ToString(windSpeeds[value]);
        }

        public static void addCityName(object value)
        {
            cityNames.Add(value);
        }

        public static string getCityName(int value)
        {
            return Convert.ToString(cityNames[value]);
        }

        public static int getCityNameCount()
        {
            return cityNames.Count;
        }

        //Update Local Arrays with Values from File
        public static void populateArrayLists()
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

        //Count the total lines in the weatherdata.txt file
        public static int TotalLines(string filePath)
        {
            using (StreamReader r = new StreamReader(filePath))
            {
                int i = 0;
                while (r.ReadLine() != null) { i++; }
                return i;
            }
        }

        private static void SetConnectionString()
        {
            //Section for temporary local database storage for use in both projects (WEB + WINDOWS)
            String path = System.IO.Path.GetFullPath(AppDomain.CurrentDomain.BaseDirectory + "../../../POE_19003041_PROG6211_WEB/App_Data");
            AppDomain.CurrentDomain.SetData("DataDirectory", path);
            //

            con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\POE_Database.mdf;Integrated Security=True";
        }

        //Update database with new values based on if it was in the database before or not
        public static void UpdateDatabase()
        {
            SetConnectionString();
            con.Open();
            using (con)
            {
                for (int i = 0; i < newEntry.Count; i++)
                {
                    if (Convert.ToBoolean(newEntry[i]) == true)
                    {
                        String command = String.Format("INSERT INTO TBL_WEATHER VALUES ('{0}','{1}',{2},{3},{4},{5},{6})", Weather.getCityName(i), Weather.getWeatherDate(i), Weather.getMinTemp(i), Weather.getMaxTemp(i), Weather.getPrecipitation(i), Weather.getHumidity(i), Weather.getWindSpeed(i));
                        SqlCommand sqlWeather = new SqlCommand(command, con);
                        sqlWeather.ExecuteNonQuery();
                        newEntry[i] = false;
                    }
                }
            }
        }
    }
}