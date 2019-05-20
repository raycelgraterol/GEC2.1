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
                var sellVE = await SellAdServices.SellAdsAboutAmount("VE", "", 1);

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
            var buySP = BuyAdServices.buyAdsAboutAmount(countryCode, paymentMethod, currency, countryCode == "PE" && currency == "USD" ? 2 : 10);

            Decimal sellVe = 1;
            Decimal sellVeHigh = 1;

            byte[] test = null;
            if (HttpContext.Session.TryGetValue("SellVeDecimal", out test))
            {
                sellVe = decimal.Parse(HttpContext.Session.GetString("SellVeDecimal"));
                sellVeHigh = decimal.Parse(HttpContext.Session.GetString("SellVeHighDecimal"));
            }
            else
            {
                var result = await SellAdServices.SellAdsAboutAmount("VE", "", 2);
                sellVe = result[0];

                sellVeHigh = (await SellAdServices.SellAdsAboutAmount("VE", "", 1))[1];
            }

            var rate = isColombia ? decimal.Round((buySP / sellVe), 4) : decimal.Round((sellVe / buySP),4);

            var rateHigh = isColombia ? decimal.Round((buySP / sellVeHigh), 4) :  decimal.Round((sellVeHigh / buySP), 4);

            var model = new ExchangeModel() {
                //Sin Ganancia
                rateFormat = isColombia ? decimal.Round(buySP/sellVe,2).ToString()  : (rate).ToString("C3", CultureInfo.CreateSpecificCulture("es-VE")),
                rateValue = (isColombia ? buySP/sellVe : rate),
                //Con ganancia
                rateValueGain = isColombia ? (rate * (100 + gain)/100) : (rate * (100 - gain)/100),
                rateFormatGain = isColombia ? decimal.Round((buySP/sellVe)*((100 + gain) / 100), 2).ToString() : (rate * (100 - gain)/100).ToString("C3", CultureInfo.CreateSpecificCulture("es-VE")),
                //Mayoristas
                rateValueHigh = isColombia ? (rateHigh * (100 + gain) / 100) : (rateHigh * (100 - gain) / 100),
                rateFormatHigh = isColombia ? decimal.Round((buySP / sellVeHigh) * ((100 + gain) / 100), 2).ToString() : (rateHigh * (100 - gain) / 100).ToString("C3", CultureInfo.CreateSpecificCulture("es-VE")),
            };

            return Json(model);
        }
    }
}
