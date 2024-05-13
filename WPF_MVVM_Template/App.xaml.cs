using System.Configuration;
using System.Data;
using System.Windows;
using WPF_MVVM_Template.Navigation;
using WPF_MVVM_Template.ViewModels;

namespace WPF_MVVM_Template
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private NavigationStore _navigationStore;

        public App()
        {
                _navigationStore = new NavigationStore();
        }


        protected override void OnStartup(StartupEventArgs e)
        {
            _navigationStore.CurrentViewModel = new ExampleViewModel();

            MainWindow mainWindow = new MainWindow()
            {
                DataContext = new MainViewModel(_navigationStore)
            };

            mainWindow.Show();


            base.OnStartup(e);
        }

    }

}
