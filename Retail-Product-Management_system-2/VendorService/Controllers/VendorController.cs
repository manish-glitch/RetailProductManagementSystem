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
    public class VendorController : ControllerBase
    {
        IVendorRepo venRepo;
        public VendorController(IVendorRepo vRepo)
        {
            venRepo = vRepo;
        }
        [HttpGet("GetAllVendors")]
        public async Task<ActionResult<List<Vendor>>> GetAllVendors()
        {
            List<Vendor> vendors = await venRepo.GetAllVendors();
            return Ok(vendors);
        }
        [HttpGet("GetVenodrStocks/{venId}")]
        public async Task<ActionResult<List<VendorStock>>> GetVendorStock(string venId)
        {
            try
            {
                List<VendorStock> venStocks = await venRepo.GetVendorStocks(venId);
                return Ok(venStocks);
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }
        [HttpGet("GetVendorDetailById/{venId}")]
        public async Task<ActionResult<Vendor>> GetVendorDetailById(string venId)
        {
            try
            {
                Vendor ven = await venRepo.GetVendorDetailById(venId);
                return Ok(ven);
            }
            catch(Exception ex)
            {
                return NotFound(ex.Message);
            }
        }
        [HttpGet("getVendorStockOfProduct/{venId}/{proId}")]
        public async Task<ActionResult<VendorStock>> GetVendorStockOfProduct(string venId,string proId)
        {
            try
            {
                VendorStock venStock = await venRepo.GetVendorStockOfAProduct(venId, proId);
                return Ok(venStock);
            }
            catch(Exception ex)
            {
                return NotFound(ex.Message);
            }
        }
        [HttpPost("InsertVendor")]
        public async Task<ActionResult> InsertVendor(Vendor ven)
        {
            await venRepo.InsertVendor(ven);
            return Created($"api/Vendor/{ven.VendorId}", ven);
        }
        [HttpPost("InsertVendorStock")]
        public async Task<ActionResult> InsertVendorStock(VendorStock venStock)
        {
            await venRepo.InsertvendorStock(venStock);
            return Created($"api/VendorStock/{venStock.VendorId}/{venStock.ProductId}", venStock);
        }
        [HttpDelete("DeleteVendor/{venId}")]
        public async Task<ActionResult> DeleteVendor(string venId)
        {
            await venRepo.DeleteVendor(venId);
            return Ok();
        }
        [HttpDelete("DeleteVendorStock/{venId}/{proId}")]
        public async Task<ActionResult> DeleteVendorStock(string venId,string proId)
        {
            await venRepo.DeletevendorStock(venId, proId);
            return Ok();
        }
    }
}
