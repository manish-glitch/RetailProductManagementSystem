using ProceedToBuyRepository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProceedToBuyRepository.Repos
{
    public interface IWishlistRepo
    {
        Task<List<WishList>> GetAllWishlist();
        Task<List<WishList>> GetWishlistsByCustomerId(string custId);
        Task<List<WishList>> GetWishListsByProductId(string proId);
        Task<WishList> GetWishListByCustomerIdAndProductId(string custId, string proId);
        Task AddToWishlist(WishList wishList);
        Task DeleteWishList(string custId, string proId);
        //getall
        //getBycustomerId
        //getbyProductId
        //getonebycusIdProdId
    }
}
