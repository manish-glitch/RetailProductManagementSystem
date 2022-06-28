using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductRepository.Models;
using ProductRepository.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    
    public class ProductRatingController : ControllerBase
    {
        IProductRatingRepo pRatingRepo;
        public ProductRatingController(IProductRatingRepo prRepo)
        {
            pRatingRepo = prRepo;
        }
        [HttpGet("{proId}")]
        public async Task<ActionResult<List<ProductRating>>> GetAll(string proId)
        {
            List<ProductRating> pratings = await pRatingRepo.GetAllRatingsOfProduct(proId);
            return Ok(pratings);
        }
        [HttpPost]
        public async Task<ActionResult<bool>> AddProductRating(ProductRating prodRating)
        {
            await pRatingRepo.AddProductRating(prodRating);
            return true;
        }
    }
}
