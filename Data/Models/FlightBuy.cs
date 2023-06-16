using System;
using System.Collections.Generic;

namespace travel_agency_back.Data.Models
{
    public partial class FlightBuy
    {
        public FlightBuy()
        {
            FlightBuyItems = new HashSet<FlightBuyItem>();
        }

        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int IdFlight { get; set; }
        public int IdCustomer { get; set; }
        public int TotalCost { get; set; }

        public virtual Customer IdCustomerNavigation { get; set; } = null!;
        public virtual Flight IdFlightNavigation { get; set; } = null!;
        public virtual ICollection<FlightBuyItem> FlightBuyItems { get; set; }
    }
}
