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

        

        

        public async Task InsertVendor(Vendor ven)
        {
            await ctx.Vendors.AddAsync(ven);
            await ctx.SaveChangesAsync();
        }

        
    }
}
