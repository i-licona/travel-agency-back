using System;
using System.Collections.Generic;

namespace travel_agency_back.Data.Models
{
    public partial class FlightBuyItem
    {
        public int Id { get; set; }
        public string NamePassenger { get; set; } = null!;
        public string LastnamePassenger { get; set; } = null!;
        public DateTime BirthdayPassenger { get; set; }
        public int TicketNumber { get; set; }
        public DateTime Date { get; set; }
        public int IdFlightBuy { get; set; }
        public decimal Cost { get; set; }

        public virtual FlightBuy IdFlightBuyNavigation { get; set; } = null!;
    }
}
