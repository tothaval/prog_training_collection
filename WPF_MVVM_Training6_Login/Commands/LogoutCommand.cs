using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF_MVVM_Training6_Login.Services;
using WPF_MVVM_Training6_Login.Stores;
using WPF_MVVM_Training6_Login.ViewModels;

namespace WPF_MVVM_Training6_Login.Commands
{
    internal class LogoutCommand : BaseCommand
    {
        private readonly AccountStore _accountStore;
        private readonly INavigationService _homeNavigationService;

        public LogoutCommand(AccountStore accountStore, INavigationService homeNavigationService)
        {
            _accountStore = accountStore;
            _homeNavigationService = homeNavigationService;
        }

        public override void Execute(object? parameter)
        {
            _accountStore.logout();
            _homeNavigationService.Navigate();
        }
    }
}
