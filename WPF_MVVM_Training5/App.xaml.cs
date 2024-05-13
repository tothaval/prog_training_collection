using System.Configuration;
using System.Data;
using System.Windows;
using WPF_MVVM_Training5.Navigation;
using WPF_MVVM_Training5.ViewModels;

namespace WPF_MVVM_Training5
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
            _navigationStore.CurrentViewModel = new TargetViewModel(_navigationStore, "Startup");

            MainWindow mainWindow = new MainWindow()
            {
                DataContext = new MainViewModel(_navigationStore)
            };

            mainWindow.Show();


            base.OnStartup(e);
        }

    }

}
