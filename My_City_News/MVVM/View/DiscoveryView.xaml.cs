using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Linq;

namespace My_City_News.MVVM.View
{
    /// <summary>
    /// Логика взаимодействия для DiscovryView.xaml
    /// </summary>
    public partial class DiscovryView : UserControl
    {
        public DiscovryView()
        {
            InitializeComponent();

        }

        WebRequest request = WebRequest.Create("https://www.5692.com.ua/news");

        public void FillParams()
        {
            WebClient client = new WebClient();
            string content = client.DownloadString("https://www.5692.com.ua/news");
            client.Dispose();
            HtmlDocument doc = new HtmlDocument();
            doc.LoadHtml(@"/html/body/main/div[4]/div[2]/div[1]/div[1]/div/div[2]/a");

            foreach (HtmlNode node in doc.DocumentNode.SelectNodes("//text()"))
            {
                new1.Content=node.InnerText;
            }
        }

        public void FillParamsS()
        {
            WebClient client = new WebClient();
            string content = client.DownloadString("https://www.5692.com.ua/news");
            client.Dispose();
            HtmlDocument doc = new HtmlDocument();
            doc.LoadHtml(@"/html/body/main/div[4]/div[2]/div[1]/div[2]/div/div[2]/a");

            foreach (HtmlNode node in doc.DocumentNode.SelectNodes("//text()"))
            {
                new2.Content = node.InnerText;
            }
        }

        public void FillParamsT()
        {
            WebClient client = new WebClient();
            string content = client.DownloadString("https://www.5692.com.ua/news");
            client.Dispose();
            HtmlDocument doc = new HtmlDocument();
            doc.LoadHtml(@"/html/body/main/div[4]/div[2]/div[1]/div[3]/div/div[2]/a");

            foreach (HtmlNode node in doc.DocumentNode.SelectNodes("//text()"))
            {
                new3.Content = node.InnerText;
            }
        }

        public void FillParamsF()
        {
            WebClient client = new WebClient();
            string content = client.DownloadString("https://www.5692.com.ua/news");
            client.Dispose();
            HtmlDocument doc = new HtmlDocument();
            doc.LoadHtml(@"/html/body/main/div[4]/div[2]/div[1]/div[4]/div/div[2]/a");

            foreach (HtmlNode node in doc.DocumentNode.SelectNodes("//text()"))
            {
                new4.Content = node.InnerText;
            }
        }
    }
}
