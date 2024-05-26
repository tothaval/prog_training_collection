using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using RoomReservation_MVVM.DbContexts;
using RoomReservation_MVVM.Exceptions;
using RoomReservation_MVVM.HostBuilders;
using RoomReservation_MVVM.Models;
using RoomReservation_MVVM.Services;
using RoomReservation_MVVM.Services.ReservationConflictValidators;
using RoomReservation_MVVM.Services.ReservationCreators;
using RoomReservation_MVVM.Services.ReservationProviders;
using RoomReservation_MVVM.Stores;
using RoomReservation_MVVM.ViewModels;
using System.Configuration;
using System.Data;
using System.Windows;

namespace RoomReservation_MVVM
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly IHost _host;

        public App()
        {
            _host = Host.CreateDefaultBuilder()
                .AddViewModels()
                .ConfigureServices((hostContext, services) =>
                {
                    bool isEndToEndTest = Environment.GetCommandLineArgs().Any(a => a == "E2E");

                    if (!isEndToEndTest)
                    {
                        string connectionString = hostContext.Configuration.GetConnectionString("Default");
                        services.AddSingleton<IRoomReservationDbContextFactory>(new RoomReservationDbContextFactory(connectionString));
                    }
                    else
                    {
                        services.AddSingleton<IRoomReservationDbContextFactory>(new InMemoryRoomReservationDbContextFactory());
                    }

                    services.AddSingleton<IReservationProvider, DatabaseReservationProvider>();
                    services.AddSingleton<IReservationCreator, DatabaseReservationCreator>();
                    services.AddSingleton<IReservationConflictValidator, DatabaseReservationConflictValidator>();

                    services.AddTransient<ReservationBook>();

                    string hotelName = hostContext.Configuration.GetValue<string>("HotelName");
                    services.AddSingleton((s) => new Hotel(hotelName, s.GetRequiredService<ReservationBook>()));

                    services.AddSingleton<HotelStore>();
                    services.AddSingleton<NavigationStore>();

                    services.AddSingleton(s => new MainWindow()
                    {
                        DataContext = s.GetRequiredService<MainViewModel>()
                    });
                })
                .Build();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            _host.Start();

            IRoomReservationDbContextFactory reservoomDbContextFactory = _host.Services.GetRequiredService<IRoomReservationDbContextFactory>();
            using (RoomReservationDbContext dbContext = reservoomDbContextFactory.CreateDbContext())
            {
                dbContext.Database.Migrate();
            }

            NavigationService<ReservationListingViewModel> navigationService = _host.Services.GetRequiredService<NavigationService<ReservationListingViewModel>>();
            navigationService.Navigate();

            MainWindow = _host.Services.GetRequiredService<MainWindow>();
            MainWindow.Show();

            base.OnStartup(e);
        }

        protected override void OnExit(ExitEventArgs e)
        {
            _host.Dispose();

            base.OnExit(e);
        }
    }
}