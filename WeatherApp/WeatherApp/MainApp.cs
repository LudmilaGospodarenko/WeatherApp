using System;
using WeatherApp.Logic;

namespace WeatherForecast
{

    class MainApp
    {
        const string API_KEY = "435ed4f2dc58f240df6d38029350e394";

        const string CurrentUrl =
            "http://api.openweathermap.org/data/2.5/weather?" +
            "q=Minsk&mode=xml&units=metric&APPID=" + API_KEY;
        const string ForecastUrl =
            "http://api.openweathermap.org/data/2.5/forecast?" +
            "q=London&mode=xml&units=metric&APPID=" + API_KEY;
        // {"_id":625144,"name":"Minsk","country":"BY","coord":{"lon":27.566668,"lat":53.900002}}

        static void Main(string[] args)
        {
            WSResponce respObject = new WSResponce();
            string response = respObject.GetFormattedXml(CurrentUrl);
            Console.WriteLine(response);
            Console.WriteLine("__________________________");
            ComposeMessage newMessage = new ComposeMessage();
            newMessage.ComposeTemperature(response);
            newMessage.ComposeClouds(response);
            Console.ReadLine();
        }
    }
}

