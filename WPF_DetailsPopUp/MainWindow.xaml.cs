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

namespace WPF_Details
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var data = new[] {
                new {
                    name = "Yuli Robertson",
                    phone = "(924) 480-2633",
                    email = "nullam.scelerisque@aol.ca",
                    address = "3867 Ullamcorper. Rd.",
                    country = "New Zealand"
                },
                new {
                    name = "Jameson Compton",
                    phone = "1-839-671-6357",
                    email = "sit.amet.metus@aol.edu",
                    address = "1800 Vestibulum Road",
                    country = "Netherlands"
                },
                new {
                    name = "Teegan Alexander",
                    phone = "1-724-884-1846",
                    email = "augue.ac@yahoo.org",
                    address = "2207 Quis St.",
                    country = "New Zealand"
                },
                new {
                    name = "Sopoline Dejesus",
                    phone = "1-423-656-2688",
                    email = "pellentesque.ut@aol.org",
                    address = "2159 Diam. Av.",
                    country = "Ukraine"
                },
                new {
                    name = "Latifah Stephens",
                    phone = "1-447-333-7639",
                    email = "eget.mollis.lectus@google.org",
                    address = "P.O. Box 334, 866 In Road",
                    country = "Ireland"
                }
            };
            
            MyGrid.ItemsSource = data;
        }

        private void DataGridRow_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                var row = e.Source as DataGridRow;

                DetailsWindow detailsWindow = new DetailsWindow(row.Item);
                detailsWindow.Owner = Application.Current.MainWindow;

                detailsWindow.WindowStartupLocation = WindowStartupLocation.CenterOwner;

                detailsWindow.Show();
            }
        }
    }
}