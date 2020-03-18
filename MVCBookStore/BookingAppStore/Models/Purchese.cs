using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookingAppStore.Models
{
    public class Purchese
    {
        public int PurcheseId { get; set; }
        public int Person { get; set; }
        public int Address { get; set; }
        public int BookId { get; set; }
        public DateTime Date { get; set; }
    }
}