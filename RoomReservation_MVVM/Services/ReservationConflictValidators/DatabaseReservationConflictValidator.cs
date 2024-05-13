using Microsoft.EntityFrameworkCore;
using RoomReservation_MVVM.DbContexts;
using RoomReservation_MVVM.DTOs;
using RoomReservation_MVVM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomReservation_MVVM.Services.ReservationConflictValidators
{
    public class DatabaseReservationConflictValidator : IReservationConflictValidator
    {
        private readonly RoomReservationDbContextFactory _dbContextFactory;

        public DatabaseReservationConflictValidator(RoomReservationDbContextFactory dbContextFactory)
        {
            _dbContextFactory = dbContextFactory;
        }

        public async Task<bool> DoesCauseConflict(Reservation reservation)
        {
            using (RoomReservationDbContext context = _dbContextFactory.CreateDbContext())
            {
                return await context.Reservations.Select(r => ToReservations(r)).AnyAsync(r => r.Conflicts(reservation));
            }
        }

        private static Reservation ToReservations(ReservationDTO r)
        {
            return new Reservation(new RoomID(r.FloorNumber, r.RoomNumber), r.Username, r.StartDate, r.EndDate);
        }
    }
}
