using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WPF_MVVM_SimplePageNavigation.Utilities;

namespace WPF_MVVM_SimplePageNavigation.ViewModels
{
    internal class MainViewModel : ObservableObject
    {
        private PageID _pageID;

        public PageID PageID
        {
            get { return _pageID; }
            set { SetProperty(ref _pageID, value); }
        }

        private string test;

        public string Test
        {
            get { return test; }
            set { test = value;
                OnPropertyChanged(nameof(Test));
            }
        }


        public ICommand CMDChangePage =>
            new RelayCommand<PageID>(ChangePage);

        public void ChangePage(PageID newPage)
        {
            PageID = newPage;
        }


        public MainViewModel()
        {
            PageID = PageID.A;
            Test = "Hello there ...";
        }
    }
}
