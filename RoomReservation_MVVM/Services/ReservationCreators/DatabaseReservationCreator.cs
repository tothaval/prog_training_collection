using Microsoft.EntityFrameworkCore;
using RoomReservation_MVVM.DbContexts;
using RoomReservation_MVVM.DTOs;
using RoomReservation_MVVM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomReservation_MVVM.Services.ReservationCreators
{
    internal class DatabaseReservationCreator : IReservationCreator
    {
        private readonly RoomReservationDbContextFactory _dbContextFactory;

        public DatabaseReservationCreator(RoomReservationDbContextFactory dbContextFactory)
        {
            _dbContextFactory = dbContextFactory;
        }

        public async Task CreateReservation(Reservation reservation)
        {
            using (RoomReservationDbContext context = _dbContextFactory.CreateDbContext())
            {
                ReservationDTO reservationDTO = ToReservationDTO(reservation);

                context.Reservations.Add(reservationDTO);
                await context.SaveChangesAsync();
            }
        }

        private ReservationDTO ToReservationDTO(Reservation reservation)
        {
            return new ReservationDTO()
            {
                FloorNumber = reservation.RoomId?.FloorNumber ?? 0,
                RoomNumber = reservation.RoomId?.RoomNumber ?? 0,
                Username = reservation.Username,
                StartDate = reservation.StartDate,
                EndDate = reservation.EndDate
            };
        }
    }
}
