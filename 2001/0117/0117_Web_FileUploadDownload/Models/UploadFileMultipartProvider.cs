using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;

namespace _0117_Web_FileUploadDownload.Models
{
    public class UploadFileMultipartProvider : MultipartFormDataStreamProvider
    {
        public UploadFileMultipartProvider(string rootPath) : base(rootPath){}
        public UploadFileMultipartProvider(string rootPath, int bufferSize) : base(rootPath, bufferSize){}

        public override string GetLocalFileName(HttpContentHeaders headers)
        {
            if(headers != null && headers.ContentDisposition != null)
            {
                return headers.ContentDisposition.FileName.TrimEnd('"').TrimStart('"');
            }
            return base.GetLocalFileName(headers);
        }

    }
}