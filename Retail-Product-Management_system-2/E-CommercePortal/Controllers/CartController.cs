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
    public class CartController : Controller
    {
        HttpClient client;
        public CartController()
        {
            //proRepo = pRepo;
            client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:9000/CartSvc/");
        }
        // GET: CartController
        public async Task<ActionResult> Index()

        {
            string userName = User.Identity.Name;
            string roleName = User.Claims.ToArray()[4].Value;
            string token = await client.GetStringAsync("http://localhost:9000/AuthSvc/?userName=" + userName + "&role=" + roleName + "&key=My name is James Bond");
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            List<Cart> carts = await client.GetFromJsonAsync<List<Cart>>("");
            return View(carts);
        }

        // GET: CartController/Details/5
        [Route("GetCartByCustIdAndProId/{custId}/{proId}")]
        public async Task<ActionResult> Details(string custId,string proId)
        {
            string userName = User.Identity.Name;
            string roleName = User.Claims.ToArray()[4].Value;
            string token = await client.GetStringAsync("http://localhost:9000/AuthSvc/?userName=" + userName + "&role=" + roleName + "&key=My name is James Bond");
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            Cart cart = await client.GetFromJsonAsync<Cart>("GetCartByCustomerIdAndProductId/" + custId + "/" + proId);
            return View(cart);
        }
        // GET: CartController/Details/5
        [Route("GetCartsByProId/{proId}")]
        public async Task<ActionResult> GetCartsByProductId( string proId)
        {
            string userName = User.Identity.Name;
            string roleName = User.Claims.ToArray()[4].Value;
            string token = await client.GetStringAsync("http://localhost:9000/AuthSvc/?userName=" + userName + "&role=" + roleName + "&key=My name is James Bond");
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            List<Cart> carts = await client.GetFromJsonAsync<List<Cart>>("GetCartsByProductId/" + proId);
            return View(carts);
        }

        //[Route("GetVendorStock/{venId}/{proId}")]
        public async Task<VendorStock> GetVendorStock(string venId,string proId)
        {
            string userName = User.Identity.Name;
            string roleName = User.Claims.ToArray()[4].Value;
            string token = await client.GetStringAsync("http://localhost:9000/AuthSvc/?userName=" + userName + "&role=" + roleName + "&key=My name is James Bond");
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            try
            {
                VendorStock venStock = await client.GetFromJsonAsync<VendorStock>("getVendorStockOfProduct/" + venId + "/" + proId);
                return venStock;
            }
            catch (Exception)
            {
                throw new Exception("Product not available");
               
            }
        }


        // GET: CartController/Create
        public ActionResult AddToCart()
        {

            return View();
        }
        

        // POST: CartController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> AddToCart(Cart cart)
        {
            string userName = User.Identity.Name;
            string roleName = User.Claims.ToArray()[4].Value;
            string token = await client.GetStringAsync("http://localhost:9000/AuthSvc/?userName=" + userName + "&role=" + roleName + "&key=My name is James Bond");
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            VendorStock venStock =  await GetVendorStock(cart.VendorId, cart.ProductId);
                if (venStock.StockInHand != 0)
                {
                    await client.PostAsJsonAsync<Cart>("",cart);
                    
                    return View("CartSuccess");

                }
                else
                {
                //filter required
                    
                    return View("CartError");
                    
                }
                              
                
                
           
        }

        /*// POST: CartController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> AddToCart(Cart cart)
        {
            try
            {
                VendorStock venStock = await client.GetFromJsonAsync<VendorStock>("VendorStock/getVendorStockOfProduct/V001/P001");
                if (venStock.StockInHand != 0)
                {
                    await client.PostAsJsonAsync<Cart>("", cart);
                    return RedirectToAction(nameof(Index));

                }
                else
                {
                    throw new Exception("not in stock");
                }



            }
            catch
            {
                return View();
            }
        }*/



        // GET: CartController/Delete/5
        [Route("Delete/{custId}/{proId}")]
        public async Task<ActionResult> Delete(string custId,string proId)
        {
            string userName = User.Identity.Name;
            string roleName = User.Claims.ToArray()[4].Value;
            string token = await client.GetStringAsync("http://localhost:9000/AuthSvc/?userName=" + userName + "&role=" + roleName + "&key=My name is James Bond");
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            Cart cart = await client.GetFromJsonAsync<Cart>("GetCartByCustomerIdAndProductId/" + custId + "/" + proId);
            return View(cart);
            
        }

        // POST: CartController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("Delete/{custId}/{proId}")]
        public async Task<ActionResult> Delete(string custId,string proId, IFormCollection collection)
        {
            string userName = User.Identity.Name;
            string roleName = User.Claims.ToArray()[4].Value;
            string token = await client.GetStringAsync("http://localhost:9000/AuthSvc/?userName=" + userName + "&role=" + roleName + "&key=My name is James Bond");
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
           
                await client.DeleteAsync("DeleteCart/" + custId + "/" + proId);
                return RedirectToAction(nameof(Index));
           
        }
    }
}
