using System.Collections.Generic;
using System.Web.Http;

namespace ProductDTO.Controllers
{
    public class HelloWorldController : ApiController
    {
        public string Get(int id)
        {
            return "HelloWorld" + id;
        }

        public IEnumerable<string> Get()
        {
            return new string[] { "HI", "Nice To Meet Ya" };
        }
    }
}