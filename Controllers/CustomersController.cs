using Microsoft.AspNetCore.Mvc;
using MyInventoryR.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyInventoryR.Controllers
{
    public class CustomersController : Controller
    {
        private readonly DataContext _context;

        public CustomersController(DataContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var customers = _context.Customers.ToList();
            if (User.IsInRole("Admin"))
            {
                return View("Index", customers);
            }
            else
            {
                return View("ReadOnlyList", customers);
            }
        }
    }
}
