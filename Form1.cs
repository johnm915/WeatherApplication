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
            GetForecast();
        }

        double lon;
        double lat;
        void Getweather()
        {
            using (WebClient web = new WebClient())
            {                                   //weather API
                string url = string.Format("https://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}&units=imperial", TBCity.Text, APIKey);
                var json = web.DownloadString(url);
                WeatherInfo.root Info = JsonConvert.DeserializeObject<WeatherInfo.root>(json);

                picIcon.ImageLocation = "https://openweathermap.org/img/w/" + Info.weather[0].icon + ".png";
                labCondition.Text = Info.weather[0].main;
                labDetails.Text = Info.weather[0].description;
                labSunset.Text = convertDateTime(Info.sys.sunset).ToShortTimeString();
                labSunrise.Text = convertDateTime(Info.sys.sunrise).ToShortTimeString();

                lab0.Text = Info.main.temp.ToString() + "°";
                labWindSpeed.Text = Info.wind.speed.ToString();
                labPressure.Text = Info.main.pressure.ToString();

                lon = Info.coord.lon;
                lat = Info.coord.lat;
            }

        }
        // The following creates a DateTime object with the default value.  1234
        DateTime convertDateTime(long sec)
        {
            DateTime day = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc).ToLocalTime();
            day = day.AddSeconds(sec).ToLocalTime();
            return day;
        }


        void GetForecast()
        {
            using (WebClient web = new WebClient())
            {                                   //Weather Forecast API
                string url = string.Format("https://api.openweathermap.org/data/2.5/onecall?lat={0}&lon={1}&exclude=current,minutely,hourly,.alerts&appid={2}", lat, lon, APIKey);
                var json = web.DownloadString(url);
                
                WeatherForeCast.ForecastInfo ForecastInfo = JsonConvert.DeserializeObject<WeatherForeCast.ForecastInfo>(json);


                //Forecast User Control = UC
                FLP.Controls.Clear();
                ForeCastUC UC;

                for (int i = 0; i < 5; i++)
                {
                    UC = new ForeCastUC();
                    UC.picWeatherIcon.ImageLocation = "https://openweathermap.org/img/w/" + ForecastInfo.daily[i].weather[0].icon + ".png";
                    UC.labWeatherCond.Text = ForecastInfo.daily[i].weather[0].main;
                    UC.LabMainWeather.Text = ForecastInfo.daily[i].weather[0].description;
                    UC.labDT.Text = convertDateTime (ForecastInfo.daily[i].dt).DayOfWeek.ToString();


                    //FlowLayoutPanel.Controls.Add(FUC);
                    
                    FLP.Controls.Add(UC);
                    //FLP.Controls.Clear();
                }

                    
            }

            

        }
    }
}
