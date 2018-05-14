using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using System.Net;

namespace WinPhone
{
    class GetCelcius
    {
        public string city = "서울";
        public string country = "노원구";
        public string villege = "상계동";


        public string Celcius()
        {
            WebClient web = new WebClient();    // api를 사용해 웹에서 날씨 정보를 가져오기 위해 web클래스 사용

            web.Encoding = Encoding.UTF8;       // 한글깨짐을 방지하기위해 인코딩

            var contents = web.DownloadString(@"https://api2.sktelecom.com/weather/current/minutely?version=1&city="+ city +"&county="+ country +"&village="+ villege +"&appKey=8c36927b-2fbe-482e-8b7f-8faed2f7af35");    // 웹 에서 날씨 정보를 불러올 URL

            JObject job = JObject.Parse(contents);  // json파일 사용하기 위해 사용

            return job["weather"]["minutely"][0]["temperature"]["tc"].ToString().Substring(0, 2) + "°"; // 날씨 api에서 가져온 날씨 정보를 반환
        }

        public void City(string city)
        {
            this.city = city;
        }

        public void Country(string country)
        {
            this.country = country;
        }

        public void Villege(string villege)
        {
            this.villege = villege;
        }

        public string PrintCountry()
        {
            return this.country;
        }
    }
}
