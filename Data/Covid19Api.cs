using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Covid19_Data.Model;
using Covid19_Data.Interface;
using Microsoft.Extensions.Configuration;
using Flurl.Http;
using Newtonsoft.Json;

namespace Covid19_Data.Data
{
    public class Covid19Api : ICovid19Api
    {
        private readonly string _baseUrl;
        public Covid19Api(IConfiguration config)
        {
            _baseUrl = config.GetValue<string>("Covid19API:BaseUrl");
        }

        public async Task<List<CountryData>> GetLatestData()
        {
            var response = await _baseUrl.GetJsonAsync<RootObject>();
            return response.Countries;
        }

    }
}
