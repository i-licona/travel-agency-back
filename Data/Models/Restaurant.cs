using System;
using System.Collections.Generic;

namespace travel_agency_back.Data.Models
{
    public partial class Restaurant
    {
        public Restaurant()
        {
            RestaurantPhotos = new HashSet<RestaurantPhoto>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Address { get; set; }
        public int IdDestiny { get; set; }

        public virtual Destiny IdDestinyNavigation { get; set; } = null!;
        public virtual ICollection<RestaurantPhoto> RestaurantPhotos { get; set; }
    }
}
