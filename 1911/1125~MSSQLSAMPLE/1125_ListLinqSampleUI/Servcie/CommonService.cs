using _1125_ListLinqSample;
using _1125_ListLinqSampleVO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1125_ListLinqSampleUI
{
    public class CommonService
    {
        public List<ComboItemVO> GetCodeInfoByCodeTypes(string codeTypes, string separator)
        {
            CommonDAC dac = new CommonDAC();
            return dac.GetCodeInfoByCodeTypes(codeTypes, separator);
        }

        public string LoginCheck(string firstName, string lastName)
        {
            CommonDAC dac = new CommonDAC();
            return dac.LoginCheck(firstName, lastName);
        }
    }
}
