using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Threading.Tasks;
using VendorRepository.Models;

namespace E_CommercePortal.Controllers
{
    [Authorize(Roles ="Administrator")]
    public class VendorController : Controller
    {
        // GET: VendorController
        HttpClient client;
        public VendorController()
        {
            client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:9000/VendorSvc/");
        }
        public async Task<ActionResult> Index()
        {
            string userName = User.Identity.Name;
            string roleName = User.Claims.ToArray()[4].Value;
            string token = await client.GetStringAsync("http://localhost:9000/AuthSvc/?userName=" + userName + "&role=" + roleName + "&key=My name is James Bond");
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            List<Vendor> vendors = await client.GetFromJsonAsync<List<Vendor>>("GetAllVendors/");
            return View(vendors);
        }

        // GET: VendorController/Details/5
        public async Task<ActionResult> DetailsById(string venId)
        {
            string userName = User.Identity.Name;
            string roleName = User.Claims.ToArray()[4].Value;
            string token = await client.GetStringAsync("http://localhost:9000/AuthSvc/?userName=" + userName + "&role=" + roleName + "&key=My name is James Bond");
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            Vendor ven = await client.GetFromJsonAsync<Vendor>("GetVendorDetailById/" + venId);
            return View(ven);
        }

        // GET: VendorController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: VendorController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(Vendor ven)
        {
            string userName = User.Identity.Name;
            string roleName = User.Claims.ToArray()[4].Value;
            string token = await client.GetStringAsync("http://localhost:9000/AuthSvc/?userName=" + userName + "&role=" + roleName + "&key=My name is James Bond");
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            
                await client.PostAsJsonAsync<Vendor>("InsertVendor/", ven);
                return RedirectToAction(nameof(Index));
           
        }

        

        // GET: VendorController/Delete/5
        [Route("DeleteVendor/{venId}")]
        public async Task<ActionResult> DeleteVendor(string venId)
        {
            string userName = User.Identity.Name;
            string roleName = User.Claims.ToArray()[4].Value;
            string token = await client.GetStringAsync("http://localhost:9000/AuthSvc/?userName=" + userName + "&role=" + roleName + "&key=My name is James Bond");
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            Vendor ven = await client.GetFromJsonAsync<Vendor>("GetVendorDetailById/" + venId);
            return View(ven);
        }

        // POST: VendorController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("DeleteVendor/{venId}")]
        public async Task<ActionResult> DeleteVendor(string venId, IFormCollection collection)
        {
            string userName = User.Identity.Name;
            string roleName = User.Claims.ToArray()[4].Value;
            string token = await client.GetStringAsync("http://localhost:9000/AuthSvc/?userName=" + userName + "&role=" + roleName + "&key=My name is James Bond");
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            
                await client.DeleteAsync("DeleteVendor/"+venId);
                return RedirectToAction(nameof(Index));
           
        }
    }
}
