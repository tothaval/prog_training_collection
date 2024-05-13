using System.Configuration;
using System.Data;
using System.Windows;
using WPF_MVVM_Training6_Login.Services;
using WPF_MVVM_Training6_Login.Stores;
using WPF_MVVM_Training6_Login.ViewModels;
using WPF_MVVM_Training6_Login.Views;

namespace WPF_MVVM_Training6_Login
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly AccountStore _accountStore;
        private readonly NavigationStore _navigationStore;
        private readonly ModalNavigationStore _modalNavigationStore;


        public App()
        {
            _accountStore = new AccountStore();
            _navigationStore = new NavigationStore();
            _modalNavigationStore = new ModalNavigationStore();
        }


        protected override void OnStartup(StartupEventArgs e)
        {
            INavigationService homeNavigationService = CreateHomeNavigationService();
            homeNavigationService.Navigate();

            MainWindow mainWindow = new MainWindow()
            {
                DataContext = new MainViewModel(_navigationStore, _modalNavigationStore)
            };

            mainWindow.Show();

            base.OnStartup(e);
        }

        private INavigationService CreateHomeNavigationService()
        {
            return new LayoutNavigationService<HomeViewModel>(
                _navigationStore,
                () => new HomeViewModel(CreateLoginNavigationService()),
                CreateNavigationBarViewModel);
        }

        private INavigationService CreateAccountNavigationService()
        {
            return new LayoutNavigationService<AccountViewModel>(
                _navigationStore,
                () => new AccountViewModel(_accountStore, CreateHomeNavigationService()),
                CreateNavigationBarViewModel
                );
        }

        private INavigationService CreateLoginNavigationService()
        {
            CompositNavigationService compositNavigationService = new CompositNavigationService(
                new CloseModalNavigationService(_modalNavigationStore),
                CreateAccountNavigationService()
                );

            return new ModalNavigationService<LoginViewModel>(
                _modalNavigationStore,
                () => new LoginViewModel(_accountStore, CreateHomeNavigationService(), CreateAccountNavigationService(),
                _modalNavigationStore,
                compositNavigationService)
                );
        }

        private NavigationBarViewModel CreateNavigationBarViewModel()
        {
            return new NavigationBarViewModel(
                _accountStore,
                CreateHomeNavigationService(),
                CreateAccountNavigationService(),
                CreateLoginNavigationService());
        }
            
            
    }

}
