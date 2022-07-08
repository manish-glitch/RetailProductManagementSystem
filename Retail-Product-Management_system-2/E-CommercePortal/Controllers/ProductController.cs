using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Json;
using ProductRepository.Models;
using ProductRepository.Repos;
using Microsoft.AspNetCore.Authorization;
using System.Net.Http.Headers;

namespace E_CommercePortal.Controllers
{
    [Authorize]
    public class ProductController : Controller
    {
        //public IProductRepo proRepo;
        HttpClient client;
        public ProductController()
        {
            //proRepo = pRepo;
            client = new HttpClient();
            client.BaseAddress= new Uri("http://localhost:9000/ProductSvc/");
        }

        public async Task<IActionResult> GetById()
        {
            string userName = User.Identity.Name;
            string roleName = User.Claims.ToArray()[4].Value;
            string token = await client.GetStringAsync("http://localhost:9000/AuthSvc/?userName=" + userName + "&role=" + roleName + "&key=My name is James Bond");
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            return View();
        }

        public async Task<IActionResult> GetByName()
        {
            string userName = User.Identity.Name;
            string roleName = User.Claims.ToArray()[4].Value;
            string token = await client.GetStringAsync("http://localhost:9000/AuthSvc/?userName=" + userName + "&role=" + roleName + "&key=My name is James Bond");
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            return View();
        }


        // GET: ProductController
        [Route("GetAllProducts")]
        public async Task<ActionResult> Index()
        {
            string userName = User.Identity.Name;
            string roleName = User.Claims.ToArray()[4].Value;
            string token = await client.GetStringAsync("http://localhost:9000/AuthSvc/?userName="+userName+"&role="+roleName+"&key=My name is James Bond");
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            List<Product> products = await client.GetFromJsonAsync<List<Product>>("");
            return View(products);
        }

        // GET: ProductController/Details/5
       
        public async Task<ActionResult<Product>> Details(string proId)
        {
            string userName = User.Identity.Name;
            string roleName = User.Claims.ToArray()[4].Value;
            string token = await client.GetStringAsync("http://localhost:9000/AuthSvc/?userName=" + userName + "&role=" + roleName + "&key=My name is James Bond");
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            Product pro = await client.GetFromJsonAsync<Product>("GetProductById/"+ proId);
            return View(pro);
        }

        //Get: ProductController/Details/proName
        //[Route("DetailsByName/{proName}")]
        public async Task<ActionResult<Product>> DetailsByName(string proName)
        {
            string userName = User.Identity.Name;
            string roleName = User.Claims.ToArray()[4].Value;
            string token = await client.GetStringAsync("http://localhost:9000/AuthSvc/?userName=" + userName + "&role=" + roleName + "&key=My name is James Bond");
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            Product pro = await client.GetFromJsonAsync<Product>("GetProductByName/" + proName);
            return View(pro);
        }

        // GET: ProductController/Create
        [Authorize(Roles ="Administrator")]
        public ActionResult Create()
        {

            return View();
        }

        // POST: ProductController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles ="Administrator")]
        public async Task<ActionResult> Create(Product pro)
        {
            string userName = User.Identity.Name;
            string roleName = User.Claims.ToArray()[4].Value;
            string token = await client.GetStringAsync("http://localhost:9000/AuthSvc/?userName=" + userName + "&role=" + roleName + "&key=My name is James Bond");
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            
                await client.PostAsJsonAsync<Product>("", pro);
                return RedirectToAction(nameof(Index));
            
        }

        // GET: ProductController/Edit/5
        [Route("Edit/{proId}")]
        [Authorize(Roles ="Administrator")]
        public async Task<ActionResult> Edit(string proId)
        {
            string userName = User.Identity.Name;
            string roleName = User.Claims.ToArray()[4].Value;
            string token = await client.GetStringAsync("http://localhost:9000/AuthSvc/?userName=" + userName + "&role=" + roleName + "&key=My name is James Bond");
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            Product pro = await client.GetFromJsonAsync<Product>("GetProductById/" + proId);
            return View(pro);
        }

        // POST: ProductController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("Edit/{proId}")]
        [Authorize(Roles = "Administrator")]
        public async Task<ActionResult> Edit(string proId, Product pro)
        {
            string userName = User.Identity.Name;
            string roleName = User.Claims.ToArray()[4].Value;
            string token = await client.GetStringAsync("http://localhost:9000/AuthSvc/?userName=" + userName + "&role=" + roleName + "&key=My name is James Bond");
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            
                await client.PutAsJsonAsync<Product>(""+proId, pro);
                return RedirectToAction(nameof(Index));
            
        }

        // GET: ProductController/Delete/5
        [Route("Delete/{proId}")]
        [Authorize(Roles = "Administrator")]
        public async Task<ActionResult> Delete(string proId)
        {
            string userName = User.Identity.Name;
            string roleName = User.Claims.ToArray()[4].Value;
            string token = await client.GetStringAsync("http://localhost:9000/AuthSvc/?userName=" + userName + "&role=" + roleName + "&key=My name is James Bond");
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            Product pro = await client.GetFromJsonAsync<Product>("GetProductById/" + proId);
            return View(pro);
        }

        // POST: ProductController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("Delete/{proId}")]
        [Authorize(Roles = "Administrator")]
        public async Task<ActionResult> Delete(string proId,IFormCollection collection)
        {
            string userName = User.Identity.Name;
            string roleName = User.Claims.ToArray()[4].Value;
            string token = await client.GetStringAsync("http://localhost:9000/AuthSvc/?userName=" + userName + "&role=" + roleName + "&key=My name is James Bond");
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            
                await client.DeleteAsync(proId);
                return RedirectToAction(nameof(Index));
            
        }
    }
}
