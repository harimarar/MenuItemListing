using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MenuItemListing.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MenuItemController : ControllerBase
    {
        [HttpGet]
        public List<MenuItem> GetItem()
        {
            List<MenuItem> MenuList = new List<MenuItem>()
            {   new MenuItem() {Id=1, Name="Headset", Active=true, DateOfLaunch=new DateTime(2021,04,11), FreeDelivery=false,Price=2560},
                new MenuItem() {Id=2, Name="MemoryCard", Active=false, DateOfLaunch=new DateTime(2022,05,13), FreeDelivery=false,Price=650}

            };
            return MenuList;
        }

        [HttpGet("{id}")]
        public MenuItem GetItemById(int id)
        {
            List<MenuItem> MenuList = new List<MenuItem>()
            {    new MenuItem() {Id=1, Name="Headset", Active=true, DateOfLaunch=new DateTime(2021,04,11), FreeDelivery=false,Price=2560},
                new MenuItem() {Id=2, Name="MemoryCard", Active=false, DateOfLaunch=new DateTime(2022,05,13), FreeDelivery=false,Price=650}
            };
            MenuItem obj = MenuList.SingleOrDefault(item => item.Id == id);
            return obj;

        }

    }
}
