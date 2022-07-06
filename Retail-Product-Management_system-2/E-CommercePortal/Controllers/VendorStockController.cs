using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VendorRepository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using System.Net.Http.Headers;

namespace E_CommercePortal.Controllers
{
    [Authorize(Roles ="Administrator")]
    public class VendorStockController : Controller
    {
        HttpClient client;
        public VendorStockController()
        {
            client = new HttpClient();
            client.BaseAddress=new Uri("http://localhost:9000/VendorStockSvc/");
        }

      

        // GET: VendorStockController
        public async Task<ActionResult> Index()
        {
            string userName = User.Identity.Name;
            string roleName = User.Claims.ToArray()[4].Value;
            string token = await client.GetStringAsync("http://localhost:9000/AuthSvc/?userName=" + userName + "&role=" + roleName + "&key=My name is James Bond");
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            List<VendorStock> venStocks = await client.GetFromJsonAsync<List<VendorStock>>("");
            return View(venStocks);
        }

        [Route("GetVendorStocksByProductId/{proId}")]
        public async Task<ActionResult> DetailsByProductId(string proId)
        {
            string userName = User.Identity.Name;
            string roleName = User.Claims.ToArray()[4].Value;
            string token = await client.GetStringAsync("http://localhost:9000/AuthSvc/?userName=" + userName + "&role=" + roleName + "&key=My name is James Bond");
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            List<VendorStock> venStocks = await client.GetFromJsonAsync<List<VendorStock>>("GetVendorStocksByProductId/"+proId);
            return View(venStocks);
        }

        [Route("GetVendorStocksByVendorId/{venId}")]
        public async Task<ActionResult> DetailsByVendorId(string venId)
        {
            string userName = User.Identity.Name;
            string roleName = User.Claims.ToArray()[4].Value;
            string token = await client.GetStringAsync("http://localhost:9000/AuthSvc/?userName=" + userName + "&role=" + roleName + "&key=My name is James Bond");
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            List<VendorStock> venStocks = await client.GetFromJsonAsync<List<VendorStock>>("GetVendorStocks/" + venId);
            return View(venStocks);
        }

        // GET: VendorStockController/Details/5
        [Route("getVendorStockOfProduct/{venId}/{proId}")]
        public async Task<ActionResult> Details(string venId,string proId)
        {
            string userName = User.Identity.Name;
            string roleName = User.Claims.ToArray()[4].Value;
            string token = await client.GetStringAsync("http://localhost:9000/AuthSvc/?userName=" + userName + "&role=" + roleName + "&key=My name is James Bond");
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            VendorStock venStock = await client.GetFromJsonAsync<VendorStock>("getVendorStockOfProduct/" + venId + "/" + proId);
            return View(venStock);
        }

        // GET: VendorStockController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: VendorStockController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        
        public async Task<ActionResult> Create(VendorStock venStock)
        {
            string userName = User.Identity.Name;
            string roleName = User.Claims.ToArray()[4].Value;
            string token = await client.GetStringAsync("http://localhost:9000/AuthSvc/?userName=" + userName + "&role=" + roleName + "&key=My name is James Bond");
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            
                await client.PostAsJsonAsync<VendorStock>("InsertVendorStock", venStock);
                return RedirectToAction(nameof(Index));
            
        }

       

        // GET: VendorStockController/Delete/5
        [Route("DeleteVendorStocks/{venId}/{proId}")]
        public async Task<ActionResult> Delete(string venId,string proId)
        {
            string userName = User.Identity.Name;
            string roleName = User.Claims.ToArray()[4].Value;
            string token = await client.GetStringAsync("http://localhost:9000/AuthSvc/?userName=" + userName + "&role=" + roleName + "&key=My name is James Bond");
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            VendorStock venStock = await client.GetFromJsonAsync<VendorStock>("getVendorStockOfProduct/" + venId + "/" + proId);
            return View(venStock);
        }

        // POST: VendorStockController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("DeleteVendorStocks/{venId}/{proId}")]
        public async Task<ActionResult> Delete(string venId,string proId, IFormCollection collection)
        {
            string userName = User.Identity.Name;
            string roleName = User.Claims.ToArray()[4].Value;
            string token = await client.GetStringAsync("http://localhost:9000/AuthSvc/?userName=" + userName + "&role=" + roleName + "&key=My name is James Bond");
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            
                await client.DeleteAsync("DeleteVendorStock/" + venId + "/" + proId);
                return RedirectToAction(nameof(Index));
            
        }
    }
}
