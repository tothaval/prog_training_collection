using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WPF_MVVM_Training6_Login.Commands;
using WPF_MVVM_Training6_Login.Services;
using WPF_MVVM_Training6_Login.Stores;

namespace WPF_MVVM_Training6_Login.ViewModels
{
    public class NavigationBarViewModel : BaseViewModel
    {
        private readonly AccountStore _accountStore;

        public ICommand NavigateHomeCommand { get; }
        public ICommand NavigateAccountCommand { get; }
        public ICommand NavigateLoginCommand { get; }
        public ICommand NavigatePeopleListingCommand { get; }
        public ICommand LogoutCommand { get; }

        public bool IsLoggedIn => _accountStore.IsLoggedIn;

        public NavigationBarViewModel(AccountStore accountStore,
            INavigationService homeNavigationService,
            INavigationService accountNavigationService,
            INavigationService loginNavigationService,
            INavigationService peopleListingNavigationService)
        {
            _accountStore = accountStore;
            NavigateHomeCommand = new NavigateCommand(homeNavigationService);
            NavigateAccountCommand = new NavigateCommand(accountNavigationService);
            NavigateLoginCommand = new NavigateCommand(loginNavigationService);
            NavigatePeopleListingCommand = new NavigateCommand(peopleListingNavigationService);
            LogoutCommand = new LogoutCommand(_accountStore);

            _accountStore.CurrentAccountChanged += OnCurrentAccountChanged;
        }

        private void OnCurrentAccountChanged()
        {
            OnPropertyChanged(nameof(IsLoggedIn));
        }

        public override void Dispose()
        {
            _accountStore.CurrentAccountChanged -= OnCurrentAccountChanged;

            base.Dispose();
        }
    }
}