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
    }
}
