using Microsoft.EntityFrameworkCore;
using RoomReservation_MVVM.DbContexts;
using RoomReservation_MVVM.Exceptions;
using RoomReservation_MVVM.Models;
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
        private const string CONNECTION_STRING = "Data Source=roomreservation.db";

        private readonly Hotel _hotel;
        private readonly NavigationStore _navigationStore;

        public App()
        {
            _hotel = new Hotel("The Mountain View Suites");
            _navigationStore = new NavigationStore();
        }


        protected override void OnStartup(StartupEventArgs e)
        {
            DbContextOptions options = new DbContextOptionsBuilder().UseSqlite(CONNECTION_STRING).Options;

            using (RoomReservationDbContext dbContext = new RoomReservationDbContext(options))
            {
                dbContext.Database.Migrate();
            }

            _navigationStore.CurrentViewModel = CreateReservationListingViewModel();

            MainWindow = new MainWindow()
            {
                DataContext = new MainViewModel(_navigationStore)
            };
            MainWindow.Show();

            base.OnStartup(e);
        }

        private MakeReservationViewModel CreateMakeReservationViewModel()
        {
            return new MakeReservationViewModel(_hotel, new Services.NavigationService(_navigationStore, CreateReservationListingViewModel));
        }

        private ReservationListingViewModel CreateReservationListingViewModel()
        {
            return new ReservationListingViewModel(_hotel, new Services.NavigationService(_navigationStore, CreateMakeReservationViewModel));
        }
    }

}
