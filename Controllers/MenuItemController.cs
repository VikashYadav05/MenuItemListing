using MenuItemListing.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MenuItemListing.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MenuItemController : ControllerBase
    {
        static List<MenuItem> items = new List<MenuItem>()
        {
            new MenuItem(){Id=1,Name="Vikash1",freeDelivery=true,Price=200,dateOfLaunch=new DateTime(2021,9,21),Active=true},
            new MenuItem(){Id=2,Name="Vikash2",freeDelivery=false,Price=500.6,dateOfLaunch=new DateTime(2021,9,21),Active=true},
            new MenuItem(){Id=3,Name="Vikash3",freeDelivery=true,Price=700,dateOfLaunch=new DateTime(2021,9,21),Active=false}
        };

        [HttpGet]
        public IActionResult GetItem()
        {
            return Ok(items);
        }

        [HttpGet]
        public IActionResult GetItem(int id)
        {
            foreach (var i in items)
            {
                if (i.Id == id)
                {
                    return Ok(i.Name);
                }
            }
            return NotFound("Invalid Id");
        }

    }
}
