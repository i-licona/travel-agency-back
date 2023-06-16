using System;
using System.Collections.Generic;

namespace travel_agency_back.Data.Models
{
    public partial class HotelPhoto
    {
        public int Id { get; set; }
        public string UrlPhoto { get; set; } = null!;
        public int IdHotel { get; set; }

        public virtual Hotel IdHotelNavigation { get; set; } = null!;
    }
}
