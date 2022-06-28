using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
    }
}
