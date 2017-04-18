using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ItemInfo.API.Controllers
{
    [Route("api/digs")]
    public class DigController : Controller
    {

        [HttpGet()]
        public IActionResult GetDigs()
        {
            return Ok(DataStore.Current.Digs);
        }

        [HttpGet("{id}")]
        public IActionResult GetDig(int id)
        {
            var dig = DataStore.Current.Digs.FirstOrDefault(i => i.Id == id);
            if (dig == null)
            {
                return NotFound();
            }
            return Ok(dig);
        }
    }
}
