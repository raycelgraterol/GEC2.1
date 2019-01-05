using System;
using System.Collections.Generic;
using System.Text;

namespace GECApi.Entities
{
    public class Advertisement
    {
        public Profile profile { get; set; }

        public string require_feedback_score { get; set; }

        public string hidden_by_opening_hours { get; set; }

        public string trade_type { get; set; }

        public string ad_id { get; set; }

        public decimal temp_price { get; set; }

        public string bank_name { get; set; }

        public string payment_window_minutes { get; set; }

        public string trusted_required { get; set; }

        public decimal min_amount { get; set; }

        public string visible { get; set; }

        public string require_trusted_by_advertiser { get; set; }

        public string temp_price_usd { get; set; }

        public string lat { get; set; }

        public string is_local_office { get; set; }

        public string first_time_limit_btc { get; set; }

        public string atm_model { get; set; }

        public string city { get; set; }

        public string location_string { get; set; }

        public string countrycode { get; set; }

        public string currency { get; set; }

        public string limit_to_fiat_amounts { get; set; }

        public string created_at { get; set; }

        public decimal max_amount { get; set; }

        public string lon { get; set; }

        public string is_low_risk { get; set; }

        public string sms_verification_required { get; set; }

        public string require_trade_volume { get; set; }

        public string online_provider { get; set; }

        public string max_amount_available { get; set; }

        public string msg { get; set; }

        public string require_identification { get; set; }

        public string volume_coefficient_btc { get; set; }

        public string public_view { get; set; }
    }
}
