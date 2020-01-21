using ProductDTO.DAC;
using ProductDTO.Models;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ProductDTO.Controllers
{
    public class ProductDBController : ApiController
    {
        public IEnumerable<string> GetCategory()
        {
            ProductDBDAC p_dac = new ProductDBDAC();
            return p_dac.GetProductCategory();
        }

        public List<ProductDB> GetProductDB(string category, int page = 0, int pageSize = 0)
        {
            ProductDBDAC p_dac = new ProductDBDAC();
            return p_dac.GetProducts(page, pageSize, category);
        }

        //// GET: api/ProductDB
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        // GET: api/ProductDB/5
        public HttpResponseMessage Get(int id)
        {
            ProductDBDAC dac = new ProductDBDAC();
            ProductDB product = dac.GetProductInfo(id);
            if (product == null)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, "항목이 없습니다.");
            }
            return Request.CreateResponse(HttpStatusCode.OK, product);
        }

        // POST: api/ProductDB
        public HttpResponseMessage Post([FromBody]ProductDB value)
        {
            ProductDBDAC dac = new ProductDBDAC();
            if (value != null)
            {
                if (dac.InsertProduct(value))
                {
                    return Request.CreateResponse(HttpStatusCode.Created, "성공적으로 등록되었습니다.");
                }
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "등록에 실패하였습니다.");
            }
            return Request.CreateErrorResponse(HttpStatusCode.NotFound, "전달된 데이터가 없습니다.");
        }

        // PUT: api/ProductDB/5
        public HttpResponseMessage Put(int id, [FromBody]ProductDB value)
        {
            ProductDBDAC dac = new ProductDBDAC();
            if (dac.IsExist(id))
            {
                if (dac.UpdateProduct(id, value))
                {
                    HttpResponseMessage res1 = Request.CreateResponse(HttpStatusCode.Created, "수정성공");
                    res1.Content = new StringContent($"성공적으로 수정되었습니다");
                    return res1;
                }
                HttpResponseMessage res2 = Request.CreateErrorResponse(HttpStatusCode.BadRequest, "수정실패");
                res2.Content = new StringContent("수정에 실패하였습니다.");
                return res2;
            }
            return Request.CreateErrorResponse(HttpStatusCode.NotFound, "등록된 제품이 없습니다.");
        }

        // DELETE: api/ProductDB/5
        public HttpResponseMessage Delete(int id)
        {
            ProductDBDAC dac = new ProductDBDAC();
            if (dac.IsExist(id))
            {
                if (dac.DeleteProduct(id))
                {
                    return Request.CreateResponse(HttpStatusCode.OK, "성공적으로 삭제되었습니다.");
                }
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "삭제에 실패하였습니다.");
            }
            return Request.CreateErrorResponse(HttpStatusCode.NotFound, "등록된 제품이 없습니다.");
        }
    }
}