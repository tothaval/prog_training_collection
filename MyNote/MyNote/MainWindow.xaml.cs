using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MyNote
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
                

        public MainWindow()
        {
            InitializeComponent();

            Tab_history.history_entry("loading complete");
        }

         
        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                Tab_history.history_entry("dragmove");
                this.DragMove();
            }            
        }

        private void Window_MouseUp(object sender, MouseButtonEventArgs e)
        {

        }

        private void Window_MouseRightButtonUp(object sender, MouseButtonEventArgs e)
        {
            App.Current.Shutdown();

        }

        private void border_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Tab_matrix.save_matrix();

            XML_Handler handler = new XML_Handler();

            handler.save_log_to_xml(Tab_log.getNoteData());
            handler.save_notes_to_xml(Tab_notes.get_notes());            
            handler.save_history_to_xml(Tab_history.application_closing());

        }

        private void BTN_options_Click(object sender, RoutedEventArgs e)
        {
            if (SP_options.Visibility == Visibility.Collapsed)
            {
                SP_options.Visibility = Visibility.Visible;
            }
            else
            {
                SP_options.Visibility = Visibility.Collapsed;
            }

            e.Handled = true;
        }
    }
}
