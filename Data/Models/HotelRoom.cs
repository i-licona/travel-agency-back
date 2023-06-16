using System;
using System.Collections.Generic;

namespace travel_agency_back.Data.Models
{
    public partial class HotelRoom
    {
        public HotelRoom()
        {
            DestinyBuyHotels = new HashSet<DestinyBuyHotel>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int? Capacity { get; set; }
        public decimal Cost { get; set; }
        public int? QuantityRoms { get; set; }
        public int IdHotel { get; set; }

        public virtual Hotel IdHotelNavigation { get; set; } = null!;
        public virtual ICollection<DestinyBuyHotel> DestinyBuyHotels { get; set; }
    }
}
