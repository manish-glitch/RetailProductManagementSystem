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
        Task DeleteVendor(string venId);
        

        
    }
}
