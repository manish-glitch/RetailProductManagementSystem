using System;
using System.Collections.Generic;

#nullable disable

namespace VendorRepository.Models
{
    public partial class Product
    {
        public Product()
        {
            VendorStocks = new HashSet<VendorStock>();
        }

        public string ProductId { get; set; }
        public string ProductName { get; set; }

        public virtual ICollection<VendorStock> VendorStocks { get; set; }
    }
}
