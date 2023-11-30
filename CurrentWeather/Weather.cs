using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace CurrentWeather
{
    public class Weather
    {
        public string GetZip()
        {
            var apiKeyObj = File.ReadAllText("appsettings.json");

            var apiKey = JsonNode.Parse(apiKeyObj).GetValue("apiKey").ToString();

            Console.WriteLine("Enter Zip Code:");

            var zip = Console.ReadLine();

            return zip;

        }





        }
}
