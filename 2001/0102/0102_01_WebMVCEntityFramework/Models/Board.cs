using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _0102_01_WebMVCEntityFramework.Models
{
    public class Board
    {
        public int ID { get; set; } //ID로 잡으면 자동으로 잡아줌 : PK
        [Required]
        public string Name { get; set; }
        [Required]
        public string Subject { get; set; }
        public string Content { get; set; }[DisplayFormat(DataFormatString ="{0:yyyy-MM-dd}")]
        public DateTime? WriteTime { get; set; } = DateTime.Now; // nullable 설정 : DateTime?
        public int? ReadCount { get; set; } = 0;
    }
}