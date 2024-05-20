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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF_MVVM_Training7.Views
{
    /// <summary>
    /// Interaktionslogik für DesignButtonView.xaml
    /// </summary>
    public partial class DesignButtonView : UserControl
    {
        public DesignButtonView()
        {
            InitializeComponent();            
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            Storyboard board = FindResource("Storyboard1") as Storyboard;

            board?.Begin();

        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            Storyboard storyboard = FindResource("Storyboard2") as Storyboard;

            storyboard?.Begin();
        }
    }
}
