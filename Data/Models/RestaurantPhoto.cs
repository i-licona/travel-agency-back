using System;
using System.Collections.Generic;

namespace travel_agency_back.Data.Models
{
    public partial class RestaurantPhoto
    {
        public int Id { get; set; }
        public string UrlPhoto { get; set; } = null!;
        public int IdRestaurant { get; set; }

        public virtual Restaurant IdRestaurantNavigation { get; set; } = null!;
    }
}
