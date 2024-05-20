using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using WPF_MVVM_Training7.Commands;
using WPF_MVVM_Training7.Models;

namespace WPF_MVVM_Training7.ViewModels
{
    internal class LoginViewModel : ViewModelBase
    {
        private User user;
        private string userName;
        public ICommand LoginCommand { get; }

        public LoginViewModel()
        {
                user = new User();
            LoginCommand = new RelayCommand((param) => LoggedIn(param));
        }

        public string UserName { 
            get => user.UserName;
            set
            {
                user.UserName = value;
                OnPropertyChanged(nameof(UserName));
            }
        }

        public string Password
        {
            get => user.Password;
            set
            {
                user.Password = value;
                OnPropertyChanged(nameof(Password));
            }
        }

        private void LoggedIn(object param)
        {
            MessageBox.Show($"Logged in SuccessFull as {param}");
        }

    }
}
