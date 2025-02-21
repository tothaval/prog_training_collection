using Microsoft.Extensions.DependencyInjection;
using System.Configuration;
using System.Data;
using System.Windows;
using TreeViewTraining.Services;
using TreeViewTraining.ViewModels;

namespace TreeViewTraining
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {

        public App()
        {
            CommunityToolkit.Mvvm.DependencyInjection.Ioc.Default.ConfigureServices(
                new ServiceCollection()
                    .AddSingleton<IBookService, BookService>()
                    .AddTransient<MainWindowViewModel>()
                    .BuildServiceProvider()
                    );
                
        }
    }

}
