using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProceedToBuyRepository.Models;
using ProceedToBuyRepository.Repos;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProceedToBuyService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class WishlistController : ControllerBase
    {
        IWishlistRepo wRepo;
        public WishlistController(IWishlistRepo repo)
        {
            wRepo = repo;
        }
        [HttpGet]
        public async Task<ActionResult<List<WishList>>> GetAllWishlist()
        {
            List<WishList> wLists = await wRepo.GetAllWishlist();
            return wLists;
        }
        [HttpGet("GetWishlistsByProductId/{proId}")]
        public async Task<ActionResult<List<WishList>>> GetWishlistsByProductId(string proId)
        {
            try
            {
                List<WishList> wLists = await wRepo.GetWishListsByProductId(proId);
                return wLists;
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }
        [HttpGet("GetWishListsByCustomerId/{custId}")]
        public async Task<ActionResult<List<WishList>>> GetWishlistsByCustomerId(string custId)
        {
            try
            {
                List<WishList> wLists = await wRepo.GetWishlistsByCustomerId(custId);
                return wLists;
            }
            catch(Exception ex)
            {
                return NotFound(ex.Message);
            }
        }
        [HttpGet("GetWishListByCustomerIdAndProductId/{custId}/{proId}")]
        public async Task<ActionResult<WishList>> GetWishListByCustomerIdAndProductId(string custId,string proId)
        {
            try
            {
                WishList wList = await wRepo.GetWishListByCustomerIdAndProductId(custId, proId);
                return wList;
            }
            catch(Exception ex)
            {
                return NotFound(ex.Message);
            }
        }
        [HttpPost]
        public async Task<ActionResult> AddToWishList(WishList wList)
        {
            await wRepo.AddToWishlist(wList);
            return Created($"api/WishList/{wList.ProductId}", wList);
        }
        [HttpDelete("DeleteWishList/{custId}/{proId}")]
        public async Task<ActionResult> DeleteWishList(string custId,string proId)
        {
            await wRepo.DeleteWishList(custId, proId);
            return Ok();
        }
    }
}
