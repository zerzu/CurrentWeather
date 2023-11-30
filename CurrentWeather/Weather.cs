using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace CurrentWeather
{
    public class Weather
    {
        public void GetWeather()
        {
            // gets appsettings.json file and reads in all text

            var apiKeyObj = File.ReadAllText("appsettings.json");

            // gets the value pair for apiKey from appsettings.json and returns it as a string of useable text

            var apiKey = JObject.Parse(apiKeyObj).GetValue("apiKey").ToString();

            Console.Write("Enter Zip Code: ");

            var zip = Console.ReadLine();
            
            var url = $"https://api.openweathermap.org/data/2.5/weather?zip={zip},us&appid={apiKey}&units=imperial";

            var _client = new HttpClient();

            var jText = _client.GetStringAsync(url).Result;

            var weatherObjMain = JObject.Parse(jText)["main"];

            Console.WriteLine($"Temp: {weatherObjMain["temp"]}");
            Console.WriteLine($"--------------------------------");
            Console.WriteLine($"Feels Like: {weatherObjMain["feels_like"]}");
        }



        }
}
