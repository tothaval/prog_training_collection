using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomReservation_MVVM.DbContexts
{
    public class RoomReservationDesignTimeDbContextFactory : IDesignTimeDbContextFactory<RoomReservationDbContext>
    {
        public RoomReservationDbContext CreateDbContext(string[] args)
        {
            DbContextOptions options = new DbContextOptionsBuilder().UseSqlite("Data Source=reservoom.db").Options;

            return new RoomReservationDbContext(options);
        }
    }
}