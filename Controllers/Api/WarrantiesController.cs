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
    public class WarrantiesController : ControllerBase
    {
        private readonly DataContext _context;

        public WarrantiesController(DataContext context)
        {
            _context = context;
        }

        // GET: api/Warranties
        [HttpGet]
        public IEnumerable<Warranty> GetWarranties()
        {
            return _context.Warranties.ToList();
        }

    }
}
