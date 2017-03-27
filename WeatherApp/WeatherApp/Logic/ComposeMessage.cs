using System;

namespace WeatherApp.Logic
{
    public class ComposeMessage
    {
        WSResponce wsResp = new WSResponce();

        //Compose text for different values of temperature, returned from WS
        public void ComposeTemperature(string response)
        {
            decimal temperatureValue = wsResp.PickTemperature(response);
            if (temperatureValue > 25)
                Console.Write("Сегодня очень жарко, до {0} °С. ", temperatureValue);
            else if (temperatureValue > 18)
                Console.Write("Сегодня тепло и не жарко, до {0} °С. ", temperatureValue);
            else if (temperatureValue > 10)
                Console.Write("Сегодня достаточно прохладно, до {0} °С. ", temperatureValue);
            else if (temperatureValue > 0)
                Console.Write("Сегодня достаточно холодно, до {0} °С. ", temperatureValue);
            else if (temperatureValue > -5)
                Console.Write("Сегодня не так уж и холодно, всего {0} °С. ", temperatureValue);
            else if (temperatureValue > -10)
                Console.Write("Сегодня холодно, до {0} °С. ", temperatureValue);
            else if (temperatureValue > -20)
                Console.Write("Сегодня дубак, до {0} °С. ", temperatureValue);
            else if (temperatureValue > -30)
                Console.Write("Сегодня пиздец холодильник, до {0} °С. ", temperatureValue);
        }

        //Compose string for weather itself - if it is cloudy/sunny, depending on WS response 
        public void ComposeClouds (string response)
        {
            string cloudsValue = wsResp.PickClouds(response);
            switch (cloudsValue)
            {
                case "clear sky":
                    {
                        Console.WriteLine("Небо ясное.");
                        break;
                    }
                case "sunny":
                    {
                        Console.WriteLine("Солнечно.");
                        break;
                    }

                default:
                    {
                        Console.WriteLine("Подходящего варианта соответствия для погоды не найдено.");
                        break;
                    }
            }
        }
    }
}
