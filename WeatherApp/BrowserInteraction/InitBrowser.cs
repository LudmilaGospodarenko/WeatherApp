using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using WeatherApp.Logic;
using WeatherApp.Pages;

namespace BrowserInteract
{
    [TestFixture]
    public class Initial
    {
        #region test data

        IWebDriver driver;

        const string cache = "user-data-dir=C:/Users/Crazy/AppData/Local/Google/Chrome/User Data/Default";

        //const string user = "lyudmila gospodarenko";
        //lyudmila gospodarenko
        //Sergey Gospodarenko

        const string API_KEY = "435ed4f2dc58f240df6d38029350e394";

        const string CurrentUrl =
            "http://api.openweathermap.org/data/2.5/weather?" +
            "q=Minsk&mode=xml&units=metric&APPID=" + API_KEY;
        const string ForecastUrl =
            "http://api.openweathermap.org/data/2.5/forecast?" +
            "q=Minsk&mode=xml&units=metric&APPID=" + API_KEY;
        #endregion

        [TestCase]
        public void SendCurrentWeather()
        {
            UserList userList = new UserList();
            List<string> users = userList.getUsers();
            WSResponce respObject = new WSResponce();
            current response = new current();
            response = respObject.CurrentWeatherResponse(CurrentUrl);
            ComposeMessage newMessage = new ComposeMessage();
            string message = newMessage.CreateMessage(response);

            ChromeOptions options = new ChromeOptions();
            options.AddArgument(cache);
            driver = new ChromeDriver(options);

            StartPage startPage = new StartPage(driver);
            startPage.GoToUrl();
            foreach (string user in users)
            {
                startPage.OpenChat(user);
                startPage.SendMesage(message);
            }

            driver.Quit();
        }

        [TestCase]
        public void SendWeatherForecast()
        {
            UserList userList = new UserList();
            List<string> users = userList.getUsers();
            WSResponce respObject = new WSResponce();
            weatherdata response = new weatherdata();
            response = respObject.WeatherForecastResponse(ForecastUrl);
            Console.WriteLine("Дата: с {0} по {1}", response.forecast[1].from, response.forecast[1].to);
            Console.WriteLine("Температура: {0}-{1}°С, осадки: {2}, облака: {3}", response.forecast[1].temperature.min, response.forecast[1].temperature.max,
                response.forecast[1].precipitation.type, response.forecast[1].clouds.value);
            //ComposeMessage newMessage = new ComposeMessage();
            //string message = newMessage.CreateMessage(response);

            //ChromeOptions options = new ChromeOptions();
            //options.AddArgument(cache);
            //driver = new ChromeDriver(options);

            //StartPage startPage = new StartPage(driver);
            //startPage.GoToUrl();
            //foreach (string user in users)
            //{
            //    startPage.OpenChat(user);
            //    startPage.SendMesage(message);
            //}

            //driver.Quit();
        }
    }
}
