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
    internal class LoginViewModel : BaseViewModel
    {
        private string username;

        public string Username
        {
            get { return username; }
            set { username = value; OnPropertyChanged(nameof(Username)); }
        }


        //private string email;

        //public string Email
        //{
        //    get { return email; }
        //    set { email = value; OnPropertyChanged(nameof(Email)); }
        //}


        public ICommand BackCommand { get; }
        public ICommand LoginCommand { get; }

        public LoginViewModel(AccountStore accountStore,
            INavigationService homeNavigationservice,
            INavigationService accountNavigationService,
            ModalNavigationStore modalNavigationStore,
            CompositNavigationService closeModalNavigationService)
        {

            BackCommand = new BackCommand(modalNavigationStore, homeNavigationservice);
            LoginCommand = new UserLoginCommand(this, accountStore, accountNavigationService, closeModalNavigationService);
        }


    }
}
