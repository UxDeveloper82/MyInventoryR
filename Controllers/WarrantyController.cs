using Microsoft.AspNetCore.Mvc;
using MyInventoryR.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyInventoryR.Controllers
{
    public class WarrantyController : Controller
    {
        private readonly DataContext _context;

        public WarrantyController(DataContext context)
        {
            _context = context;
        }
        public ActionResult Index()
        {
            if (User.IsInRole("Admin"))
                return View("Index");
            else
                return View("ReadOnlyList");
        }
    }
}
