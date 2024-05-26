using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

using Dashboard.Utilities;

namespace Dashboard.ViewModels
{
    internal class NavigationViewModel : Utilities.ViewModelBase
    {
        private object _currentView;

        public object CurrentView
        {
            get { return _currentView; }
            set { _currentView = value; OnPropertyChanged(); }
        }

        public ICommand HomeCommand { get; set; }
        public ICommand CustomersCommand { get; set; }
        public ICommand OrdersCommand { get; set; }
        public ICommand ProductsCommand { get; set; }
        public ICommand SettingsCommand { get; set; }
        public ICommand ShipmentsCommand { get; set; }        
        public ICommand TransactionsCommand { get; set; }

        private void Home(object obj) => CurrentView = new HomeViewModel();
        private void Customers(object obj) => CurrentView = new CustomersViewModel();
        private void Orders(object obj) => CurrentView = new OrdersViewModel();
        private void Products(object obj) => CurrentView = new ProductsViewModel();
        private void Settings(object obj) => CurrentView = new SettingsViewModel();
        private void Shipments(object obj) => CurrentView = new ShipmentsViewModel();
        private void Transactions(object obj) => CurrentView = new TransactionsViewModel();

        public NavigationViewModel()
        {
            HomeCommand = new RelayCommand(Home);
            CustomersCommand = new RelayCommand(Customers);
            OrdersCommand = new RelayCommand(Orders);
            ProductsCommand = new RelayCommand(Products);
            SettingsCommand = new RelayCommand(Settings);
            ShipmentsCommand = new RelayCommand(Shipments);
            TransactionsCommand = new RelayCommand(Transactions);

            CurrentView = new HomeViewModel();
        }
    }
}
