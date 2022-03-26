using System;
using Newtonsoft.Json;

namespace NoFrixionBitcoinPrice.Models
{
    public class CurrentPriceResponseDTO
    {
        [JsonProperty("time")]
        public Time Time { get; set; }

        [JsonProperty("disclaimer")]
        public string Disclaimer { get; set; }

        [JsonProperty("chartName")]
        public string ChartName { get; set; }

        [JsonProperty("bpi")]
        public Bpi Bpi { get; set; }
    }

    public class Time
    {
        [JsonProperty("updated")]
        public string Updated { get; set; }

        [JsonProperty("updatedISO")]
        public DateTime UpdatedISO { get; set; }

        [JsonProperty("updateduk")]
        public string Updateduk { get; set; }
    }

    public class CurrencyPrice
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("symbol")]
        public string Symbol { get; set; }

        [JsonProperty("rate")]
        public string Rate { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("rate_float")]
        public double RateFloat { get; set; }
    }

    public class Bpi
    {
        [JsonProperty("USD")]
        public CurrencyPrice USD { get; set; }

        [JsonProperty("GBP")]
        public CurrencyPrice GBP { get; set; }

        [JsonProperty("EUR")]
        public CurrencyPrice EUR { get; set; }
    }

}
