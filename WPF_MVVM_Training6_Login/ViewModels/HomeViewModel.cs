using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WPF_MVVM_Training6_Login.Commands;
using WPF_MVVM_Training6_Login.Stores;
using WPF_MVVM_Training6_Login.Services;

namespace WPF_MVVM_Training6_Login.ViewModels
{
    internal class HomeViewModel : BaseViewModel
    {
        public ICommand LoginCommand { get; }

        public HomeViewModel(INavigationService loginNavigationService)
        {
            LoginCommand = new NavigateCommand(loginNavigationService);
        }
    }
}
