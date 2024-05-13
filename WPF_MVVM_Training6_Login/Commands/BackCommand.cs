using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF_MVVM_Training6_Login.Services;
using WPF_MVVM_Training6_Login.Stores;

namespace WPF_MVVM_Training6_Login.Commands
{
    internal class BackCommand : BaseCommand
    {
        private readonly ModalNavigationStore _modalNavigationStore;
        private readonly INavigationService _navigationService;

        public BackCommand(ModalNavigationStore modalNavigationStore,
              INavigationService homeNavigationservice)
        {
            _modalNavigationStore = modalNavigationStore;                
            _navigationService = homeNavigationservice;
        }


        public override void Execute(object? parameter)
        {
            _modalNavigationStore.Close();
            _navigationService.Navigate();
        }
    }
}
