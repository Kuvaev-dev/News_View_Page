using HtmlAgilityPack;
using My_City_News.MVVM.Model.Core;
using My_City_News.MVVM.ViewModel;
using My_City_News.MVVM.Model.Custom_Element;
using System;
using System.Collections.Generic;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace My_City_News.MVVM.Model
{
    class Model
    {
        public RelayCommand HomeViewCommand { get; set; }
        public RelayCommand DiscoveryViewCommand { get; set; }
        public HomeViewModel HomeVM { get; set; }
        public DiscoveryViewModel DiscoveryVM { get; set; }
        private object _currentView;
        
        public readonly static string folderName = "pictures";
        public static int count = 0;
        public static void ParseSite(ref StackPanel newsStackPanel)
        {
            if (!Directory.Exists(folderName))
                Directory.CreateDirectory(folderName);

            string content = string.Empty;
            using (WebClient client = new WebClient())
            {
                client.Encoding = Encoding.UTF8;
                content = client.DownloadString("https://www.5692.com.ua/news");
            }

            HtmlDocument document = new HtmlDocument();
            document.LoadHtml(content);

            List<HtmlNode> newsNodes = document.DocumentNode.SelectNodes("//div[@class=\'c-news-block\']").ToList();
            UIElementCollection newsCollection = newsStackPanel.Children;         

            Parallel.For(0, newsNodes.Count, i =>
            {
                Application.Current.Dispatcher.BeginInvoke(System.Windows.Threading.DispatcherPriority.Normal, (ThreadStart)delegate() 
                    {
                        newsCollection.Add(new NewsControl
                            (
                                newsNodes[i].SelectNodes("//div[contains(@class, \'c-card-label\') and contains(@class, \'c-card-label--in-news\')]")[i].InnerText,
                                newsNodes[i].SelectNodes("//span[@class=\'c-article-info__when\']/span")[i].InnerText,
                                newsNodes[i].SelectNodes("//a[@class=\'c-news-block__title\']")[i].InnerText.Replace("&quot;", "\""),
                                newsNodes[i].SelectNodes("//div[@class=\'c-news-block__text\']")[i].InnerText.Replace("&quot;", "\""),
                                newsNodes[i].SelectNodes("//a[contains(@class, \'c-news-block__image\') and contains(@class, \'lazy-bg\')]")[i].Attributes["data-src"].Value,
                                newsNodes[i].SelectNodes("//a[@class=\'c-news-block__title\']")[i].Attributes["href"].Value
                            )
                        );
                   });
            });

            foreach (UIElement item in newsCollection)
            {
                newsStackPanel.Children.Add(item);
            }
        }
    }
}
