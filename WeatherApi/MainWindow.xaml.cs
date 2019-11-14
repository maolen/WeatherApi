using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Net;

namespace WeatherApi
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private const string API_KEY = "68ded4b45811be921bd9f9dc6b94bcc5";
        WebClient client;
        public MainWindow()
        {
            InitializeComponent();
            //var webUrl = "http://api.openweathermap.org/data/2.5/forecast?q=Astana,KZ&units=metric&appid=68ded4b45811be921bd9f9dc6b94bcc5";
            client = new WebClient();
            //var json = client.DownloadString(webUrl);
            //var result = JsonConvert.DeserializeObject<Rootobject>(json); ;
        }

        private void ShowWeather(object sender, RoutedEventArgs e)
        {
            var webUrl = $"http://api.openweathermap.org/data/2.5/forecast?q=Astana,KZ&units=metric&appid=68ded4b45811be921bd9f9dc6b94bcc5";
            var json = client.DownloadString(new Uri(webUrl));
            var result = JsonConvert.DeserializeObject<Rootobject>(json); 
        }
    }
}
