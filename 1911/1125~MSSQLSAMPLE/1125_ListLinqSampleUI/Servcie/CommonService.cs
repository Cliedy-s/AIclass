using System;
using System.Collections.Generic;
using _1125_ListLinqSample;
using _1125_ListLinqSampleVO;

namespace _1125_ListLinqSampleUI
{
    internal class CommonService
    {
        internal List<ComboItemVO> GetCodeInfoByCodeTypes(string codeTypes, string separator)
        {
            CommonDAC dac = new CommonDAC();
            return dac.GetCodeInfoByCodeTypes(codeTypes, separator);

        }
    }
}