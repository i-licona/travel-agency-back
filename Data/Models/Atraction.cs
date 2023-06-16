using System;
using System.Collections.Generic;

namespace travel_agency_back.Data.Models
{
    public partial class Atraction
    {
        public Atraction()
        {
            AtractionsPhotos = new HashSet<AtractionsPhoto>();
            DestinyBuyAtractions = new HashSet<DestinyBuyAtraction>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public decimal Cost { get; set; }
        public int IdDestiny { get; set; }

        public virtual Destiny IdDestinyNavigation { get; set; } = null!;
        public virtual ICollection<AtractionsPhoto> AtractionsPhotos { get; set; }
        public virtual ICollection<DestinyBuyAtraction> DestinyBuyAtractions { get; set; }
    }
}
