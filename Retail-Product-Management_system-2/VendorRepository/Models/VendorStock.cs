using System;
using System.Collections.Generic;

#nullable disable

namespace VendorRepository.Models
{
    public partial class VendorStock
    {
        public string ProductId { get; set; }
        public string VendorId { get; set; }
        public int? StockInHand { get; set; }
        public DateTime? StockReplenishmentDate { get; set; }

        public virtual Product Product { get; set; }
        public virtual Vendor Vendor { get; set; }
    }
}
