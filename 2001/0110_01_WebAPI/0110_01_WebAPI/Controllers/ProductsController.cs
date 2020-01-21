using ProductDTO.Models;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Http;

namespace ProductDTO.Controllers
{
    public class ProductsController : ApiController
    {
        // api/Products/id
        private Product[] products = new Product[]
        {
            new Product { Id = 1, Name = "Tomato Soup", Category = "Groceries", Price = 1 },
            new Product { Id = 2, Name = "Yo-yo", Category = "Toys", Price = 3.75M },
            new Product { Id = 3, Name = "Hammer", Category = "Hardware", Price = 16.99M }
        };

        private List<Product> list;

        public ProductsController()
        {
            list = new List<Product>(products);
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return list;
        }

        //public IHttpActionResult GetProduct(int? id)
        //{
        //    var product = products.FirstOrDefault((p) => p.Id == id);
        //    if (product == null)
        //    {
        //        return NotFound();
        //    }
        //    return Ok(product);
        //}
        public HttpResponseMessage GetProduct(int? id)
        {
            var product = products.FirstOrDefault((p) => p.Id == id);
            if (product == null)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, "항목이 없습니다.");
            }
            return Request.CreateResponse(HttpStatusCode.OK, product);
        }

        // Post : api/Products/id
        public HttpResponseMessage Post(Product value)
        {
            if (value != null)
            {
                if (list.FirstOrDefault(x => x.Id == value.Id) == null) //list에 value가 없으면?
                {
                    list.Add(value);
                    // return Request.CreateResponse(HttpStatusCode.OK, value);

                    HttpResponseMessage res = Request.CreateResponse(HttpStatusCode.Created, value.Name);
                    res.Content = new StringContent($"성공적으로 등록되었습니다. 총 {list.Count()}건이 있습니다.", Encoding.Unicode);
                    return res;
                }
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, "이미 등록한 제품입니다.");
            }
            return Request.CreateErrorResponse(HttpStatusCode.NotFound, "전달된 데이터가 없습니다.");
        }

        // Put : api/Products/id
        public HttpResponseMessage Put(int id, [FromBody]Product value)
        {
            if (value != null)
            {
                var product = list.FirstOrDefault<Product>(x => x.Id == id);
                if (product != null)
                {
                    string defaultName = product.Name;
                    product.Name = value.Name;
                    product.Price = value.Price;
                    product.Category = value.Category;

                    HttpResponseMessage res = Request.CreateResponse(HttpStatusCode.OK, value.Name);
                    res.Content = new StringContent($"성공적으로 수정되었습니다. {defaultName}(이)가 {product.Name}(으)로 수정되었습니다.", Encoding.Unicode);
                    return res;
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.NoContent, "등록된 제품이 아닙니다.");
                }
            }
            return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "전달된 데이터가 없습니다.");
        }

        // Delete : api/Products/id
        public HttpResponseMessage Delete(int id)
        {
            if (id > 0)
            {
                var product = list.FirstOrDefault(p => p.Id == id);
                if (product != null)
                {
                    if (list.Remove(product))
                    {
                        HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK);
                        response.Content = new StringContent($"{product.Name}을 성공적으로 삭제하였습니다. 현재 {list.Count()}건이 있습니다.", Encoding.Unicode);

                        return response;
                    }
                }
                return Request.CreateResponse(HttpStatusCode.NoContent);
            }
            return Request.CreateErrorResponse(HttpStatusCode.NotFound, "삭제할 id가 없습니다.");
        }
    }
}