using System;
using System.Collections.Generic;

#nullable disable

namespace ProceedToBuyRepository.Models
{
    public partial class Cart
    {
        public string CartId { get; set; }
        public string ProductId { get; set; }
        public string CustomerId { get; set; }
        public string VendorId { get; set; }
        public string Zipcode { get; set; }
        public DateTime? DeliveryDate { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Product Product { get; set; }
        public virtual Vendor Vendor { get; set; }
    }
}
