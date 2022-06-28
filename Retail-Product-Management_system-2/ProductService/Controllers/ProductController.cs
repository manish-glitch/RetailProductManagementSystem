using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductRepository.Models;
using ProductRepository.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        IProductRepo proRepo;
        
        public ProductController(IProductRepo pRepo)
        {
            proRepo = pRepo;
            
        }
        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetAllProducts()
        {
            List<Product> products = await proRepo.GetAllProducts();
            return Ok(products);
        }
        [HttpGet("GetProductById/{proId}")]
        public async Task<ActionResult<Product>> GetProductById(string proId)
        {
            try
            {
                Product product = await proRepo.GetProductById(proId);
                return Ok(product);
            }
            catch(Exception ex)
            {
                return NotFound(ex.Message);
            }
        }
        [HttpGet("GetProductByName/{proName}")]
        public async Task<ActionResult<Product>> GetProductByName(string proName)
        {
            try
            {
                Product product = await proRepo.GetProductByName(proName);
                return Ok(product);
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }
        [HttpPost]
        public async Task<ActionResult<Product>> Insert(Product product)
        {
            await proRepo.InsertProduct(product);
            return Created($"api/Product/{product.ProductId}", product);
        }
        [HttpPut("{proId}")]
        public async Task<ActionResult> Update(string proId,Product product)
        {
            await proRepo.UpdateProduct(proId, product);
            return Ok();
        }
        [HttpDelete("{proId}")]
        public async Task<ActionResult> Delete(string proId)
        {
            await proRepo.DeleteProduct(proId);
            return Ok();
        }
    }
}
