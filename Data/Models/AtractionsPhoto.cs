using System;
using System.Collections.Generic;

namespace travel_agency_back.Data.Models
{
    public partial class AtractionsPhoto
    {
        public int Id { get; set; }
        public string UrlPhoto { get; set; } = null!;
        public int IdAtraction { get; set; }

        public virtual Atraction IdAtractionNavigation { get; set; } = null!;
    }
}
