using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomReservation_MVVM.Models
{
    public class Reservation
    {
        public RoomID RoomId { get; }
        public string Username { get; }
        public DateTime StartDate { get; }
        public DateTime EndDate { get; }
        public TimeSpan Duration => EndDate.Subtract(StartDate);

        public Reservation(RoomID roomID, string username, DateTime startTime, DateTime endTime)
        {
            RoomId = roomID;
            Username = username;
            StartDate = startTime;
            EndDate = endTime;
        }

        internal bool Conflicts(Reservation reservation)
        {
            if (reservation.RoomId != RoomId)
            {
                return false;
            }

            return reservation.StartDate < EndDate || reservation.EndDate > StartDate;
        }
    }
}
