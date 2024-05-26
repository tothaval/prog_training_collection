using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WPF_MVVM_Training6_Login.Commands;
using WPF_MVVM_Training6_Login.Models;
using WPF_MVVM_Training6_Login.Stores;
using WPF_MVVM_Training6_Login.Services;

namespace WPF_MVVM_Training6_Login.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        private string _username;
        public string Username
        {
            get
            {
                return _username;
            }
            set
            {
                _username = value;
                OnPropertyChanged(nameof(Username));
            }
        }

        private string _password;
        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                _password = value;
                OnPropertyChanged(nameof(Password));
            }
        }

        public ICommand LoginCommand { get; }

        public LoginViewModel(AccountStore accountStore, INavigationService loginNavigationService)
        {
            LoginCommand = new LoginCommand(this, accountStore, loginNavigationService);
        }
    }
}