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
    public class TechlinesController : ControllerBase
    {
        private readonly DataContext _context;

        public TechlinesController(DataContext context)
        {
            _context = context;
        }

        // GET: api/Techlines
        [HttpGet]
        public IEnumerable<Techline> GetTechlines()
        {
            return _context.Techlines.ToList();
        }

    }
}
