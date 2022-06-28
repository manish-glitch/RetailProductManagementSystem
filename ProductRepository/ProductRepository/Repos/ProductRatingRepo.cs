using Microsoft.EntityFrameworkCore;
using ProductRepository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductRepository.Repos
{
    public class ProductRatingRepo : IProductRatingRepo
    {
        ProductDBContext ctx = new ProductDBContext();
        public async Task<bool> AddProductRating(ProductRating rating)
        {
            ProductRating pRating = await (from pr in ctx.ProductRatings where pr.ProductId == rating.ProductId select pr).FirstAsync();
            pRating.Rating = rating.Rating;
            return true;
        }

        
    }
}
