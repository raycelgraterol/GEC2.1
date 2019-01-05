using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GECApi.Business.SellAd;
using Microsoft.AspNetCore.Http;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GECWebApp.Controllers
{
    public class ManagementChangeController : Controller
    {
        // GET: /<controller>/
        public async Task<ViewResult> Index()
        {
            var model = await SellAdServices.SellAdsList("VE", "transfers-with-specific-bank", "VES", null);

            return View(model);
        }

        public async Task<PartialViewResult> SearchSell(decimal? sellValue)
        {
            var model = await SellAdServices.SellAdsList("VE", "transfers-with-specific-bank", "VES", sellValue);

            return PartialView("_sellResult", model);
        }
    }
}
