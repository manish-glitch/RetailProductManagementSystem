using Microsoft.AspNetCore.Authorization;
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
    [Authorize]
    public class ProductRatingController : ControllerBase
    {
        IProductRatingRepo pRatingRepo;
        public ProductRatingController(IProductRatingRepo prRepo)
        {
            pRatingRepo = prRepo;
        }
        [HttpGet]
        public async Task<ActionResult<List<ProductRating>>> GetAllRatings()
        {
            List<ProductRating> pRatings = await pRatingRepo.GetAllRatings();
            return Ok(pRatings);
        }
        [HttpGet("RatingsOfProduct/{proId}")]
        public async Task<ActionResult<List<ProductRating>>> GetAll(string proId)
        {
            List<ProductRating> pratings = await pRatingRepo.GetAllRatingsOfProduct(proId);
            return Ok(pratings);
        }
        [HttpPost]
        public async Task<ActionResult> AddProductRating(ProductRating prodRating)
        {
            await pRatingRepo.AddProductRating(prodRating);
            return Created($"api/ProductRating/{prodRating.RatingId}",prodRating);
        }
    }
}
