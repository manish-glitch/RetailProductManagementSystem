using ProceedToBuyRepository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProceedToBuyRepository.Repos;
using VendorRepository.Repos;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace E_CommercePortal.Filters
{
    public class RepoHelper
    {
        
        public static async Task<List<SelectListItem>> GetAllVendors(string proId)
        {
            List<SelectListItem> vendorList = new List<SelectListItem>();
            
            CartRepo cartRepo = new CartRepo();
            List<VendorStock> vList = await cartRepo.GetVendorStockByProductId( proId);
            foreach(VendorStock vendorStock in vList)
            {
                vendorList.Add(new SelectListItem { Text = vendorStock.VendorId.ToString(),Value= vendorStock.VendorId.ToString() });
            }
            return vendorList;
        }
    }
}
