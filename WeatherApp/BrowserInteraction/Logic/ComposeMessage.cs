using System;

namespace WeatherApp.Logic
{
    public class ComposeMessage
    {
        //Compose text for different values of temperature, returned from WS
        private string ComposeTemperature(current response)
        {
            string result = "";
            if (response.temperature.value > 25)
                result = "Сегодня очень жарко, до " + response.temperature.value + " °С. ";
            else if (response.temperature.value > 18)
                result = "Сегодня тепло и не жарко, до " + response.temperature.value + " °С. ";
            else if (response.temperature.value > 10)
                result = "Сегодня достаточно прохладно, до " + response.temperature.value + " °С. ";
            else if (response.temperature.value > 0)
                result = "Сегодня достаточно холодно, до " + response.temperature.value + " °С. ";
            else if (response.temperature.value > -5)
                result = "Сегодня не так уж и холодно, всего " + response.temperature.value + " °С. ";
            else if (response.temperature.value > -10)
                result = "Сегодня холодно, до " + response.temperature.value + " °С. ";
            else if (response.temperature.value > -20)
                result = "Сегодня дубак, до " + response.temperature.value + "} °С. ";
            else if (response.temperature.value > -30)
                result = "Сегодня писец холодильник, до " + response.temperature.value + " °С. ";
            else result = "Температуру получить не удалось. ";
            return result;
        }

        //Compose string for weather itself - if it is cloudy/sunny, depending on WS response 
        private string ComposeClouds(current response)
        {
            string result;
            string cloudsValue = response.clouds.name;
            switch (cloudsValue)
            {
                case "clear sky":
                    {
                        result = "Небо ясное.";
                        break;
                    }
                case "few clouds":
                    {
                        result = "Малооблачно.";
                        break;
                    }
                case "scattered clouds":
                    {
                        result = "Рассеянные облака.";
                        break;
                    }
                case "broken clouds":
                    {
                        result = "Разорванные облака.";
                        break;
                    }
                case "overcast clouds":
                    {
                        result = "Облачно, небольшой дождь.";
                        break;
                    }

                default:
                    {
                        result = "Подходящего варианта соответствия для погоды не найдено.";
                        break;
                    }
            }
            return result;
        }

        //Compose string for precipitation (if it will be rainy), returned from WS
        private string ComposePrecipitation(current response)
        {
            string result;
            string rainyValue = response.precipitation.mode;
            switch (rainyValue)
            {
                case "":
                    {
                        result = "";
                        break;
                    }
                case "rain":
                    {
                        result = "Ожидается дождь, возьми с собой зонт.";
                        break;
                    }
                case "snow":
                    {
                        result = "Ожидается снегопад.";
                        break;
                    }
                default:
                    {
                        result = "Подходящего варианта соответствия для осадков не найдено.";
                        break;
                    }
            }
            return result;
        }

        //Compose the whole message
        public string CreateMessage(current response)
        {
            string message;
            message = ComposeTemperature(response);
            message = message + ComposeClouds(response);
            message = message + ComposePrecipitation(response);
            Console.WriteLine(message);
            return message;
        }

    }
}
