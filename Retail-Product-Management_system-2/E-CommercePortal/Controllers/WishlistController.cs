using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProceedToBuyRepository.Models;
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
    public class WishlistController : Controller
    {
        HttpClient client;
        public WishlistController()
        {
            client = new HttpClient();
            client.BaseAddress=new Uri("http://localhost:9000/WishlistSvc/");
        }
        // GET: WishlistController
        [Route("GetAllWishlist")]
        public async Task<ActionResult> Index()
        {
            string userName = User.Identity.Name;
            string roleName = User.Claims.ToArray()[4].Value;
            string token = await client.GetStringAsync("http://localhost:9000/AuthSvc/?userName=" + userName + "&role=" + roleName + "&key=My name is James Bond");
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            List<WishList> wLists = await client.GetFromJsonAsync<List<WishList>>("");
            return View(wLists);
        }

        //GET:Wishlist/GetWishlistsByProductId
        [Route("GetWishlistsByProductId/{proId}")]
        public async Task<ActionResult> GetWishlistByProductId(string proId)
        {
            string userName = User.Identity.Name;
            string roleName = User.Claims.ToArray()[4].Value;
            string token = await client.GetStringAsync("http://localhost:9000/AuthSvc/?userName=" + userName + "&role=" + roleName + "&key=My name is James Bond");
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            List<WishList> wLists = await client.GetFromJsonAsync<List<WishList>>("GetWishlistsByProductId/"+proId);
            return View(wLists);
        }
        //GET:Wishlist/GetWishlistsByCustomerId
        [Route("GetWishlistsByCustomerId/{custId}")]
        public async Task<ActionResult> GetWishlistByCustomerId(string custId)
        {
            string userName = User.Identity.Name;
            string roleName = User.Claims.ToArray()[4].Value;
            string token = await client.GetStringAsync("http://localhost:9000/AuthSvc/?userName=" + userName + "&role=" + roleName + "&key=My name is James Bond");
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            List<WishList> wLists = await client.GetFromJsonAsync<List<WishList>>("GetWishListsByCustomerId/" + custId);
            return View(wLists);
        }

        // GET: WishlistController/Details/5
        [Route("WishlistDetails/{custId}/{proId}")]
        public async Task<ActionResult> WishlistDetails(string custId,string proId)
        {
            string userName = User.Identity.Name;
            string roleName = User.Claims.ToArray()[4].Value;
            string token = await client.GetStringAsync("http://localhost:9000/AuthSvc/?userName=" + userName + "&role=" + roleName + "&key=My name is James Bond");
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            WishList wList = await client.GetFromJsonAsync<WishList>("GetWishListByCustomerIdAndProductId/" + custId + "/" + proId);
            return View(wList);
        }

        // GET: WishlistController/Create
        public ActionResult AddToWishlist()
        {
            
            return View();
        }

        // POST: WishlistController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> AddToWishlist(WishList wList)
        {
            string userName = User.Identity.Name;
            string roleName = User.Claims.ToArray()[4].Value;
            string token = await client.GetStringAsync("http://localhost:9000/AuthSvc/?userName=" + userName + "&role=" + roleName + "&key=My name is James Bond");
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
           
                await client.PostAsJsonAsync<WishList>("", wList);
                return RedirectToAction(nameof(Index));
            
        }

        
        
        
    }
}
