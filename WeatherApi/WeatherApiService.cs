using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

//namespace WeatherApi
//{
//    public class WeatherApiService
//    {
//        private const string API_KEY = "68ded4b45811be921bd9f9dc6b94bcc5";

//        public string CurrentUrl { get; set; }
//        public Rootobject WeatherData { get; set; }

//        public WeatherApiService(string city)
//        {
//            SetCurrentUrl(city);
//            WeatherData = GetWeatherData();
//        }


//        public void SetCurrentUrl(string location)
//        {
//            CurrentUrl =
//                 @$"http://api.openweathermap.org/data/2.5/weather?q={location}&appid={API_KEY}";
//        }

//        public WeatherData GetWeatherData()
//        {
//            using (var webClient = new WebClient())
//            {
//                var json = webClient.DownloadString(CurrentUrl);
//                return  JsonConvert.DeserializeObject<WeatherData>(json);
//            }
//        }
//    }
//}
