using HtmlAgilityPack;
using My_City_News.MVVM.Model.Core;
using My_City_News.MVVM.ViewModel;
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

        public interface Article
        {
            public string Name { get; set; }
            public string Text { get; set; }
            public string Link { get; set; }
            public Image image { get; set; }

            public abstract void FillParams(string site, HtmlNode Node);
        }
    }
}
