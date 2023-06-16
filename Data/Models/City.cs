using System;
using System.Collections.Generic;

namespace travel_agency_back.Data.Models
{
    public partial class City
    {
        public City()
        {
            Airports = new HashSet<Airport>();
            Destinies = new HashSet<Destiny>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int IdCountry { get; set; }

        public virtual Country IdCountryNavigation { get; set; } = null!;
        public virtual ICollection<Airport> Airports { get; set; }
        public virtual ICollection<Destiny> Destinies { get; set; }
    }
}
