using FileDTO;
using _0117_Web_FileUploadDownload.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;

namespace _0117_Web_FileUploadDownload.Controllers
{
    [RoutePrefix("api/FileHandle")]
    public class FileHandleController : ApiController
    {
        [HttpGet]
        [Route("GetFileInfo")]
        public IEnumerable<FilePathVO> GetFileInfo()
        {
            List<FilePathVO> files = new List<FilePathVO>();
            var uploadPath = HttpContext.Current.Server.MapPath("~/Uploads/");
            DirectoryInfo dir = new DirectoryInfo(uploadPath);
            foreach (FileInfo file in dir.GetFiles())
            {
                files.Add(new FilePathVO { FileName = file.Name, Path = uploadPath, length = file.Length });
            }
            return files;
        }

        [HttpPost]
        [Route("UploadFile")]
        public async Task<FilePathVO> Post()
        {
            FilePathVO result = null;   
            var httpreq = HttpContext.Current.Request;

            if (Request.Content.IsMimeMultipartContent()) // multipart로 올릴것
            {
                var uploadPath = HttpContext.Current.Server.MapPath("~/Uploads/");
                if (!Directory.Exists(uploadPath)) Directory.CreateDirectory(uploadPath);

                var multipart = new UploadFileMultipartProvider(uploadPath);
                await Request.Content.ReadAsMultipartAsync(multipart); //파일들을 다 업로드함
                string _localFileName = multipart.FileData.Select(p => p.LocalFileName).FirstOrDefault();

                result = new FilePathVO()
                {
                    FileName = _localFileName,
                    Path = Path.GetFileName(_localFileName),
                    length = new FileInfo(_localFileName).Length
                }; // 올린 첫번째 파일 정보 전달

                List<string> docfiles = new List<string>();
                foreach (string file in httpreq.Files)
                { // 유저의 파일 저장
                    var postedfile = httpreq.Files[file];
                    var filepath = HttpContext.Current.Server.MapPath("~/Uploads/" + postedfile.FileName); // 상대경로(~/ 루트) => 절대경로 변환 ( C:/ProgramFiles/Steam ...)
                    postedfile.SaveAs(filepath);
                    docfiles.Add(filepath);
                }
            }
            return result;
        }

        //[HttpPost]
        //[Route("UploadFile")]
        //public async Task<HttpResponseMessage> Post()
        //{
        //    var httpreq = HttpContext.Current.Request;

        //    if (Request.Content.IsMimeMultipartContent()) // multipart로 올릴것
        //    {
        //        var uploadPath = HttpContext.Current.Server.MapPath("~/Uploads/");
        //        if (!Directory.Exists(uploadPath)) Directory.CreateDirectory(uploadPath);

        //        await Request.Content.ReadAsMultipartAsync(new UploadFileMultipartProvider(uploadPath));

        //        List<string> docfiles = new List<string>();
        //        foreach (string file in httpreq.Files)
        //        { // 유저의 파일 저장
        //            var postedfile = httpreq.Files[file];
        //            var filepath = HttpContext.Current.Server.MapPath("~/Uploads/" + postedfile.FileName); // 상대경로(~/ 루트) => 절대경로 변환 ( C:/ProgramFiles/Steam ...)
        //            postedfile.SaveAs(filepath);
        //            docfiles.Add(filepath);
        //        }

        //        return Request.CreateResponse(HttpStatusCode.OK, docfiles);
        //    }
        //    return Request.CreateResponse(HttpStatusCode.BadRequest);
        //}
    }
}
