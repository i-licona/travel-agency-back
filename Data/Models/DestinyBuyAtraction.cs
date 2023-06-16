using System;
using System.Collections.Generic;

namespace travel_agency_back.Data.Models
{
    public partial class DestinyBuyAtraction
    {
        public int Id { get; set; }
        public decimal Cost { get; set; }
        public DateTime Date { get; set; }
        public int IdActraction { get; set; }
        public int IdDestinyBuy { get; set; }

        public virtual Atraction IdActractionNavigation { get; set; } = null!;
        public virtual DestinyBuy IdDestinyBuyNavigation { get; set; } = null!;
    }
}
