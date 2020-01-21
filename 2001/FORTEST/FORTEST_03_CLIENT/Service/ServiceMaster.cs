using DTO;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace FORTEST_03_CLIENT.Service
{
    public static class ServiceMaster
    {
        public static async Task<T> GetListAsync<T>(ServiceParent service, string path)
        {
            T obj = default;
            try
            {
                using (HttpResponseMessage response = await service.client.GetAsync(path))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        return JsonConvert.DeserializeObject<T>(await response.Content.ReadAsStringAsync());
                    }
                }
            }
            catch (Exception ee)
            {
                Console.WriteLine(ee.Message);
            }
            return obj;
        }
        public static async Task<T> GetAsync<T>(ServiceParent service, string path)
        {
            T obj = default;
            try
            {
                using (HttpResponseMessage response = await service.client.GetAsync(path))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        Message<T> msg = JsonConvert.DeserializeObject<Message<T>>(await response.Content.ReadAsStringAsync());
                        return msg.Data;
                    }
                }
            }
            catch (Exception ee)
            {
                Console.WriteLine(ee.Message);
            }
            return obj;
        }
        public static async Task<Message> GetAsync(ServiceParent service, string path)
        {
            Message msg = null;
            try
            {
                using (HttpResponseMessage response = await service.client.GetAsync(path))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        return JsonConvert.DeserializeObject<Message>(await response.Content.ReadAsStringAsync());
                    }
                }
            }
            catch (Exception ee)
            {
                Console.WriteLine(ee.Message);
            }
            return msg;
        }
        public static async Task<Message<T>> PostAsync<T>(ServiceParent service, string path, T value)
        {
            Message<T> obj = null;
            try
            {
                using (HttpResponseMessage response = await service.client.PostAsJsonAsync<T>(path, value))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        return JsonConvert.DeserializeObject<Message<T>>(await response.Content.ReadAsStringAsync());
                    }
                }
            }
            catch (Exception ee)
            {
                Console.WriteLine(ee.Message);
            }
            return obj;
        }
    }
}
