using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1125_ListLinqSampleVO
{
    public class ComboItemVO
    {
        public string Code { get; set; }
        public string CodeNm { get; set; }
        public string PCode { get; set; }
        public string CodeType { get; set; }

        public ComboItemVO() {}
        public ComboItemVO(string blankText)
        {
            CodeNm = blankText;
        }
    }
}
