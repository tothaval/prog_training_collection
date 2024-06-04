using System.ComponentModel.Design;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF_Commands
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

        private void CommandBinding_0_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = Application.Current.MainWindow.OwnedWindows.Count < 1;
        }


        /* builtin commands:
         * ApplicationCommands
         * ComponentCommands
         * EditingCommands
         * MediaCommands
         * NavigationCommands
         * SystemCommands
         * 
         * RibbonCommands
         * StandardCommands
         */

        private void CommandBinding_0_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            if (e.Parameter == null)
            {
                MainWindow mainWindow = new MainWindow();
                mainWindow.Owner = Application.Current.MainWindow;
                mainWindow.Show();
            }
            
            var obj = e.Parameter as string;
            MessageBox.Show(obj);
        }


        private void CommandBinding_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;         
        }


        /* builtin commands:
         * ApplicationCommands
         * ComponentCommands
         * EditingCommands
         * MediaCommands
         * NavigationCommands
         * SystemCommands
         * 
         * RibbonCommands
         * StandardCommands
         */

        private void CommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            var obj = e.Parameter as string;

            MessageBox.Show(obj);

            //MainWindow mainWindow = new MainWindow();
            //mainWindow.Owner = Application.Current.MainWindow;
            //mainWindow.Show();
        }
    }
}