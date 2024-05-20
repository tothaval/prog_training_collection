using System.Configuration;
using System.Data;
using System.Windows;
using WPF_MVVM_Training7.ViewModels;
using WPF_MVVM_Training7.Views;

namespace WPF_MVVM_Training7
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            IDialogService dialogService = new DialogService(MainWindow);

            dialogService.Register<DialogWindowViewModel, DialogView>();

            var viewModel = new DialogViewModel(dialogService);
            var view = new MainWindow(dialogService);

            view.ShowDialog();

            base.OnStartup(e);
        }

    }

}
