using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendorRepository.Models;

namespace VendorRepository.Repos
{
    public class VendorRepo : IVendorRepo
    {
        VendorDBContext ctx = new VendorDBContext();
        public async Task DeleteVendor(string venId)
        {
            Vendor ven2del = await GetVendorDetailById(venId);
            ctx.Vendors.Remove(ven2del);
            await ctx.SaveChangesAsync();
        }

        public async Task DeletevendorStock(string venId,string proId)
        {
            VendorStock venStock2del = await GetVendorStockOfAProduct(venId, proId);
            ctx.VendorStocks.Remove(venStock2del);
            await ctx.SaveChangesAsync();
        }

        public async Task<List<Vendor>> GetAllVendors()
        {
            List<Vendor> vendors = await ctx.Vendors.ToListAsync();
            return (vendors);
        }

        public async Task<Vendor> GetVendorDetailById(string venId)
        {
            try
            {
                Vendor ven = await (from v in ctx.Vendors where v.VendorId == venId select v).FirstAsync();
                return ven;
            }
            catch (Exception)
            {
                throw new Exception("no vendor with this Id");
            }

        }

        public async Task<VendorStock> GetVendorStockOfAProduct(string venId, string proId)
        {
            try
            {
                VendorStock venStock = await(from v in ctx.VendorStocks where v.VendorId == venId && v.ProductId==proId select v).FirstAsync();
                return venStock;
            }
            catch (Exception)
            {
                throw new Exception("this vendor does not have this product in stock");
            }
        }

        public async Task<List<VendorStock>> GetVendorStocks(string venId)
        {
            List<VendorStock> venStocks = await (from vs in ctx.VendorStocks where vs.VendorId == venId select vs).ToListAsync();
            if (venStocks.Count != 0)
            {
                return venStocks;
            }
            else
            {
                throw new Exception("no stocks found for this vendor");
            }
        }

        public async Task InsertVendor(Vendor ven)
        {
            await ctx.Vendors.AddAsync(ven);
            await ctx.SaveChangesAsync();
        }

        public async Task InsertvendorStock(VendorStock venStock)
        {
            await ctx.VendorStocks.AddAsync(venStock);
            await ctx.SaveChangesAsync();
        }
    }
}
