using Microsoft.EntityFrameworkCore;
using ProceedToBuyRepository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProceedToBuyRepository.Repos
{
    public class CartRepo : ICartRepo
    {
        ProceedToBuyDBContext ctx = new ProceedToBuyDBContext();
        public async Task AddToCart(Cart cart)
        {
            await ctx.Carts.AddAsync(cart);
            await ctx.SaveChangesAsync();
        }

        public async Task DeleteCart(string custId, string proId)
        {
            Cart cart2del = await GetCartByCustIdAndProId(custId, proId);
            ctx.Carts.Remove(cart2del);
            await ctx.SaveChangesAsync();
        }

        public async Task<List<Cart>> GetAllCarts()
        {
            List<Cart> carts = await ctx.Carts.ToListAsync();
            return carts;
        }

        public async Task<Cart> GetCartByCustIdAndProId(string custId, string proId)
        {
            try
            {
                Cart cart = await (from c in ctx.Carts where c.CustomerId == custId && c.ProductId == proId select c).FirstAsync();
                return cart;
            }
            catch (Exception)
            {
                throw new Exception($"no cart of customer {custId} for {proId} product");
            }
        }

        public async Task<List<Cart>> GetCartsByCustomerId(string custId)
        {
            List<Cart> carts = await (from c in ctx.Carts where c.CustomerId == custId select c).ToListAsync();
            if (carts.Count != 0)
            {
                return carts;
            }
            else
            {
                throw new Exception("no cart/product in cart for this customer ");
            }
        }

        public async Task<List<Cart>> GetCartsByproductId(string proId)
        {
            List<Cart> carts = await (from c in ctx.Carts where c.ProductId == proId select c).ToListAsync();
            if (carts.Count != 0)
            {
                return carts;
            }
            else
            {
                throw new Exception("no carts for this product (no one put this product in cart) ");
            }
        }

        public async Task<VendorStock> getVendorStockOfProduct(string venId, string proId)
        {
            try
            {
                VendorStock venStock = await (from vs in ctx.VendorStocks where vs.VendorId == venId && vs.ProductId == proId select vs).FirstAsync();
                return venStock;
            }
            catch (Exception)
            {
                throw new Exception("not available!");
            }
        }
    }
}
