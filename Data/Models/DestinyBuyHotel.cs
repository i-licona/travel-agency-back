using System;
using System.Collections.Generic;

namespace travel_agency_back.Data.Models
{
    public partial class DestinyBuyHotel
    {
        public int Id { get; set; }
        public decimal Cost { get; set; }
        public DateTime Date { get; set; }
        public int IdHotelRoom { get; set; }
        public int IdDestinyBuy { get; set; }

        public virtual DestinyBuy IdDestinyBuyNavigation { get; set; } = null!;
        public virtual HotelRoom IdHotelRoomNavigation { get; set; } = null!;
    }
}
