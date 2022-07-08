using ProductRepository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductRepository.Repos
{
    public interface IProductRatingRepo
    {
        //GetRatingBYCustomerId
        //GetRatingByPProductId
        Task<List<ProductRating>> GetAllRatings();
        Task<List<ProductRating>> GetAllRatingsOfProduct(string proId);
       
        Task AddProductRating(ProductRating rating);
    }
}
