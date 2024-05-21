using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Configuration;
using Serilog;
using System.Configuration;
using System.Data;
using System.Windows;

namespace WPF_MVVM_Training8
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {

        protected override void OnStartup(StartupEventArgs e)
        {
                      
            ILoggerFactory loggerFactory = LoggerFactory.Create(builder =>
            {
                builder.ClearProviders();
                builder.AddDebug();
                builder.SetMinimumLevel(LogLevel.Warning);
                builder.AddFilter("WPF_MVVM_Training8", LogLevel.Debug);
            });



            MainWindow mainWindow = new MainWindow();

            mainWindow.DataContext = new MainWindowViewModel(loggerFactory);

            mainWindow.Show();


            base.OnStartup(e);
        }
    }

}
