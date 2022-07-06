using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendorRepository.Models;

namespace VendorRepository.Repos
{
    public interface IVendorStockRepo
    {
        Task<List<VendorStock>> GetAllVendorStocks();
        Task<VendorStock> GetVendorStockOfAProduct(string venId, string proId);
        Task<List<VendorStock>> GetVendorStocks(string venId);
       
        Task<List<VendorStock>> GetVendorStocksByProductId(string proId);
        Task InsertvendorStock(VendorStock venStock);
        Task DeletevendorStock(string venId, string proId);
    }
}
