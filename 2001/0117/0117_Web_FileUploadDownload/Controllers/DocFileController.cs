using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web;
using System.Web.Http;

namespace _0117_Web_FileUploadDownload.Controllers
{
    [RoutePrefix("api/DocFile")]
    public class DocFileController : ApiController
    {
        [HttpPost]
        [Route("UploadFile")]
        public HttpResponseMessage Post() // get은 바이트 제한이 있으므로 Post
        {
            var httpreq = HttpContext.Current.Request;
            if (httpreq.Files.Count > 0) //사용자가 파일을 올렸을 경우
            {
                List<string> list = new List<string>();
                foreach (string file in httpreq.Files)
                { // 유저의 파일 저장
                    var postedfile = httpreq.Files[file];
                    var filepath = HttpContext.Current.Server.MapPath("~/Uploads/" +postedfile.FileName ); // 상대경로(~/ 루트) => 절대경로 변환 ( C:/ProgramFiles/Steam ...)
                    postedfile.SaveAs(filepath);
                    list.Add(filepath);
                }
                return Request.CreateResponse(HttpStatusCode.OK, list);
            }
            return Request.CreateResponse(HttpStatusCode.BadRequest);
        }
    }
}
