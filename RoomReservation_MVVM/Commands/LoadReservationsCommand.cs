using RoomReservation_MVVM.Models;
using RoomReservation_MVVM.Stores;
using RoomReservation_MVVM.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace RoomReservation_MVVM.Commands
{
    internal class LoadReservationsCommand : AsyncCommandBase
    {
        private readonly HotelStore _hotelStore;
        private readonly ReservationListingViewModel _viewModel;

        public LoadReservationsCommand(ReservationListingViewModel viewModel, HotelStore hotelStore)
        {
            _hotelStore = hotelStore;
            _viewModel = viewModel;
        }

        public override async Task ExecuteAsync(object? parameter)
        {
            _viewModel.ErrorMessage = string.Empty;
            _viewModel.IsLoading = true;

            try
            {
                await _hotelStore.Load();

                _viewModel.UpdateReservations(_hotelStore.Reservations);
            }
            catch (Exception)
            {
                _viewModel.ErrorMessage = "Failed to load reservations.";
            }
            
            _viewModel.IsLoading = false;
        }
    }
}
