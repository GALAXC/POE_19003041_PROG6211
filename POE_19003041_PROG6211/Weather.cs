using System;
using System.Collections;
using System.IO;

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

        //Getters and Setters
        public static void addWeatherDate(object value)
        {
            using (StreamWriter weatherInput = new StreamWriter("../../WeatherData.txt", true))
            {
                weatherInput.WriteLine(value);
            }
        }

        public static DateTime getWeatherDate(int value)
        {
            return Convert.ToDateTime(weatherDates[value]);
        }

        public static void addMinTemp(object value)
        {
            using (StreamWriter weatherInput = new StreamWriter("../../WeatherData.txt", true))
            {
                weatherInput.WriteLine(value);
            }
        }

        public static string getMinTemp(int value)
        {
            return Convert.ToString(minTemps[value]);
        }

        public static void addMaxTemp(object value)
        {
            using (StreamWriter weatherInput = new StreamWriter("../../WeatherData.txt", true))
            {
                weatherInput.WriteLine(value);
            }
        }

        public static string getMaxTemp(int value)
        {
            return Convert.ToString(maxTemps[value]);
        }

        public static void addPrecipitation(object value)
        {
            using (StreamWriter weatherInput = new StreamWriter("../../WeatherData.txt", true))
            {
                weatherInput.WriteLine(value);
            }
        }

        public static string getPrecipitation(int value)
        {
            return Convert.ToString(precips[value]);
        }

        public static void addHumidity(object value)
        {
            using (StreamWriter weatherInput = new StreamWriter("../../WeatherData.txt", true))
            {
                weatherInput.WriteLine(value);
            }
        }

        public static string getHumidity(int value)
        {
            return Convert.ToString(humidities[value]);
        }

        public static void addWindSpeed(object value)
        {
            using (StreamWriter weatherInput = new StreamWriter("../../WeatherData.txt", true))
            {
                weatherInput.WriteLine(value);
            }
        }

        public static string getWindSpeed(int value)
        {
            return Convert.ToString(windSpeeds[value]);
        }

        public static void addCityName(object value)
        {
            using (StreamWriter weatherInput = new StreamWriter("../../WeatherData.txt", true))
            {
                weatherInput.WriteLine(value);
            }
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

            using (StreamReader weatherOutput = new StreamReader("../../WeatherData.txt"))
            {
                for (int i = 0; i < (TotalLines("../../WeatherData.txt") / 7); i++)
                {
                    cityNames.Add(weatherOutput.ReadLine());
                    weatherDates.Add(weatherOutput.ReadLine());
                    minTemps.Add(weatherOutput.ReadLine());
                    maxTemps.Add(weatherOutput.ReadLine());
                    precips.Add(weatherOutput.ReadLine());
                    humidities.Add(weatherOutput.ReadLine());
                    windSpeeds.Add(weatherOutput.ReadLine());
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
    }
}