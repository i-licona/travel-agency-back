using System;
using System.Collections.Generic;

namespace travel_agency_back.Data.Models
{
    public partial class DestinyBuy
    {
        public DestinyBuy()
        {
            DestinyBuyAtractions = new HashSet<DestinyBuyAtraction>();
            DestinyBuyHotels = new HashSet<DestinyBuyHotel>();
        }

        public int Id { get; set; }
        public int IdDestiny { get; set; }
        public int IdCustomer { get; set; }
        public decimal TotalCost { get; set; }
        public DateTime Date { get; set; }

        public virtual Customer IdCustomerNavigation { get; set; } = null!;
        public virtual Destiny IdDestinyNavigation { get; set; } = null!;
        public virtual ICollection<DestinyBuyAtraction> DestinyBuyAtractions { get; set; }
        public virtual ICollection<DestinyBuyHotel> DestinyBuyHotels { get; set; }
    }
}
