using Microsoft.EntityFrameworkCore;
using RoomReservation_MVVM.DbContexts;
using RoomReservation_MVVM.DTOs;
using RoomReservation_MVVM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomReservation_MVVM.Services.ReservationProviders
{
    public class DatabaseReservationProvider : IReservationProvider
    {
        private readonly RoomReservationDbContextFactory _dbContextFactory;

        public DatabaseReservationProvider(RoomReservationDbContextFactory dbContextFactory)
        {
            _dbContextFactory = dbContextFactory;
        }

        public async Task<IEnumerable<Reservation>> GetAllReservations()
        {
            using (RoomReservationDbContext context = _dbContextFactory.CreateDbContext())
            {
                IEnumerable<ReservationDTO> reservationDTOs = await context.Reservations.ToListAsync();

                return reservationDTOs.Select(r => ToReservation(r));
            }

            static Reservation ToReservation(ReservationDTO r)
            {
                return new Reservation(new RoomID(r.FloorNumber, r.RoomNumber), r.Username, r.StartDate, r.EndDate);
            }
        }
    }
}
