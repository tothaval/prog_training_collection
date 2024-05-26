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
    public class LoginCommand : BaseCommand
    {
        private readonly LoginViewModel _viewModel;
        private readonly AccountStore _accountStore;
        private readonly INavigationService _navigationService;

        public LoginCommand(LoginViewModel viewModel, AccountStore accountStore, INavigationService navigationService)
        {
            _viewModel = viewModel;
            _accountStore = accountStore;
            _navigationService = navigationService;
        }

        public override void Execute(object parameter)
        {
            Account account = new Account()
            {
                Email = $"{_viewModel.Username}@test.com",
                Username = _viewModel.Username
            };

            _accountStore.CurrentAccount = account;

            _navigationService.Navigate();
        }
    }
}