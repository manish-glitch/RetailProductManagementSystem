﻿using System;
using System.Collections.Generic;

#nullable disable

namespace ProductRepository.Models
{
    public partial class Product
    {
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public decimal? Price { get; set; }
        public int? Rating { get; set; }
    }
}
