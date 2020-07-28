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

        //Update Local Arrays with Values from File
        public static void PopulateArrayLists()
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
        public static void AddToDatabase()
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
    }
}