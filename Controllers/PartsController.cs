using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyInventoryR.Controllers
{
    public class PartsController : Controller
    {
        public IActionResult Index() 
        {
            if (User.IsInRole("Admin"))
                return View("Index");
            else
                return View("ReadOnlyList");
        }
    }
}
