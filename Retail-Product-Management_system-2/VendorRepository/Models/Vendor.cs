using System;
using System.Collections.Generic;

#nullable disable

namespace VendorRepository.Models
{
    public partial class Vendor
    {
        public Vendor()
        {
            VendorStocks = new HashSet<VendorStock>();
        }

        public string VendorId { get; set; }
        public string VendorName { get; set; }
        public decimal? DeliveryCharges { get; set; }
        public int? Rating { get; set; }

        public virtual ICollection<VendorStock> VendorStocks { get; set; }
    }
}
