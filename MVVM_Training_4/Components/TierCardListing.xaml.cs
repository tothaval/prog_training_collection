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

namespace MVVM_Training_4.Components
{
    /// <summary>
    /// Interaktionslogik für TierCardListing.xaml
    /// </summary>
    public partial class TierCardListing : UserControl
    {
        public TierCardListing()
        {
            InitializeComponent();
        }


        private void OnJoinBasicClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("You joined the basic tier.", "Join success.",
                MessageBoxButton.OKCancel, MessageBoxImage.Information);
        }

        private void OnJoinProClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("You joined the pro tier.", "Join success.",
                MessageBoxButton.OKCancel, MessageBoxImage.Information);
        }


        private void OnJoinEnterpriseClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("You joined the enterprise tier.", "Join success.",
                MessageBoxButton.OKCancel, MessageBoxImage.Information);
        }
    }
}
