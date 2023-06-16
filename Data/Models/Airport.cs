using System;
using System.Collections.Generic;

namespace travel_agency_back.Data.Models
{
    public partial class Airport
    {
        public Airport()
        {
            Flights = new HashSet<Flight>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Address { get; set; }
        public int IdCity { get; set; }

        public virtual City IdCityNavigation { get; set; } = null!;
        public virtual ICollection<Flight> Flights { get; set; }
    }
}
