using FORTEST_01_WEBAPI.DAC;
using FORTEST_02_DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FORTEST_01_WEBAPI.Controllers
{
    [RoutePrefix("api/Product")]
    public class ProductController : ApiController
    {
        ProductDAC dac = new ProductDAC();
        // GET
        /// <summary>
        /// 제품아이디와 이름 목록 출력
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("GetProducts")]
        public List<ProductVO> GetProducts()
        {
            return dac.GetProducts();
        }
    }
}
