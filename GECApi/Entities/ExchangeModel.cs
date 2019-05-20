using System;
using System.Collections.Generic;
using System.Text;

namespace GECApi.Entities
{
    public class ExchangeModel
    {
        public decimal rateValue { get; set; }

        public string rateFormat { get; set; }

        public decimal rateValueGain { get; set; }

        public string rateFormatGain { get; set; }

        public decimal rateValueHigh { get; set; }

        public string rateFormatHigh { get; set; }
    }
}
