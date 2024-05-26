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
        private readonly IRoomReservationDbContextFactory _dbContextFactory;

        public DatabaseReservationConflictValidator(IRoomReservationDbContextFactory dbContextFactory)
        {
            _dbContextFactory = dbContextFactory;
        }

        public async Task<Reservation> GetConflictingReservation(Reservation reservation)
        {
            using (RoomReservationDbContext context = _dbContextFactory.CreateDbContext())
            {
                ReservationDTO reservationDTO = await context.Reservations
                    .Where(r => r.FloorNumber == reservation.RoomId.FloorNumber)
                    .Where(r => r.RoomNumber == reservation.RoomId.RoomNumber)
                    .Where(r => r.EndDate > reservation.StartDate)
                    .Where(r => r.StartDate < reservation.EndDate)
                    .FirstOrDefaultAsync();

                if (reservationDTO == null)
                {
                    return null;
                }

                return ToReservation(reservationDTO);
            }
        }

        private static Reservation ToReservation(ReservationDTO dto)
        {
            return new Reservation(new RoomID(dto.FloorNumber, dto.RoomNumber), dto.Username, dto.StartDate, dto.EndDate);
        }
    }
}