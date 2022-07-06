using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RabbitMQ.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendorRepository.Models;
using VendorRepository.Repos;

namespace VendorService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class VendorStockController : ControllerBase
    {
        IVendorStockRepo venStockRepo;
        public VendorStockController(IVendorStockRepo vsRepo)
        {
            venStockRepo = vsRepo;
        }
        [HttpGet]
        public async Task<ActionResult<List<VendorStock>>> GetAllVendorStocks()
        {
            List<VendorStock> venStocks = await venStockRepo.GetAllVendorStocks();
            return Ok(venStocks);
        }
        [HttpGet("GetVendorStocks/{venId}")]
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

        //RabbitMQ
        private void PublishToMessageQueue(string integrationEvent, string eventData)
        {
            var factory = new ConnectionFactory();
            var connection = factory.CreateConnection();
            var channel = connection.CreateModel();
            var body = Encoding.UTF8.GetBytes(eventData);
            channel.BasicPublish(exchange: "vendorStock", routingKey: integrationEvent, basicProperties: null, body: body);
        }


        [HttpPost("InsertVendorStock")]
        public async Task<ActionResult> InsertVendorStock(VendorStock venStock)
        {
            await venStockRepo.InsertvendorStock(venStock);
            var integrationEventData = JsonConvert.SerializeObject(new { VendorId = venStock.VendorId, ProductId = venStock.ProductId,StockInHand=venStock.StockInHand });
            PublishToMessageQueue("vendorStock.add", integrationEventData);
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
