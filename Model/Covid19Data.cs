using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Covid19_Data.Model
{
    public class Global
    {
        public int NewConfirmed { get; set; }
        public int TotalConfirmed { get; set; }
        public int NewDeaths { get; set; }
        public int TotalDeaths { get; set; }
        public int NewRecovered { get; set; }
        public int TotalRecovered { get; set; }
    }

    public class CountryData
    {
        [JsonPropertyName("Country")]
        public string Country { get; set; }
        [JsonPropertyName("CountryCode")]
        public string CountryCode { get; set; }
        [JsonPropertyName("Slug")]
        public string Slug { get; set; }
        [JsonPropertyName("NewConfirmed")]
        public int NewConfirmed { get; set; }
        [JsonPropertyName("TotalConfirmed")]
        public int TotalConfirmed { get; set; }
        [JsonPropertyName("NewDeaths")]
        public int NewDeaths { get; set; }
        [JsonPropertyName("TotalDeaths")]
        public int TotalDeaths { get; set; }
        [JsonPropertyName("NewRecovered")]
        public int NewRecovered { get; set; }
        [JsonPropertyName("TotalRecovered")]
        public int TotalRecovered { get; set; }
        [JsonPropertyName("Date")]
        public DateTime Date { get; set; }
    }

    public class RootObject
    {
        [JsonProperty("Countries")]

        public List<CountryData> Countries { get; set; }
    }
}
