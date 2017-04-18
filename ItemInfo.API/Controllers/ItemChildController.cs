using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ItemInfo.API.Controllers
{
    [Route("api/items")]
    public class ItemChildController : Controller
    {
        [HttpGet("{id}/children")]
        public IActionResult GetChildren(int id)
        {
            var item = ItemsDataStore.Current.Items.Where(i => i.Id == id).FirstOrDefault();
            if(item == null)
            {
                return NotFound();
            }
            return Ok(item.Children);
        }

        [HttpGet("{itemId}/children/{id}")]
        public IActionResult GetChild(int itemId, int id)
        {
            var item = ItemsDataStore.Current.Items.Where(i => i.Id == itemId).FirstOrDefault();
            if (item == null)
            {
                return NotFound();
            }
            var child = item.Children.Where(c => c.Id == id).FirstOrDefault();
            if (child == null)
            {
                return NotFound();
            }
            return Ok(child);
        }
    }
}
