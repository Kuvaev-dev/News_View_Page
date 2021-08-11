using My_City_News.Model.Custom_Element.ViewModel;
using System;
using System.IO;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace My_City_News.Model.Custom_Element
{
    /// <summary>
    /// Логика взаимодействия для NewsControl.xaml
    /// </summary>
    public partial class NewsControl : UserControl
    {
        public NewsControl(string categoryString, string dateTimeString, string headerString, string bodyString, string imagePath, string linkString)
        {
            InitializeComponent();

            using (WebClient client = new WebClient())
            {
                client.DownloadFile(imagePath, $"{MainLogic.folderName}\\{++MainLogic.count}.jpg");
            }

            this.DataContext = new NewsViewModel()
            {
                CategoryString = categoryString,
                DateTimeString = dateTimeString,
                HeaderString = headerString,
                BodyString = bodyString,
                ImagePath = File.ReadAllBytes($"{MainLogic.folderName}\\{MainLogic.count}.jpg"),
                LinkString = linkString
            };
        }

        private void headerTextBlock_MouseEnter(object sender, MouseEventArgs e) => (sender as TextBlock).TextDecorations = TextDecorations.Underline;
        private void headerTextBlock_MouseLeave(object sender, MouseEventArgs e) => (sender as TextBlock).TextDecorations = null;
    }
}
