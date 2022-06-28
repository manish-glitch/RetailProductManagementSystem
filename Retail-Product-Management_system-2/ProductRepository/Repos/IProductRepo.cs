using ProductRepository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductRepository.Repos
{
    public interface IProductRepo
    {
        Task<List<Product>> GetAllProducts();
        Task<Product> GetProductById(string proId);
        Task<Product> GetProductByName(string proName);
        Task InsertProduct(Product product);
        Task UpdateProduct(string proId, Product product);
        Task DeleteProduct(string proId);
    }
}
