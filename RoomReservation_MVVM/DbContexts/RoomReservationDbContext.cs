using Microsoft.EntityFrameworkCore;
using RoomReservation_MVVM.DTOs;
using RoomReservation_MVVM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomReservation_MVVM.DbContexts
{
    public class RoomReservationDbContext : DbContext
    {
        public RoomReservationDbContext(DbContextOptions options) : base(options) { }

        public DbSet<ReservationDTO> Reservations { get; set; }
    }
}