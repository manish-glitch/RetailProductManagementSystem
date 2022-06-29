using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VendorRepository.Models;
using VendorRepository.Repos;

namespace VendorService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VendorStockController : ControllerBase
    {
        IVendorStockRepo venStockRepo;
        public VendorStockController(IVendorStockRepo vsRepo)
        {
            venStockRepo = vsRepo;
        }
        [HttpGet("GetVenodrStocks/{venId}")]
        public async Task<ActionResult<List<VendorStock>>> GetVendorStock(string venId)
        {
            try
            {
                List<VendorStock> venStocks = await venStockRepo.GetVendorStocks(venId);
                return Ok(venStocks);
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }

        [HttpGet("GetVendorStocksByProductId/{proId}")]
        public async Task<ActionResult<List<VendorStock>>> GetVendorStocksByProductId(string proId)
        {
            try
            {
                List<VendorStock> venStocks = await venStockRepo.GetVendorStocksByProductId( proId);
                return Ok(venStocks);
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }

        [HttpGet("getVendorStockOfProduct/{venId}/{proId}")]
        public async Task<ActionResult<VendorStock>> GetVendorStockOfProduct(string venId, string proId)
        {
            try
            {
                VendorStock venStock = await venStockRepo.GetVendorStockOfAProduct(venId, proId);
                return Ok(venStock);
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }

        [HttpPost("InsertVendorStock")]
        public async Task<ActionResult> InsertVendorStock(VendorStock venStock)
        {
            await venStockRepo.InsertvendorStock(venStock);
            return Created($"api/VendorStock/{venStock.VendorId}/{venStock.ProductId}", venStock);
        }

        [HttpDelete("DeleteVendorStock/{venId}/{proId}")]
        public async Task<ActionResult> DeleteVendorStock(string venId, string proId)
        {
            await venStockRepo.DeletevendorStock(venId, proId);
            return Ok();
        }

    }
    

    
}
