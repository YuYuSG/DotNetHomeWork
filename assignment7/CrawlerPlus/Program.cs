using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Net;
using System.Collections;
using System.Text.RegularExpressions;
using System.Threading;


namespace CrawlerPlus
{
    class Crawler
    {
        private Hashtable urls = new Hashtable();  // 待爬取的网页集合
        private int count = 0;   // 已爬取的网页数量
        private string startUrl = "";   // 起始网页地址
        private string hostUrl = "";    // 目标网站的主机地址

        // 构造函数，传入起始网页地址和目标网站的主机地址
        public Crawler(string startUrl, string hostUrl)
        {
            this.startUrl = startUrl;
            this.hostUrl = hostUrl;
            urls.Add(startUrl, false);
        }



       

        // 开始爬取
        public void Crawl()
        {
            Console.WriteLine("开始爬行了....");
            while (true)
            {
                string current = null;
                foreach (string url in urls.Keys)  //找到一个还没有下载过的链接
                {
                    if ((bool)urls[url]) continue;  //已经下载过的，不再下载
                    if (IsHtml(url))  //如果该网页是html/aspx/php/jsp等网页，则解析并爬取下一级URL
                    {
                        current = url;
                    }

                }
                if (current == null || count > 10) break;  //最多爬10个

                Console.WriteLine("爬行" + current + "页面！");

                string html = Download(current);  //下载

                urls[current] = true;  //标记该网页已经下载过
                count++;

                Parse(html);  //解析，并加入新的链接
            }
            Console.WriteLine("爬行结束");
        }

        // 判断当前网页是否是html/aspx/php/jsp等网页
        private bool IsHtml(string url)
        {
            string[] fileTypes = { ".html", ".htm", ".aspx", ".php", ".jsp" };
            foreach (string fileType in fileTypes)
            {
                if (url.EndsWith(fileType)) return true;
            }
            return false;
        }

        // 下载网页
        private string Download(string url)
        {
            try
            {
                WebClient webClient = new WebClient();
                webClient.Encoding = Encoding.UTF8;
                string html = webClient.DownloadString(url);
                string fileName = count.ToString();
                File.WriteAllText(fileName, html, Encoding.UTF8);
                return html;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return "";
            }
        }


        
        // 解析网页并将需要爬取的链接加入待爬取的网页集合中
        private void Parse(string html)
        {
            string strRef = @"(href|HREF)[]* =[]*[""'][^""'#>] + [""']";  //查找页面中的所有超链接
            MatchCollection matches = new Regex(strRef).Matches(html);  //将这些链接的内容保存在 matches 集合中
            foreach (Match match in matches)
            {
                strRef = match.Value.Substring(match.Value.IndexOf('=') + 1).Trim('"', '\"', '#', ' ', '>');  //获取匹配的 href 属性值中的 URL
                if (strRef.Length == 0) continue;
                if (strRef.StartsWith("/")) strRef = hostUrl + strRef;   // 如果是以"/"开头的相对路径，则加上主机地址
                else if (!strRef.StartsWith("http")) continue;  // 如果URL不以"http"或"https"开头，则不是网页链接，忽略掉
                if (urls[strRef] == null) urls[strRef] = false;   // 如果该链接未被添加到待爬取的网页集合中，则添加进去
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Crawler crawler = new Crawler("http://www.cnblogs.com/", "http://www.cnblogs.com/");
            crawler.Crawl();
        }
    }
}
