using System;
using System.Collections.Generic;

namespace travel_agency_back.Data.Models
{
    public partial class Flight
    {
        public Flight()
        {
            FlightBuys = new HashSet<FlightBuy>();
        }

        public int Id { get; set; }
        public string DepartureCity { get; set; } = null!;
        public string DestinyCity { get; set; } = null!;
        public DateTime Date { get; set; }
        public decimal Cost { get; set; }
        public int IdAirport { get; set; }

        public virtual Airport IdAirportNavigation { get; set; } = null!;
        public virtual ICollection<FlightBuy> FlightBuys { get; set; }
    }
}
