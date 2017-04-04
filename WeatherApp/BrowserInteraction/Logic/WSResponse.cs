using System;
using System.IO;
using System.Net;
using System.Xml;

namespace WeatherApp.Logic
{
    public class WSResponce
    {
        //Receive response from weather web-server and write it into string
        public string GetFormattedXml(string url)
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

        //Select temperature from WS response
        public decimal PickTemperature(string response)
        {
            string temperature = response.Substring(response.IndexOf("temperature value="));
            string temp = temperature.Substring(temperature.IndexOf("\""));
            temp = temp.Substring(1, 3);
            while (temp.Contains("\""))
            {
                temp = temp.Substring(0, (temp.Length - 1));
            }
            decimal res = Convert.ToDecimal(temp);
            return res;
        }

        //Select weather from WS response
        public string PickClouds(string response)
        {
            string clouds = response.Substring(response.IndexOf("clouds value="));
            clouds = clouds.Substring(clouds.IndexOf("name=\""));
            clouds = clouds.Substring(6, 30);
            while (clouds.Contains("\""))
            {
                clouds = clouds.Substring(0, (clouds.Length - 1));
            }
            return clouds;
        }

        //Select precipitation from WS response
        public string PickPrecipitation(string response)
        {
            string precipitation = response.Substring(response.IndexOf("precipitation"));
            precipitation = precipitation.Substring(1, 45);
            if (precipitation.Contains("type="))
            {
                precipitation = precipitation.Substring(precipitation.IndexOf("type=\""));
                while (precipitation.Contains("\""))
                {
                    precipitation = precipitation.Substring(0, (precipitation.Length - 1));
                }
            }
            else precipitation = "";
            return precipitation;
        }

    }
}
