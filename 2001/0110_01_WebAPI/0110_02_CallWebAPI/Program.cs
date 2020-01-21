using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace _0110_02_CallWebAPI
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // 1. HttpWebRequest 이용
            //CallHttpRequestClient();

            // 2. HttpClient 클래스 이용 (비동기)
            CallAsyncHttpClient().GetAwaiter().GetResult();
        }

        private static void CallHttpRequestClient()
        {
            string url = "https://localhost:44321/api/Products";
            string responseText = string.Empty;

            HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;
            request.Method = "GET";
            request.Timeout = 30 * 1000; //30초
            // 결과가 올 때까지 기다린다.
            using (HttpWebResponse resp = request.GetResponse() as HttpWebResponse)
            {
                Console.WriteLine(resp.StatusCode.ToString());
                Stream respStream = resp.GetResponseStream();
                using (StreamReader sr = new StreamReader(respStream))
                {
                    responseText = sr.ReadToEnd();
                }
            }
            Console.WriteLine(responseText);

            var jss = new JavaScriptSerializer();
            List<Product> list = jss.Deserialize<List<Product>>(responseText);

            Console.WriteLine(list.Count());
        }

        private static async Task CallAsyncHttpClient()
        {
            HttpClient client = new HttpClient();
            try
            {
                HttpResponseMessage rm = await client.GetAsync("https://localhost:44321/api/Products");
                if (rm.IsSuccessStatusCode)
                {
                    string result = await rm.Content.ReadAsStringAsync(); // 비동기로 읽기 시작해라
                    Console.WriteLine(result);

                    var jss = new JavaScriptSerializer();
                    List<Product> list = jss.Deserialize<List<Product>>(result);
                    foreach (var item in list)
                    {
                        Console.WriteLine(item.Name);
                    }
                }
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
        }
    }
}