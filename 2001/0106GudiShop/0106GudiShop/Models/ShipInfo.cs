using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _0106GudiShop.Models
{
    public class ShipInfo
    {
        [Required(ErrorMessage ="이름을 입력해주세요")]
        [DisplayName("이름")]
        public string Name { get; set; }
        [Display(Name="주소")]
        [Required(ErrorMessage = "주소를 입력해주세요")]
        public string Addr1 { get; set; }
        [Display(Name = "상세주소")]
        public string Addr2 { get; set; }

        [Display(Name = "이메일")]
        public string Email { get; set; }
        [Display(Name = "택배기사님께")]
        public string Message { get; set; }
    }
}