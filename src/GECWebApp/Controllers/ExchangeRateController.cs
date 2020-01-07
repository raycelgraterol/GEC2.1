using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GECApi.Entities;
using GECApi.Business.SellAd;
using GECApi.Business.BuyAd;
using System.Globalization;
using Microsoft.AspNetCore.Http;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GECWebApp.Controllers
{
    [Route("api/[controller]")]
    public class ExchangeRateController : Controller
    {

        // GET: api/ExchangeRate
        [HttpGet]
        public IEnumerable<string> Get()
        {
            HttpContext.Session.Clear();

            return new string[] { "Ok" };
        }

        // GET api/ExchangeRate/5
        [HttpGet("{id}")]
        public async Task<JsonResult> Get(int id)
        {
            try
            {
                var sellVE = await SellAdServices.SellAdsAboutAmount("VE", "", 2, 0);

                return Json(new { success = true, sellVe = sellVE[0].ToString("C3", CultureInfo.CreateSpecificCulture("es-VE")), sellVeHigh = sellVE[1].ToString("C3", CultureInfo.CreateSpecificCulture("es-VE")) });
            }
            catch (Exception)
            {
                return Json(new { success = false, Message = "Ocurrio un error." });
            }
        }        

        // POST api/ExchangeRate
        [HttpPost]
        public async Task<JsonResult> Post(string countryCode, string paymentMethod, string currency, decimal gain, bool isColombia)
        {
            int quantity = 10;

            if (countryCode == "PE" && currency == "USD")
            {
                quantity = 4;
            }
            else if (countryCode == "DO")
            {
                quantity = 5;
            }
            

            var buySP = BuyAdServices.buyAdsAboutAmount(countryCode, paymentMethod, currency, quantity);

            decimal sellVe = 1;
            
            byte[] test = null;
            if (HttpContext.Session.TryGetValue("SellVeDecimal", out test))
            {
                sellVe = decimal.Parse(HttpContext.Session.GetString("SellVeDecimal"));
            }
            else
            {
                var result = await SellAdServices.SellAdsAboutAmount("VE", "", 2, 0);
                sellVe = result[0];
            }

            var rate = decimal.Round((sellVe / buySP),4);

            var model = new ExchangeModel() {
                rateFormat = (rate).ToString("C3", CultureInfo.CreateSpecificCulture("es-VE")),
                rateValue = rate,
                rateValueGain = rate - (rate*gain/100),
                rateFormatGain = (rate - (rate * gain / 100)).ToString("C3", CultureInfo.CreateSpecificCulture("es-VE"))
            };

            return Json(model);
        }
    }
}
