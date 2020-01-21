using Newtonsoft.Json;
using ProductDTO.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Windows.Forms;

namespace _0110_03_CallWebAPI_WinForm
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            InitCombo();
        }

        private async void InitCombo()
        {
            HttpClient client = new HttpClient();
            try
            {
                using (HttpResponseMessage res = await client.GetAsync("https://localhost:44321/api/ProductDB"))
                {
                    //res.EnsureSuccessStatusCode();
                    //if (res.StatusCode == HttpStatusCode.OK)
                    //{
                    //    List<string> list = res.Content
                    //}

                    if (res.IsSuccessStatusCode)
                    {
                        var result = await res.Content.ReadAsStringAsync();

                        // List<string> categories = (new JavaScriptSerializer()).Deserialize<List<string>>(result);
                        List<string> categories = JsonConvert.DeserializeObject<List<string>>(result);
                        comboBox1.DataSource = categories;
                    }
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
            // comboBox1.DataSource =
        }

        private async void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            try
            {
                string uristr = $"https://localhost:44321/api/ProductDB/?category={comboBox1.Text}";
                using (HttpResponseMessage res = await client.GetAsync(uristr))
                {
                    if (res.IsSuccessStatusCode)
                    {
                        var result = await res.Content.ReadAsStringAsync();

                        List<ProductDB> list = JsonConvert.DeserializeObject<List<ProductDB>>(result);
                        dataGridView1.DataSource = list;
                    }
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            lblProductID.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            if (dataGridView1.SelectedRows[0].Cells[2].Value != null)
                txtDescription.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            else
                txtDescription.Text = "";
            txtProductName.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txtPrice.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
        }

        private async void button1_Click(object sender, EventArgs e)
        {   //조회버튼
            HttpClient client = new HttpClient();
            try
            {
                string uristr = $"https://localhost:44321/api/ProductDB/?category={comboBox1.Text}";
                using (HttpResponseMessage res = await client.GetAsync(uristr))
                {
                    if (res.IsSuccessStatusCode)
                    {
                        var result = await res.Content.ReadAsStringAsync();

                        List<ProductDB> list = JsonConvert.DeserializeObject<List<ProductDB>>(result);
                        dataGridView1.DataSource = list;
                    }
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private async void button2_Click(object sender, EventArgs e)
        {   //등록버튼
            HttpClient client = new HttpClient();
            DataGridViewRow row = dataGridView1.SelectedRows[0];
            try
            {
                string uristr = $"https://localhost:44321/api/ProductDB";
                using (HttpResponseMessage res = await client.PostAsJsonAsync(uristr,
                    new ProductDB()
                    {
                        Description = txtDescription.Text
                        ,
                        Name = txtProductName.Text
                        ,
                        Category = comboBox1.Text
                        ,
                        Price = Convert.ToInt32(txtPrice.Text)
                    }))
                {
                    if (res.IsSuccessStatusCode)
                    {
                        MessageBox.Show(await res.Content.ReadAsStringAsync());
                        // await response Content.ReadAsAsync<bool>(); // => 다른 타입을 리턴할 경우
                    }
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
            button1.PerformClick();
        }

        private async void button3_Click(object sender, EventArgs e)
        {   //수정버튼
            HttpClient client = new HttpClient();
            DataGridViewRow row = dataGridView1.SelectedRows[0];
            ProductDB product = new ProductDB()
            {
                Description = txtDescription.Text,
                Name = txtProductName.Text,
                Category = comboBox1.Text,
                Price = Convert.ToDecimal(txtPrice.Text)
            };

            try
            {
                string uristr = $"https://localhost:44321/api/ProductDB?id={Convert.ToInt32(lblProductID.Text)}";
                using (HttpResponseMessage res = await client.PutAsJsonAsync(uristr, product))
                {
                    MessageBox.Show(await res.Content.ReadAsStringAsync());
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }

            button1.PerformClick();
        }

        private async void button4_Click(object sender, EventArgs e)
        {   //삭제버튼
            HttpClient client = new HttpClient();
            DataGridViewRow row = dataGridView1.SelectedRows[0];
            try
            {
                string uristr = $"https://localhost:44321/api/ProductDB/{lblProductID.Text}";
                using (HttpResponseMessage res = await client.DeleteAsync(uristr))
                {
                    MessageBox.Show(await res.Content.ReadAsStringAsync());
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
            button1.PerformClick();
        }
    }
}