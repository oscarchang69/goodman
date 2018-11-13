using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace GoodMan.Service
{
    class MyWebApi
    {

        private static readonly HttpClient Instance = new HttpClient();

        public static async Task<CompanyInfo> GetCompanyInfo()
        {
            //TODO Step10 Code insert here
            var resultStr = await Instance.GetStringAsync("https://xamarinclassdemo.azurewebsites.net/api/getthinkpower");
            var companyInfo = JsonConvert.DeserializeObject<CompanyInfo>(resultStr);

            return companyInfo;
        }

    }

    public class CompanyInfo
    {
        public string Name { get; set; }
        public int Found { get; set; }
        public string Tel { get; set; }
        public string Address { get; set; }
        public int VatNumber { get; set; }
        public string LatLng { get; set; }
    }
}
