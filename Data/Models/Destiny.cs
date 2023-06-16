using System;
using System.Collections.Generic;

namespace travel_agency_back.Data.Models
{
    public partial class Destiny
    {
        public Destiny()
        {
            Atractions = new HashSet<Atraction>();
            DestinyBuys = new HashSet<DestinyBuy>();
            DestinyPhotos = new HashSet<DestinyPhoto>();
            Hotels = new HashSet<Hotel>();
            Restaurants = new HashSet<Restaurant>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Address { get; set; }
        public decimal Cost { get; set; }
        public int IdCity { get; set; }

        public virtual City IdCityNavigation { get; set; } = null!;
        public virtual ICollection<Atraction> Atractions { get; set; }
        public virtual ICollection<DestinyBuy> DestinyBuys { get; set; }
        public virtual ICollection<DestinyPhoto> DestinyPhotos { get; set; }
        public virtual ICollection<Hotel> Hotels { get; set; }
        public virtual ICollection<Restaurant> Restaurants { get; set; }
    }
}
