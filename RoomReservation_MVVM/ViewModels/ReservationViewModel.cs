﻿using RoomReservation_MVVM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomReservation_MVVM.ViewModels
{
    internal class ReservationViewModel : ViewModelBase
    {
        private readonly Reservation _reservation;

        public string RoomId => _reservation.RoomId?.ToString();
        public string Username => _reservation.Username;
        public string StartDate => _reservation.StartDate.ToString("d");
        public string EndDate => _reservation.EndDate.ToString("d");

        public ReservationViewModel(Reservation reservation)
        {
            _reservation = reservation;
        }
    }
}
