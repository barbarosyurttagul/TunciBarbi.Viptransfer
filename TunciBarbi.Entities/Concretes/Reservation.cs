using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VipTransfer.Entities.Concretes
{
    public class Reservation
    {
        public Departure DepartureId { get; set; }

        public Arrival ArrivalId { get; set; }
        public DateTime ReservationTime { get; set; }

        public byte AdultNumber { get; set; }

        public byte ChildNumber { get; set; }

    }
}
