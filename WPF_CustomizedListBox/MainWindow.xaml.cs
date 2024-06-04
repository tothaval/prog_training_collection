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

namespace WPF_CustomizedListBox
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var data = new[]
            {
                new {Name = "Jim" },
                new {Name = "Mike" },
                new {Name = "John" },
                new {Name = "Luke" },
                new {Name = "Oscar" },
                new {Name = "Charles" }
            };

            MyListBox.ItemsSource = data;
        }

        private void TileItem_Click(object sender, RoutedEventArgs e)
        {
            MyListBox.layout = LayoutListBox.Layout.Tile;
        }

        private void ListItem_Click(object sender, RoutedEventArgs e)
        {
            MyListBox.layout = LayoutListBox.Layout.List;
        }
    }
}