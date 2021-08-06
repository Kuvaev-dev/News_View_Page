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
using My_City_News.MVVM.ViewModel;
using My_City_News.MVVM.Model;

namespace My_City_News.MVVM.View
{
    /// <summary>
    /// Логика взаимодействия для DiscovryView.xaml
    /// </summary>
    public partial class DiscovryView : UserControl
    {
        private DiscoveryViewModel dViewModel;
        public DiscovryView(string headerString, byte[] imagePath, string linkString)
        {
            InitializeComponent();
            this.DataContext = dViewModel = new DiscoveryViewModel(headerString, imagePath, linkString);
        }
    }
}
