using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProceedToBuyRepository.Models;
using ProceedToBuyRepository.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProceedToBuyService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class CartController : ControllerBase
    {
        ICartRepo cRepo;
        public CartController(ICartRepo repo)
        {
            cRepo = repo;
        }

        [HttpGet]
        public async Task<ActionResult<List<Cart>>> GetAllCarts()
        {
            List<Cart> carts = await cRepo.GetAllCarts();
            return carts;
        }
        [HttpGet("GetCartsByCustomerId/{custId}")]
        public async Task<ActionResult<List<Cart>>> GetCartsByCustomerId(string custId)
        {
            try
            {
                List<Cart> carts = await cRepo.GetCartsByCustomerId(custId);
                return carts;
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }

        }
        [HttpGet("GetCartsByProductId/{proId}")]
        public async Task<ActionResult<List<Cart>>> GetCartsByProductId(string proId)
        {
            try
            {
                List<Cart> carts = await cRepo.GetCartsByproductId(proId);
                return carts;
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }

        }
        [HttpGet("GetCartByCustomerIdAndProductId/{custId}/{proId}")]
        public async Task<ActionResult<Cart>> GetCartByCustomerIdAndProductId(string custId,string proId)
        {
            try
            {
                Cart cart = await cRepo.GetCartByCustIdAndProId(custId, proId);
                return cart;
            }
            catch(Exception ex)
            {
                return NotFound(ex.Message);
            }
        }
        [HttpGet("getVendorStockOfProduct/{venId}/{proId}")]
        public async Task<ActionResult<VendorStock>> GetVendorStock(string venId,string proId)
        {
            try
            {
                VendorStock venStock = await cRepo.getVendorStockOfProduct(venId, proId);
                return venStock;
            }
            catch(Exception ex)
            {
                return NotFound(ex.Message);
            }
        }

        [HttpPost]
        public async Task<ActionResult> AddToCart(Cart cart)
        {
            await cRepo.AddToCart(cart);
            return Created($"api/Cart/{cart.CartId}", cart);
        }
        [HttpDelete("DeleteCart/{custId}/{proId}")]
        public async Task<ActionResult> DeleteCart(string custId,string proId)
        {
            await cRepo.DeleteCart(custId, proId);
            return Ok();
        }

    }
}
