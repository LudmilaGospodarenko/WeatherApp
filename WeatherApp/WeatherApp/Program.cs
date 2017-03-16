using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace WeatherForecast
{

    class Program
    {
        const string API_KEY = "435ed4f2dc58f240df6d38029350e394";

        const string CurrentUrl =
            "http://api.openweathermap.org/data/2.5/weather?" +
            "q=Minsk&mode=xml&units=metric&APPID=" + API_KEY;
        const string ForecastUrl =
            "http://api.openweathermap.org/data/2.5/forecast?" +
            "q=London&mode=xml&units=metric&APPID=" + API_KEY;
        // {"_id":625144,"name":"Minsk","country":"BY","coord":{"lon":27.566668,"lat":53.900002}}

        static string GetFormattedXml(string url)
        {
            // Create a web client.
            using (WebClient client = new WebClient())
            {
                // Get the response string from the URL.
                string xml = client.DownloadString(url);

                // Load the response into an XML document.
                XmlDocument xml_document = new XmlDocument();
                xml_document.LoadXml(xml);

                // Format the XML.
                using (StringWriter string_writer = new StringWriter())
                {
                    XmlTextWriter xml_text_writer =
                        new XmlTextWriter(string_writer);
                    xml_text_writer.Formatting = Formatting.Indented;
                    xml_document.WriteTo(xml_text_writer);

                    // Return the result.
                    return string_writer.ToString();
                }
            }
        }

        static decimal FriendlyWeatherCasting(string resp)
        {
            //string temperature = resp.Substring(resp.IndexOf("Temperature"));
            string temperature = resp.Substring(resp.IndexOf("temperature value="));
            string temp = temperature.Substring(temperature.IndexOf("\""));
            temp = temp.Substring(1, 3);
            if (temp.Contains("\""))
            {
                temp = temp.Substring(0, 2);
            }
            //Console.WriteLine("Temperature = {0}", temp);
            decimal res = Convert.ToDecimal(temp);
            return res;
        }

        static void Main(string[] args)
        {
            string response = GetFormattedXml(CurrentUrl);
            //Console.WriteLine(response);
            decimal temperatureValue = FriendlyWeatherCasting(response);
            if (temperatureValue > 25)
                Console.WriteLine("Сегодня очень жарко, до {0} С", temperatureValue);
            else if (temperatureValue > 18)
                Console.WriteLine("Сегодня тепло и не жарко, до {0} С", temperatureValue);
            else if (temperatureValue > 10)
                Console.WriteLine("Сегодня достаточно прохладно, до {0} С", temperatureValue);
            else if (temperatureValue > 0)
                Console.WriteLine("Сегодня достаточно холодно, до {0} С", temperatureValue);
            else if (temperatureValue > -5)
                Console.WriteLine("Сегодня не так уж и холодно, всего {0} С", temperatureValue);
            else if (temperatureValue > -10)
                Console.WriteLine("Сегодня холодно, до {0} С", temperatureValue);
            else if (temperatureValue > -20)
                Console.WriteLine("Сегодня дубак, до {0} С", temperatureValue);
            else if (temperatureValue > -30)
                Console.WriteLine("Сегодня пиздец холодильник, до {0} С", temperatureValue);

            Console.ReadLine();


        }
    }
}

