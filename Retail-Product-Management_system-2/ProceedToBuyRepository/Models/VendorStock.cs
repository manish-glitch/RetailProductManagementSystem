using System;
using System.Collections.Generic;

#nullable disable

namespace ProceedToBuyRepository.Models
{
    public partial class VendorStock
    {
        public VendorStock()
        {
            Carts = new HashSet<Cart>();
            WishLists = new HashSet<WishList>();
        }

        public string VendorId { get; set; }
        public string ProductId { get; set; }
        public int? StockInHand { get; set; }

        public virtual ICollection<Cart> Carts { get; set; }
        public virtual ICollection<WishList> WishLists { get; set; }
    }
}
