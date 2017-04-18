using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ItemInfo.API.Controllers
{
    [Route("api/items")]
    public class ItemsController : Controller
    {
        [HttpGet()]
        public IActionResult GetItems()
        { 
            return Ok(ItemsDataStore.Current.Items);
        }

        [HttpGet("{id}")]
        public IActionResult GetItem(int id)
        {
            var item = ItemsDataStore.Current.Items.FirstOrDefault(i => i.Id == id);
            if(item == null)
            {
                return NotFound();
            }
            return Ok(item);
        }
    }
}
