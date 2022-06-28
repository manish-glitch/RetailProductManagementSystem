using System;
using System.Collections.Generic;

#nullable disable

namespace ProductRepository.Models
{
    public partial class ProductRating
    {
        public string ProductId { get; set; }
        public int? Rating { get; set; }

        public virtual Product Product { get; set; }
    }
}
