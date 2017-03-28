using System;

namespace WeatherApp.Logic
{
    public class ComposeMessage
    {
        WSResponce wsResp = new WSResponce();

        //Compose text for different values of temperature, returned from WS
        private string ComposeTemperature(string response)
        {
            decimal temperatureValue = wsResp.PickTemperature(response);
            string result;
            if (temperatureValue > 25)
                result = "Сегодня очень жарко, до " + temperatureValue.ToString() + " °С. ";
            else if (temperatureValue > 18)
                result = "Сегодня тепло и не жарко, до " + temperatureValue.ToString() + " °С. ";
            else if (temperatureValue > 10)
                result = "Сегодня достаточно прохладно, до " + temperatureValue.ToString() + " °С. ";
            else if (temperatureValue > 0)
                result = "Сегодня достаточно холодно, до " + temperatureValue.ToString() + " °С. ";
            else if (temperatureValue > -5)
                result = "Сегодня не так уж и холодно, всего " + temperatureValue.ToString() + " °С. ";
            else if (temperatureValue > -10)
                result = "Сегодня холодно, до " + temperatureValue.ToString() + " °С. ";
            else if (temperatureValue > -20)
                result = "Сегодня дубак, до " + temperatureValue.ToString() + "} °С. ";
            else if (temperatureValue > -30)
                result = "Сегодня писец холодильник, до " + temperatureValue.ToString() + " °С. ";
            else result = "Температуру получить не удалось. ";
            return result;
        }

        //Compose string for weather itself - if it is cloudy/sunny, depending on WS response 
        private string ComposeClouds (string response)
        {
            string result;
            string cloudsValue = wsResp.PickClouds(response);
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
        private string ComposePrecipitation(string response)
        {
            string result;
            string rainyValue = wsResp.PickPrecipitation(response);
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
        public string CreateMessage(string response)
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
