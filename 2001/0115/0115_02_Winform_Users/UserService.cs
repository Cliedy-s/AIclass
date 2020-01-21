using DTO;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace _0115_02_Winform_Users
{
    public class UserService
    {
        HttpClient client = new HttpClient();
        public UserService()
        {
            string url = $"{ConfigurationManager.AppSettings["apiaddress"]}api/User/";
            client.BaseAddress = new Uri( url);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json")); // 무조건 json으로 받기
        }
        public async Task<T> GetListAsync<T>(string path)
        {
            T obj = default;
            try
            {
                using (HttpResponseMessage response = await client.GetAsync(path))
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
        public async Task<T> GetAsync<T>(string path)
        {
            T obj = default;
            try
            {
                using (HttpResponseMessage response = await client.GetAsync(path))
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
        public async Task<Message> GetAsync(string path)
        {
            Message msg = null;
            try
            {
                using (HttpResponseMessage response = await client.GetAsync(path))
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
        public async Task<Message<T>> PostAsync<T>(string path, T value)
        {
            Message<T> obj = null;
            try
            {
                using (HttpResponseMessage response = await client.PostAsJsonAsync<T>(path, value))
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
        public async Task<List<UserVO>> GetUserList()
        {
            List<UserVO> list = null;
            try
            {
                using (HttpResponseMessage response = await client.GetAsync("https://localhost:44388/api/User/GetAllUsers"))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var result = await response.Content.ReadAsStringAsync();
                        return JsonConvert.DeserializeObject<List<UserVO>>(result);
                    }
                }
            }
            catch (Exception ee)
            {
                Console.WriteLine(ee.Message);
            }
            return list;
        }

    }
}
