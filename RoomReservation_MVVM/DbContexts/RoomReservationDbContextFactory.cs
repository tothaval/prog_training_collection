using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomReservation_MVVM.DbContexts
{
    public class RoomReservationDbContextFactory
    {
        private readonly string _connectionString;

        public RoomReservationDbContextFactory(string connectionString)
        {
            _connectionString = connectionString;
        }

        internal RoomReservationDbContext CreateDbContext()
        {
            DbContextOptions options = new DbContextOptionsBuilder().UseSqlite(_connectionString).Options;

            return new RoomReservationDbContext(options);
        }
    }
}
