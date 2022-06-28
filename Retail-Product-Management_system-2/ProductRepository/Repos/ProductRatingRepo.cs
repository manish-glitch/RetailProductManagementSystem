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
            await ctx.ProductRatings.AddAsync(rating);
            await ctx.SaveChangesAsync();
            return true;
        }

        public async Task<List<ProductRating>> GetAllRatingsOfProduct(string proId)
        {
            List<ProductRating> pRatings = await(from pr in ctx.ProductRatings where pr.ProductId == proId select pr).ToListAsync();
            return pRatings;
        }
    }
}
