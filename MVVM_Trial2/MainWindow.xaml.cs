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

namespace MVVM_Trial2
{
    /// <summary>
    /// MVVM Trial following a tutorial on youtube
    /// many thx to: https://www.youtube.com/watch?v=CABv5xIDC08&ab_channel=MouseEvents
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainVM(); // connectiong the view with the model
        }
    }
}