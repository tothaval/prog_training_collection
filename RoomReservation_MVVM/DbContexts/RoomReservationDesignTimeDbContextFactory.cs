using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomReservation_MVVM.DbContexts
{
    internal class RoomReservationDesignTimeDbContextFactory : IDesignTimeDbContextFactory<RoomReservationDbContext>
    {
        public RoomReservationDbContext CreateDbContext(string[] args)
        {
            DbContextOptions options = new DbContextOptionsBuilder().UseSqlite("Data Source=roomreservation.db").Options;

            return new RoomReservationDbContext(options);
        }
    }
}
