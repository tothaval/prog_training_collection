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
    internal class AccountViewModel : BaseViewModel
    {
        private readonly AccountStore _accountStore;
        public string Username => _accountStore.CurrentAccount?.Username;
        public string Email => _accountStore.CurrentAccount?.Email;
        
        public ICommand NavigateHomeCommand { get; }


        public AccountViewModel(AccountStore accountStore, INavigationService homeNavigationService)
        {
            _accountStore = accountStore;

            NavigateHomeCommand = new NavigateCommand(homeNavigationService);

            _accountStore.CurrentAccountChanged += OnCurrentAccountChanged;
        }

        ~AccountViewModel() 
        { 

        }

        private void OnCurrentAccountChanged()
        {
            OnPropertyChanged(nameof(Username));
            OnPropertyChanged(nameof(Email));
        }

        public override void Dispose()
        {
            _accountStore.CurrentAccountChanged -= OnCurrentAccountChanged;

            base.Dispose();
        }

    }
}
