using System;
using System.Collections.Generic;

#nullable disable

namespace ProceedToBuyRepository.Models
{
    public partial class Product
    {
        public Product()
        {
            Carts = new HashSet<Cart>();
            WishLists = new HashSet<WishList>();
        }

        public string ProductId { get; set; }

        public virtual ICollection<Cart> Carts { get; set; }
        public virtual ICollection<WishList> WishLists { get; set; }
    }
}
