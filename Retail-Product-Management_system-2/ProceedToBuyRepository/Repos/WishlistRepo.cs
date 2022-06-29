using Microsoft.EntityFrameworkCore;
using ProceedToBuyRepository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProceedToBuyRepository.Repos
{
    public class WishlistRepo : IWishlistRepo
    {
        ProceedToBuyDBContext ctx = new ProceedToBuyDBContext();
        public async Task AddToWishlist(WishList wishList)
        {
            await ctx.WishLists.AddAsync(wishList);
            await ctx.SaveChangesAsync();
        }

        public async Task DeleteWishList(string custId, string proId)
        {
            WishList wList2del = await GetWishListByCustomerIdAndProductId(custId, proId);
            ctx.WishLists.Remove(wList2del);
            await ctx.SaveChangesAsync();
        }

        public async Task<List<WishList>> GetAllWishlist()
        {
            List<WishList> wLists = await ctx.WishLists.ToListAsync();
            return wLists;
        }

        public async Task<WishList> GetWishListByCustomerIdAndProductId(string custId, string proId)
        {
            try
            {
                WishList wList = await(from w in ctx.WishLists where w.CustomerId == custId && w.ProductId == proId select w).FirstAsync();
                return wList;
            }
            catch (Exception)
            {
                throw new Exception("this customer have not added this product in wishlist");
            }
        }

        public async Task<List<WishList>> GetWishlistsByCustomerId(string custId)
        {
            List<WishList> wLists = await (from w in ctx.WishLists where w.CustomerId == custId select w).ToListAsync();
            if (wLists.Count != 0)
            {
                return wLists;
            }
            else
            {
                throw new Exception("this customer don't have wishlist");
            }

        }

        public async Task<List<WishList>> GetWishListsByProductId(string proId)
        {
            List<WishList> wLists = await (from w in ctx.WishLists where w.ProductId == proId select w).ToListAsync();
            if (wLists.Count != 0)
            {
                return wLists;
            }
            else
            {
                throw new Exception("No one have added this product in their wishlist");
            }
        }
    }
}
