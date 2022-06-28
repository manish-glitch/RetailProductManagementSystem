using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendorRepository.Models;

namespace VendorRepository.Repos
{
    public interface IVendorRepo 
    {
        Task<List<Vendor>> GetAllVendors();
        Task<Vendor> GetVendorDetailById(string venId);
        Task InsertVendor(Vendor ven);
        Task<VendorStock> GetVendorStockOfAProduct(string venId, string proId);
        Task<List<VendorStock>> GetVendorStocks(string venId);
        Task InsertvendorStock(VendorStock venStock);
        Task DeleteVendor(string venId);
        Task DeletevendorStock(string venId,string proId);

        
    }
}
