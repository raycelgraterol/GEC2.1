using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace GECWebApp.Controllers
{
    public class ConsignmentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}