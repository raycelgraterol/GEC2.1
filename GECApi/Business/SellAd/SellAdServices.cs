using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using GECApi.Entities;
using System.Linq;
using System.Threading.Tasks;
using System.Globalization;

namespace GECApi.Business.SellAd
{
    public static class SellAdServices
    {
        public async static Task<List<Advertisement>> SellAds(string countryCode, string country, string paymentMethod)
        {
            try
            {
                HttpClientServices apiRequest = new HttpClientServices();

                var result = JObject.Parse(await apiRequest.GetUnAuthorized("sell-bitcoins-online/" + countryCode + "/" + country + "/"  
                                                            + "/"+ paymentMethod +"/.json"));

                var convertResult = result.SelectToken("data").SelectToken("ad_list");
                List<Advertisement> ads = new List<Advertisement>();

                foreach (var item in convertResult)
                {
                    var ad = new Advertisement();
                    var itemData = item.SelectToken("data");
                    var itemProfile = itemData.SelectToken("profile");
                    
                    //Profile data
                    ad.profile = new Profile() {
                        username = itemProfile.SelectToken("feedback_score").ToString(),
                        feedback_score = itemProfile.SelectToken("feedback_score").ToString(),
                        trade_count = itemProfile.SelectToken("trade_count").ToString(),
                        last_online = itemProfile.SelectToken("last_online").ToString(),
                        name = itemProfile.SelectToken("name").ToString()};
                    
                    //Ad data
                    ad.require_feedback_score = itemData.SelectToken("require_feedback_score").ToString();
                    ad.hidden_by_opening_hours = itemData.SelectToken("hidden_by_opening_hours").ToString();
                    ad.temp_price = decimal.Parse(itemData.SelectToken("temp_price").ToString());
                    ad.bank_name = itemData.SelectToken("bank_name").ToString();
                    ad.min_amount = decimal.Parse(itemData.SelectToken("min_amount").ToString());
                    ad.currency = itemData.SelectToken("currency").ToString();
                    ad.max_amount = decimal.Parse(itemData.SelectToken("max_amount").ToString());
                    ad.msg = itemData.SelectToken("msg").ToString();                    

                    ads.Add(ad);
                }
                

                return ads;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        public async static Task<Decimal[]> SellAdsAboutAmount(string countryCode, string paymentMethod, int page, string countryName = "venezuela")
        {
            try
            {
                HttpClientServices apiRequest = new HttpClientServices();

                string secondParameter = string.IsNullOrEmpty(paymentMethod) ? countryName : paymentMethod;

                var result = JObject.Parse(await apiRequest.GetUnAuthorized("sell-bitcoins-online/" + countryCode +
                                                            "/" + secondParameter + "/.json?page=" + page.ToString()));


                var convertResult = result.SelectToken("data").SelectToken("ad_list");
                List<Advertisement> ads = new List<Advertisement>();

                foreach (var item in convertResult)
                {
                    var ad = new Advertisement();
                    var itemData = item.SelectToken("data");
                    
                    //Ad data
                    ad.temp_price = decimal.Parse(itemData.SelectToken("temp_price").ToString());
                    ad.bank_name = itemData.SelectToken("bank_name").ToString();
                    ad.min_amount = decimal.Parse(itemData.SelectToken("min_amount").ToString() == "" ? "0" : itemData.SelectToken("min_amount").ToString());
                    ad.currency = itemData.SelectToken("currency").ToString();
                    
                    ads.Add(ad);
                }

                Decimal[] amount = new Decimal[2];

                amount[0] = (ads.Where(x => ((x.bank_name.ToLower().Contains("mercantil")
                                         || x.bank_name.ToLower().Contains("mercan")
                                         || x.bank_name.ToLower().Contains("mer")
                                         || x.bank_name.ToLower().Contains("bod")
                                         || x.bank_name.ToLower().Contains("provincial")
                                         || x.bank_name.ToLower().Contains("banes")
                                         || x.bank_name.ToLower().Contains("banesco"))
                                         && x.currency.Contains("VES")
                                         && x.min_amount <= 20000m)
                                         && !x.bank_name.ToLower().Contains("bitmain"))
                                         .Skip(2).Take(5).Sum(x => x.temp_price)) / 5;

                amount[1] = (ads.Where(x => (x.bank_name.ToLower().Contains("mercantil")
                                         || x.bank_name.ToLower().Contains("mercan")
                                         || x.bank_name.ToLower().Contains("mer")
                                         || x.bank_name.ToLower().Contains("bod")
                                         || x.bank_name.ToLower().Contains("provincial")
                                         || x.bank_name.ToLower().Contains("banes")
                                         || x.bank_name.ToLower().Contains("banesco"))
                                         && x.currency.Contains("VES")
                                         && x.min_amount <= 20000m
                                         && !x.bank_name.ToLower().Contains("bitmain"))
                                         .Skip(2).Take(5).Sum(x => x.temp_price)) / 5;
                                         

                return amount;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        public async static Task<IEnumerable<Advertisement>> SellAdsList(string countryCode, string paymentMethod, string currency, decimal? minAmount)
        {
            try
            {
                HttpClientServices apiRequest = new HttpClientServices();

                var result = JObject.Parse(await apiRequest.GetUnAuthorized("sell-bitcoins-online/" + countryCode + "/"
                                                            + "/" + paymentMethod + "/.json"));


                var convertResult = result.SelectToken("data").SelectToken("ad_list");
                List<Advertisement> ads = new List<Advertisement>();

                foreach (var item in convertResult)
                {
                    var ad = new Advertisement();
                    ad.profile = new Profile();

                    ad.public_view = item.SelectToken("actions").SelectToken("public_view").ToString();

                    var itemData = item.SelectToken("data");
                    var itemProfile = itemData.SelectToken("profile"); ;
                    //Ad Profile
                    ad.profile.name = itemProfile.SelectToken("username").ToString();
                    ad.profile.feedback_score = itemProfile.SelectToken("feedback_score").ToString();
                    ad.profile.trade_count = itemProfile.SelectToken("trade_count").ToString();
                    ad.profile.last_online = itemProfile.SelectToken("last_online").ToString();
                    
                    //Ad data
                    ad.temp_price = decimal.Parse(itemData.SelectToken("temp_price").ToString());
                    ad.bank_name = itemData.SelectToken("bank_name").ToString();
                    ad.min_amount = decimal.Parse(itemData.SelectToken("min_amount").ToString() == "" ? "0" : itemData.SelectToken("min_amount").ToString());
                    ad.max_amount = decimal.Parse(itemData.SelectToken("max_amount").ToString() == "" ? "0" : itemData.SelectToken("max_amount").ToString());
                    ad.currency = itemData.SelectToken("currency").ToString();

                    ads.Add(ad);
                }
                if (minAmount != null)
                {
                    return ads.Where(x => x.min_amount <= minAmount).Where(y => y.currency == currency);
                }
                else
                {
                    return ads.Where(y => y.currency == currency);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }
    }
}
