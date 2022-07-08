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

        //RabbitMQ
        private void PublishToMessageQueue(string integrationEvent, string eventData)
        {
            var factory = new ConnectionFactory();
            var connection = factory.CreateConnection();
            var channel = connection.CreateModel();
            var body = Encoding.UTF8.GetBytes(eventData);
            channel.BasicPublish(exchange: "vendor", routingKey: integrationEvent, basicProperties: null, body: body);
        }

        [HttpPost("InsertVendor")]
        public async Task<ActionResult> InsertVendor(Vendor ven)
        {
            await venRepo.InsertVendor(ven);
            var integrationEventData = JsonConvert.SerializeObject(new { VendorId = ven.VendorId });
            PublishToMessageQueue("vendor.add", integrationEventData);
            return Created($"api/Vendor/{ven.VendorId}", ven);
        }
        
        [HttpDelete("DeleteVendor/{venId}")]
        public async Task<ActionResult> DeleteVendor(string venId)
        {
            await venRepo.DeleteVendor(venId);
            return Ok();
        }
        
    }
}
