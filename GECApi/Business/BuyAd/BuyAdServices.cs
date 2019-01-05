using GECApi.Entities;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GECApi.Business.BuyAd
{
    public static class BuyAdServices
    {
        public static List<string> BuyAds(string countryCode, string paymentMethod)
        {
            try
            {
                HttpClientServices apiRequest = new HttpClientServices();

                var result = apiRequest.GetUnAuthorized("buy-bitcoins-online/"+ countryCode
                                                        + "/" + paymentMethod + "/.json").Result;

                var convertResult = JsonConvert.DeserializeObject(result);

                return new List<string>();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        public static Decimal buyAdsAboutAmount(string countryCode, string paymentMethod, string currency, int quantity)
        {
            try
            {
                HttpClientServices apiRequest = new HttpClientServices();

                var result = JObject.Parse(apiRequest.GetUnAuthorized("buy-bitcoins-online/" + countryCode + "/"
                                                            + "/" + paymentMethod + "/.json").Result);

                var convertResult = result.SelectToken("data").SelectToken("ad_list");
                List<Advertisement> ads = new List<Advertisement>();

                foreach (var item in convertResult)
                {
                    var ad = new Advertisement();
                    var itemData = item.SelectToken("data");

                    //Ad data
                    ad.temp_price = decimal.Parse(itemData.SelectToken("temp_price").ToString() == "" ? "0" : itemData.SelectToken("temp_price").ToString());
                    ad.bank_name = itemData.SelectToken("bank_name").ToString();
                    ad.min_amount = decimal.Parse(itemData.SelectToken("min_amount").ToString() == "" ? "0" : itemData.SelectToken("min_amount").ToString());
                    ad.currency = itemData.SelectToken("currency").ToString();

                    ads.Add(ad);
                }

                var amount = (ads.Where(x => x.currency == currency).Take(quantity).Sum(x => x.temp_price)) / quantity;


                return amount;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }
    }
}
