using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Covid19_Data.Data;
using Covid19_Data.Model;
using Covid19_Data.Interface;

namespace Covid19_Data.Pages.DailyData
{
    public class IndexModel : PageModel
    {
        private readonly ICovid19Api _client;
        public IndexModel(ICovid19Api client)
        {
            _client = client;
        }
        public IList<CountryData> CountryData { get;set; }

        public async Task OnGetAsync()
        {
            var response = await _client.GetLatestData();
            CountryData = response.OrderByDescending(s => s.TotalConfirmed).ToList();
        }
    }
}
