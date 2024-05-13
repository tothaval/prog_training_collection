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

namespace WPF_MVVM_Training6_Login
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CloseModal_Click(object sender, RoutedEventArgs e)
        {
            modal.IsOpen = false;
        }

        private void ShowModal_Click(object sender, RoutedEventArgs e)
        {
            modal.IsOpen = true;
        }
    }
}