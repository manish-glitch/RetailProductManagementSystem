using System;
using System.Collections.Generic;

#nullable disable

namespace ProceedToBuyRepository.Models
{
    public partial class Customer
    {
        public Customer()
        {
            Carts = new HashSet<Cart>();
            WishLists = new HashSet<WishList>();
        }

        public string CustomerId { get; set; }
        public string CustomerName { get; set; }

        public virtual ICollection<Cart> Carts { get; set; }
        public virtual ICollection<WishList> WishLists { get; set; }
    }
}
