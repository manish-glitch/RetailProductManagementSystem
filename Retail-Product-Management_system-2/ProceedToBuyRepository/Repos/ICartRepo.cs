using ProceedToBuyRepository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProceedToBuyRepository.Repos
{
    public interface ICartRepo
    {
        Task<VendorStock> getVendorStockOfProduct(string venId, string proId);
        Task<List<Cart>> GetAllCarts();
        Task<List<Cart>> GetCartsByCustomerId(string custId);
        Task<List<Cart>> GetCartsByproductId(string proId);//admin only()
        Task<Cart> GetCartByCustIdAndProId(string custId, string proId);
        Task AddToCart(Cart cart);
        Task DeleteCart(string custId, string proId);
        //getall
        //getBycustomerId
        //getbyProductId
        //getonebycusIdProdId
        
    }
}
