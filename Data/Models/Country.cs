using System;
using System.Collections.Generic;

namespace travel_agency_back.Data.Models
{
    public partial class Country
    {
        public Country()
        {
            Cities = new HashSet<City>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Coin { get; set; } = null!;

        public virtual ICollection<City> Cities { get; set; }
    }
}
