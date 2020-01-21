using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace FORTEST_03_CLIENT.Service
{
    public class ServiceParent
    {
        public HttpClient client { get; set; } = new HttpClient();
        public ServiceParent(string NextIP)
        {
            string url = $"{ConfigurationManager.AppSettings["apiaddress"]}{NextIP}/";
            client.BaseAddress = new Uri(url);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
    }
}
