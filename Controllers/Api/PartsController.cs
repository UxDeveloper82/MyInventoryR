using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyInventoryR.Data;
using MyInventoryR.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyInventoryR.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class PartsController : ControllerBase
    {
        private readonly DataContext _context;

        public PartsController(DataContext context)
        {
            _context = context;
        }

        // GET: api/Parts
        [HttpGet]
        public IEnumerable<Part> GetParts()
        {
            return _context.Parts;
        }

    }
}
