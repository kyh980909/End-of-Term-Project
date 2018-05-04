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
        public string Celcius()
        {
            WebClient web = new WebClient();    // api를 사용해 웹에서 날씨 정보를 가져오기 위해 web클래스 사용

            web.Encoding = Encoding.UTF8;       // 한글깨짐을 방지하기위해 인코딩

            var contents = web.DownloadString(@"https://api2.sktelecom.com/weather/current/minutely?version=1&city=%EC%84%9C%EC%9A%B8&county=%EB%85%B8%EC%9B%90%EA%B5%AC&village=%EC%83%81%EA%B3%841%EB%8F%99&appKey=8c36927b-2fbe-482e-8b7f-8faed2f7af35");    // 웹 에서 날씨 정보를 불러올 URL

            JObject job = JObject.Parse(contents);  // json파일 사용하기 위해 사용

            return job["weather"]["minutely"][0]["temperature"]["tc"].ToString().Substring(0, 2) + "°"; // 
        }
    }
}
