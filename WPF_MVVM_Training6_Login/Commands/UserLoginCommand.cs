using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WPF_MVVM_Training6_Login.Models;
using WPF_MVVM_Training6_Login.Stores;
using WPF_MVVM_Training6_Login.Services;
using WPF_MVVM_Training6_Login.ViewModels;

namespace WPF_MVVM_Training6_Login.Commands
{
    internal class UserLoginCommand : BaseCommand
    {
        private readonly LoginViewModel _loginViewModel;
        private readonly AccountStore _accountStore;
        private readonly INavigationService _navigationService;
        private readonly CompositNavigationService _modalNavigationStore;

        public UserLoginCommand(LoginViewModel loginViewModel, AccountStore accountStore, INavigationService navigationService,
            CompositNavigationService modalNavigationStore)
        {
            _loginViewModel = loginViewModel;
            _accountStore = accountStore;
            _navigationService = navigationService;
            _modalNavigationStore = modalNavigationStore;
        }

        public override void Execute(object? parameter)
        {
            Account account = new Account()
            {
                Email = $"{_loginViewModel.Username}@email.de",
                Username = _loginViewModel.Username
            };

            _accountStore.CurrentAccount = account;

            _navigationService.Navigate();
            _modalNavigationStore.Navigate();
        }
    }
}
