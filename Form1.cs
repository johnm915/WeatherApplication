using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Net;

namespace WeatherApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string APIKey = "03a39e22c2181869bc0a13e24cd124f2";

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BTNScearch_Click(object sender, EventArgs e)
        {
            Getweather();
        }
        void Getweather()
        {
            using (WebClient web = new WebClient())
            {
                string url = string.Format("https://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}&units=imperial", TBCity.Text, APIKey);
                var json = web.DownloadString(url);
                WeatherInfo.root Info = JsonConvert.DeserializeObject<WeatherInfo.root>(json);

                labCondition.Text = Info.weather[0].main;
                labDetails.Text = Info.weather[0].description;
                labSunset.Text = convertDateTime( Info.sys.sunset).ToShortTimeString();
                labSunrise.Text = convertDateTime (Info.sys.sunrise).ToShortTimeString();

                labTemp.Text = Info.main.temp.ToString();
                labWindSpeed.Text =Info.wind.speed.ToString();
                labPressure.Text = Info.main.pressure.ToString();
            }

        }
        DateTime convertDateTime(long sec)
        {
            DateTime day = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc).ToLocalTime();
            day = day.AddSeconds(sec).ToLocalTime();
            return day;
        }

        
    }
}
