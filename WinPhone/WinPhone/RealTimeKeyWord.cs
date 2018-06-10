using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;
using System.Net;
using System.IO;


namespace WinPhone
{
    class RealTimeKeyWord
    {
        public string[] Keyword()
        {
        string[] str = new string[20];       // 실시간 검색어를 받아와 저장할 문자열 배열 선언 
        int i = 0;                           // 배열 인덱스 번호 변수
        Encoding utf = Encoding.GetEncoding("utf-8");   // 인코딩
        HtmlDocument document = new HtmlDocument();     // Html을 사용하기 위해 클래스 생성
        WebClient web = new WebClient();                // web과 연결 하는 클래스 생성
            
        Stream stream_source;                           // 웹 경로를 저장할 객체
            stream_source = web.OpenRead("https://www.naver.com/");     // 웹 경로 저장
            StreamReader sr = new StreamReader(stream_source, utf);     // 불러온 웹을 읽어 들이는 클래스 생성
            string html = sr.ReadToEnd();                               // 문자열 변수에 읽어들인 웹 저장
            document.LoadHtml(html);                                    // 웹 로드
            string _html = web.DownloadString("https://www.naver.com/");

            HtmlNodeCollection nodeCol = document.DocumentNode.SelectNodes("//div//ul//li[@class='ah_item']//a[@class='ah_a']//span[@class='ah_k']");  // 사용할 부분의 태그만 가져와서 컬렉션에 저장, 네이버에서 실시간 검색어 파싱

            foreach (HtmlNode node in nodeCol)      // 컬렉션에서 하나씩 꺼내
            {
                str[i] = node.OuterHtml;            // 문자열 배열 하나에 하나씩 저장
                if (i< 19)
                    i++;
            }

            for (int k = 0; k< 20; k++)
            {
                int cut1 = str[k].LastIndexOf("<") - 1;
                int cut2 = str[k].IndexOf(">") + 1;
                str[k] = str[k].Substring(cut2, cut1 - cut2 + 1);   // 문자열 가공
            }
            return str; // 저장한 문자열 배열 반환
        }

    }
}
