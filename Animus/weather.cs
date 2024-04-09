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

namespace Animus
{
    public partial class weather : Form
    {
        public weather()
        {
            InitializeComponent();
        }
        string APIKey = "1266ec6640edf945e234f92a13a9aa39";


        private void btnSearch_Click(object sender, EventArgs e)
        {
            getWeather();  
        }
        void getWeather() 
        {
        using (WebClient web = new WebClient()) 
            {
                string url = string.Format("https://api.openweathermap.org/data/2.5/weather?lat=-0.303099&lon=36.080025&appid=1266ec6640edf945e234f92a13a9aa39",TBCity.Text, APIKey);
                var json = web.DownloadString(url);
                weatherinfo.root info = JsonConvert.DeserializeObject<weatherinfo.root>(json);

                picicon.ImageLocation = "https://openweathermap.org/img/w/" +info.weather[0].icon+".png";
                labcondition.Text = info.weather[0].main;
                labDetails.Text = info.weather[0].description;
                labSunset.Text= convertDateTime(info.sys.sunset).ToShortTimeString();
                labSunrise.Text=convertDateTime(info.sys.sunrise).ToShortTimeString();
                labcountry.Text=info.sys.country.ToString();
                labWindspeed.Text=info.wind.speed.ToString();
                labPressure.Text=info.main.pressure.ToString();
            }

        }
        DateTime convertDateTime(long sec)
        {
            DateTime day = new DateTime(1970,1,1,0,0,0,0,System.DateTimeKind.Utc).ToLocalTime();
            day = day.AddSeconds(sec).ToLocalTime();

            return day;
        }

        private void weather_Load(object sender, EventArgs e)
        {

        }
    }
}
