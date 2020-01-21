using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileDTO
{
    public class FilePathVO
    {
        public string FileName { get; set; }
        public string Path { get; set; }
        public long length { get; set; } // 업로드된 파일의 크기
    }
}
