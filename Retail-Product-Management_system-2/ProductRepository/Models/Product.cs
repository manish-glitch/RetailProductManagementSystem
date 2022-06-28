using System;
using System.Collections.Generic;

#nullable disable

namespace ProductRepository.Models
{
    public partial class Product
    {
        public Product()
        {
            ProductRatings = new HashSet<ProductRating>();
        }

        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public string Image_name { get; set; }
        public decimal? Price { get; set; }
        public int? Rating { get; set; }

        public virtual ICollection<ProductRating> ProductRatings { get; set; }
    }
}
