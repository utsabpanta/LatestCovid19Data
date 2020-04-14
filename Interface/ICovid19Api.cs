using Covid19_Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Covid19_Data.Interface
{
    public interface ICovid19Api
    {
        public Task<List<CountryData>> GetLatestData();
    }
}
