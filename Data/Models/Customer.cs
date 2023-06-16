using System;
using System.Collections.Generic;

namespace travel_agency_back.Data.Models
{
    public partial class Customer
    {
        public Customer()
        {
            DestinyBuys = new HashSet<DestinyBuy>();
            FlightBuys = new HashSet<FlightBuy>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Firstname { get; set; } = null!;
        public string Lastname { get; set; } = null!;
        public string Address { get; set; } = null!;
        public DateTime Birthday { get; set; }
        public string Photo { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;

        public virtual ICollection<DestinyBuy> DestinyBuys { get; set; }
        public virtual ICollection<FlightBuy> FlightBuys { get; set; }
    }
}
