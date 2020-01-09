using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _0102_04_TodoCRUD.Models
{
    public class TodoBoard
    {
        public TodoBoard()
        {
            this.WriteTime = DateTime.Now;
            this.ReadCount = 0;
            this.IsDone = false;
        }
        public int ID { get; set; }
        [DisplayName("제목")]
        [Required]
        public string Title { get; set; }
        [Required]
        [DisplayName("내용")]
        public string Contents { get; set; }
        [DisplayName("날짜")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime? WriteTime { get; set; }
        public int? ReadCount { get; set; }
        public bool IsDone { get; set; }

    }
}