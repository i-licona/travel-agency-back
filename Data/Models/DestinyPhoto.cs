using System;
using System.Collections.Generic;

namespace travel_agency_back.Data.Models
{
    public partial class DestinyPhoto
    {
        public int Id { get; set; }
        public string UrlPhoto { get; set; } = null!;
        public int IdDestiny { get; set; }

        public virtual Destiny IdDestinyNavigation { get; set; } = null!;
    }
}
