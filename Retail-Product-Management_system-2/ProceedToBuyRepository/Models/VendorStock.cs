using System;
using System.Collections.Generic;

#nullable disable

namespace ProceedToBuyRepository.Models
{
    public partial class VendorStock
    {
        public string VendorId { get; set; }
        public string ProductId { get; set; }
        public int? StockInHand { get; set; }
    }
}
