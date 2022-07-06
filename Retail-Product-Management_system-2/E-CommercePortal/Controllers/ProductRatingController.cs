using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductRepository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace E_CommercePortal.Controllers
{
    [Authorize]
    public class ProductRatingController : Controller
    {
        HttpClient client;
        public ProductRatingController()
        {
            client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:9000/ProductRatingSvc/");
        }
        // GET: ProductRatingController
        [Route("ProductRating/{proId}")]
        public async Task<ActionResult> IndexOfRating(string proId)
        {
            List<ProductRating> pRatings = await client.GetFromJsonAsync<List<ProductRating>>(""+proId);
            return View(pRatings);
        }

       

        // GET: ProductRatingController/Create
        public ActionResult AddProductRating()
        {
            return View();
        }

        // POST: ProductRatingController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("ProductRating/AddProductRating")]
        public async Task<ActionResult> AddProductRating(ProductRating proRating)
        {
            try
            {
                await client.PostAsJsonAsync<ProductRating>("", proRating);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
