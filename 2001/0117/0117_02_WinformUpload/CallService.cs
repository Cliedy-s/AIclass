using FileDTO;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace _0117_02_WinformUpload
{
    class CallService
    {
        HttpClient client = new HttpClient();
        string serverurl = string.Empty;
        public CallService()
        {
            serverurl = ConfigurationManager.AppSettings["apiaddress"];
            client.BaseAddress = new Uri($"{serverurl}api/FileHandle/");
            client.DefaultRequestHeaders.Clear();
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

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
                        string str = await response.Content.ReadAsStringAsync();
                        return (new JavaScriptSerializer()).Deserialize<T>(str);
                        //return JsonConvert.DeserializeObject<T>(str);
                    }
                }
            }
            catch (Exception ee)
            {

            }
            return obj;
        }
        public bool LocalDownLoad(string downloadFileName)
        {
            try
            {
                string url = $"{serverurl}Uploads/";
                string downloadpath = Application.StartupPath + @"\DownLoads\";
                if (!Directory.Exists(downloadpath)) Directory.CreateDirectory(downloadpath);

                string localFileName = downloadpath + downloadFileName;

                WebClient client = new WebClient();
                client.DownloadFile(url + downloadFileName, localFileName); // from => to
                return true;
            }
            catch (Exception err)
            {
                string msg = err.Message;
                return false;
            }
        }
        public async Task<bool> ServerUpload(string localfilename, string uploadFileName)
        {
            try
            {
                var filestream = File.Open(localfilename, FileMode.Open);
                var uploadfile = uploadFileName + new FileInfo(localfilename).Extension;

                MultipartFormDataContent content = new MultipartFormDataContent();
                content.Add(new StreamContent(filestream), "file1", uploadfile);

                using (HttpResponseMessage response = await client.PostAsync("UploadFile", content))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        FilePathVO info = JsonConvert.DeserializeObject<FilePathVO>(await response.Content.ReadAsStringAsync());
                        if(info != null)
                        {
                            return true;
                        }
                    }
                }

            }
            catch (Exception ee)
            {
                string msg = ee.Message;
                return false;
            }
            return false;
        }
    }
}
