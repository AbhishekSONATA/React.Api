using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using React.Api.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace React.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuperVillainController : ControllerBase
    {
        private readonly ReactJSDemoContext _reactJSDemoContext;

        public SuperVillainController(ReactJSDemoContext reactJSDemoContext)
        {
            _reactJSDemoContext = reactJSDemoContext;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var villain = await _reactJSDemoContext.SuperVillain.ToListAsync();
            return Ok(villain);
        }
    }
}
