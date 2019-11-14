using Newtonsoft.Json;
using System;
using System.Collections.Generic;
namespace WeatherApi
{
    public class Rootobject
    {
        public string cod { get; set; }
        public double message { get; set; }
        public int cnt { get; set; }
        public List<List> list { get; set; }
        public City city { get; set; }
    }
}