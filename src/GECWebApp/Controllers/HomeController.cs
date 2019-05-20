using System;
using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GECWebApp.Models;
using GECApi.Business.SellAd;
using System.Globalization;
using GECApi.Business.BuyAd;

namespace GECWebApp.Controllers
{
    public class HomeController : Controller
    {
        public async Task<IActionResult> Index()
        {
            byte[] test = null;
            if (HttpContext.Session.TryGetValue("SellVeDecimal", out test))
            {
                ViewBag.sellVe = HttpContext.Session.GetString("SellVeFormat");

                ViewBag.sellVeHigh = HttpContext.Session.GetString("SellVeHighFormat");
            }
            else
            {
                var sellVE = await SellAdServices.SellAdsAboutAmount("VE", "", 2);
                ViewBag.sellVe = sellVE[0].ToString("C3", CultureInfo.CreateSpecificCulture("es-VE"));

                ViewBag.sellVeHigh = (await SellAdServices.SellAdsAboutAmount("VE", "", 1))[1].ToString("C3", CultureInfo.CreateSpecificCulture("es-VE"));

                HttpContext.Session.SetString("SellVeFormat", sellVE[0].ToString("C3", CultureInfo.CreateSpecificCulture("es-VE")));
                HttpContext.Session.SetString("SellVeDecimal", sellVE[0].ToString());

                HttpContext.Session.SetString("SellVeHighFormat", sellVE[1].ToString("C3", CultureInfo.CreateSpecificCulture("es-VE")));
                HttpContext.Session.SetString("SellVeHighDecimal", sellVE[1].ToString());
            }
            
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
