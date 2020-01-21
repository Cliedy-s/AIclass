using ProductDTO.Models;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace _0110_03_CallWebAPI_WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            try
            {
                using (HttpResponseMessage rm = await client.GetAsync("https://localhost:44321/api/Products"))
                {
                    if (rm.IsSuccessStatusCode)
                    {
                        string result;
                        using (HttpContent content = rm.Content)
                        {
                            result = await content.ReadAsStringAsync();
                        }
                        var jss = new JavaScriptSerializer();
                        List<Product> list = jss.Deserialize<List<Product>>(result);
                        dataGridView1.DataSource = list;
                    }
                }
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            try
            {
                using (HttpResponseMessage response = await client.PostAsJsonAsync<Product>("https://localhost:44321/api/Products", new Product() { Name = "새우깡", Category = "과자", Price = 2000 }))
                {
                    response.EnsureSuccessStatusCode();
                    if (response.StatusCode == HttpStatusCode.Created)
                    {
                        var resultMsg = await response.Content.ReadAsStringAsync();
                        MessageBox.Show(resultMsg);
                    }
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            try
            {
                Product product = new Product() { Name = "새우깡", Category = "과자", Price = 2000 };

                using (HttpResponseMessage res = await client.PutAsJsonAsync<Product>("https://localhost:44321/api/Products?id=3", product))
                {
                    res.EnsureSuccessStatusCode(); //코드를 얻어오는데 성공했을 경우
                    if (res.StatusCode == HttpStatusCode.OK)
                    {
                        var result = await res.Content.ReadAsStringAsync();
                        MessageBox.Show(result);
                    }
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private async void button4_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            try
            {
                using (HttpResponseMessage res = await client.DeleteAsync("https://localhost:44321/api/Products?id=3"))
                {
                    res.EnsureSuccessStatusCode(); //코드를 얻어오는데 성공했을 경우
                    if (res.StatusCode == HttpStatusCode.OK)
                    {
                        var result = await res.Content.ReadAsStringAsync();
                        MessageBox.Show(result);
                    }
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }
    }
}