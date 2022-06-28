using Microsoft.EntityFrameworkCore;
using ProductRepository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductRepository.Repos
{
    public class ProductRepo : IProductRepo
    {
        ProductDBContext ctx = new ProductDBContext();
        public async Task DeleteProduct(string proId)
        {
            Product pro2del = await GetProductById(proId);
            ctx.Products.Remove(pro2del);
            await ctx.SaveChangesAsync();
        }

        public async Task<List<Product>> GetAllProducts()
        {
            List<Product> products = await ctx.Products.ToListAsync();
            return products;
        }

        public async Task<Product> GetProductById(string proId)
        {
            try
            {
                Product product = await (from p in ctx.Products where p.ProductId == proId select p).FirstAsync();
                return product;
            }
            catch (Exception)
            {
                throw new Exception($"No such product with productId {proId}");
            }
        }

        public async Task<Product> GetProductByName(string proName)
        {
            try
            {
                Product product = await (from p in ctx.Products where p.ProductName == proName select p).FirstAsync();
                return product;
            }
            catch (Exception)
            {
                throw new Exception($"No such product named {proName}!");
            }
        }

        public async Task InsertProduct(Product product)
        {
            await ctx.Products.AddAsync(product);
            await ctx.SaveChangesAsync();
        }

        public async Task UpdateProduct(string proId, Product product)
        {
            Product pro2edit = await GetProductById(proId);
            pro2edit.ProductName = product.ProductName;
            pro2edit.ProductDescription = product.ProductDescription;
            pro2edit.Image_name = product.Image_name;
            pro2edit.Price = product.Price;
            await ctx.SaveChangesAsync();
        }
    }
}
