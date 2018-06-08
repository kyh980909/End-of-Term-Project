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
        string[] str = new string[20];
        int i = 0;
        Encoding utf = Encoding.GetEncoding("utf-8");
        HtmlDocument document = new HtmlDocument();
        WebClient web = new WebClient();

        Stream stream_source;
        public string Keyword()
        {
            stream_source = web.OpenRead("https://www.naver.com/");
            StreamReader sr = new StreamReader(stream_source, utf);
            string html = sr.ReadToEnd();
            document.LoadHtml(html);
            string _html = web.DownloadString("https://www.naver.com/");

            HtmlNodeCollection nodeCol = document.DocumentNode.SelectNodes("//div//ul//li[@class='ah_item']//a[@class='ah_a']//span[@class='ah_k']");

            foreach (HtmlNode node in nodeCol)
            {
                str[i] = node.OuterHtml;
                if (i< 19)
                    i++;
            }

            for (int k = 0; k< 20; k++)
            {
                int cut1 = str[k].LastIndexOf("<") - 1;
        int cut2 = str[k].IndexOf(">") + 1;
        str[k] = str[k].Substring(cut2, cut1 - cut2 + 1);
        Console.WriteLine(k+1 + "." + str[k]);
            }
            return ;
        }

    }
}
