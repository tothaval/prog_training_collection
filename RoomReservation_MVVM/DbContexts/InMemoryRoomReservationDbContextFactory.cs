using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomReservation_MVVM.DbContexts
{
    internal class InMemoryRoomReservationDbContextFactory : IRoomReservationDbContextFactory
    {
        private readonly SqliteConnection _connection;

        public InMemoryRoomReservationDbContextFactory()
        {
            _connection = new SqliteConnection("Data Source=:memory:");
            _connection.Open();
        }

        public RoomReservationDbContext CreateDbContext()
        {
            DbContextOptions options = new DbContextOptionsBuilder().UseSqlite(_connection).Options;

            return new RoomReservationDbContext(options);
        }
    }
}