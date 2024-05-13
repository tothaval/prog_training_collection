using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF_MVVM_Training6_Login.Stores;
using WPF_MVVM_Training6_Login.Services;
using WPF_MVVM_Training6_Login.ViewModels;

namespace WPF_MVVM_Training6_Login.Commands
{
    internal class NavigateCommand : BaseCommand
    {
        private readonly INavigationService _navigationService;

        public override void Execute(object? parameter)
        {
            _navigationService.Navigate();
        }

        public NavigateCommand(INavigationService navigationService)
        {
            _navigationService = navigationService;

        }
    }
}
