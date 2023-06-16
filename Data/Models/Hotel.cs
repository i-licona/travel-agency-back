using System;
using System.Collections.Generic;

namespace travel_agency_back.Data.Models
{
    public partial class Hotel
    {
        public Hotel()
        {
            HotelPhotos = new HashSet<HotelPhoto>();
            HotelRooms = new HashSet<HotelRoom>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Address { get; set; }
        public int IdDestiny { get; set; }

        public virtual Destiny IdDestinyNavigation { get; set; } = null!;
        public virtual ICollection<HotelPhoto> HotelPhotos { get; set; }
        public virtual ICollection<HotelRoom> HotelRooms { get; set; }
    }
}
