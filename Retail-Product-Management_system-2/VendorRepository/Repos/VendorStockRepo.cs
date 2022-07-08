using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendorRepository.Models;

namespace VendorRepository.Repos
{
    public class VendorStockRepo : IVendorStockRepo
    {
        VendorDBContext ctx = new VendorDBContext();
        public async Task DeletevendorStock(string venId, string proId)//no need to have delete
        {
            VendorStock venStock2del = await GetVendorStockOfAProduct(venId, proId);
            ctx.VendorStocks.Remove(venStock2del);
            await ctx.SaveChangesAsync();
        }
        public async Task<List<VendorStock>> GetAllVendorStocks()
        {
            List<VendorStock> venStocks = await ctx.VendorStocks.ToListAsync();
            return venStocks;
        }
        public async Task<VendorStock> GetVendorStockOfAProduct(string venId, string proId)
        {
            try
            {
                VendorStock venStock = await (from v in ctx.VendorStocks where v.VendorId == venId && v.ProductId == proId select v).FirstAsync();
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

        public async Task<List<VendorStock>> GetVendorStocksByProductId(string proId)
        {
            List<VendorStock> venStocks = await (from vs in ctx.VendorStocks where vs.ProductId == proId &&vs.StockInHand!=0 select vs).ToListAsync();
            if (venStocks.Count != 0)
            {
                return venStocks;
            }
            else
            {
                throw new Exception("No such product in any stocks");
            }
        }

        public async Task InsertvendorStock(VendorStock venStock)
        {
            await ctx.VendorStocks.AddAsync(venStock);
            await ctx.SaveChangesAsync();
        }
    }
}
