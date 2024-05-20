using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WPF_MVVM_Training7.ViewModels;

namespace WPF_MVVM_Training7
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        IDialogService _dialogService;

        internal MainWindow(IDialogService dialogService)
        {
            _dialogService = dialogService;

            InitializeComponent();
        }

        private void BlueView_Clicked(object sender, RoutedEventArgs e)
        {
            DataContext = new BlueViewModel();
        }

        private void OrangeView_Clicked(object sender, RoutedEventArgs e)
        {
            DataContext = new OrangeViewModel();
        }

        private void RedView_Clicked(object sender, RoutedEventArgs e)
        {
            DataContext = new RedViewModel();
        }

        private void LoginView_Clicked(object sender, RoutedEventArgs e)
        {
            DataContext = new LoginViewModel();
        }


        private void DesignButton_Clicked(object sender, RoutedEventArgs e)
        {
            DataContext = new DesignButtonViewModel();
        }

        private void DialogView_Clicked(object sender, RoutedEventArgs e)
        {
            DataContext = new DialogViewModel(_dialogService);
        }
    }
}