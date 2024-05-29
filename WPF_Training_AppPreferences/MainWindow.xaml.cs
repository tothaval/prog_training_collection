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

using System.Configuration;

namespace WPF_Training_AppPreferences
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Configuration AppConfig = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

        string[] Languages = new string[] { "English", "Spanish", "German", "Japanese" };
        string[] Themes = new string[] { "Dark", "Light" };

        public MainWindow()
        {
            InitializeComponent();

            LanguageCombobox.ItemsSource = Languages;
            ThemesCombobox.ItemsSource = Themes;

            if (AppConfig.Sections["UISettings"] is null)
            {
                AppConfig.Sections.Add("UISettings", new UISettings());
            }


            var UISettingsSection = AppConfig.GetSection("UISettings");


            this.DataContext = UISettingsSection;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AppConfig.Save();
        }
    }
}