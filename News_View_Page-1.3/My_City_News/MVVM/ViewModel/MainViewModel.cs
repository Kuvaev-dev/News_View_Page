using My_City_News.MVVM.Model.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace My_City_News.MVVM.ViewModel
{
    class MainViewModel : ObservableObject
    {
        public RelayCommand HomeViewCommand { get; set; }
        public RelayCommand DiscoveryViewCommand { get; set; }
        public HomeViewModel HomeVM { get; set; }
        public DiscoveryViewModel DiscoveryVM { get; set; }
        private object _currentView;

        public object CurrentView
        {
            get { return _currentView; }
            set {
                _currentView = value;
                OnPropertyChanged();
            }
        }

        public MainViewModel()
        {
            HomeVM = new HomeViewModel();
            DiscoveryVM = new DiscoveryViewModel();

            CurrentView = HomeVM;
            HomeViewCommand = new RelayCommand(c => {
                CurrentView = HomeVM;
            });

            DiscoveryViewCommand = new RelayCommand(c => {
                CurrentView = DiscoveryVM;
            });
        }
    }
}
