using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductRepository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
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

        public async Task<ActionResult> Index()
        {
            string userName = User.Identity.Name;
            string roleName = User.Claims.ToArray()[4].Value;
            string token = await client.GetStringAsync("http://localhost:9000/AuthSvc/?userName=" + userName + "&role=" + roleName + "&key=My name is James Bond");
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            List<ProductRating> ratings = await client.GetFromJsonAsync<List<ProductRating>>("");
            return View(ratings);
        }

        // GET: ProductRatingController
        [Route("RatingsOfProduct/{proId}")]
        public async Task<ActionResult> RatingsOfProduct(string proId)
        {
            string userName = User.Identity.Name;
            string roleName = User.Claims.ToArray()[4].Value;
            string token = await client.GetStringAsync("http://localhost:9000/AuthSvc/?userName=" + userName + "&role=" + roleName + "&key=My name is James Bond");
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            List<ProductRating> pRatings = await client.GetFromJsonAsync<List<ProductRating>>("RatingsOfProduct/"+proId);
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
        
        public async Task<ActionResult> AddProductRating(ProductRating proRating)
        {
            string userName = User.Identity.Name;
            string roleName = User.Claims.ToArray()[4].Value;
            string token = await client.GetStringAsync("http://localhost:9000/AuthSvc/?userName=" + userName + "&role=" + roleName + "&key=My name is James Bond");
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            await client.PostAsJsonAsync<ProductRating>("", proRating);
            return RedirectToAction(nameof(Index));
           
        }
    }
}
