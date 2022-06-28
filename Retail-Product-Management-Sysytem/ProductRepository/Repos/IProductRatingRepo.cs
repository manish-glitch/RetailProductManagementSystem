﻿using ProductRepository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductRepository.Repos
{
    public interface IProductRatingRepo
    {
        Task<List<ProductRating>> GetAllRatingsOfProduct(string proId);
       
        Task<bool> AddProductRating(ProductRating rating);
    }
}