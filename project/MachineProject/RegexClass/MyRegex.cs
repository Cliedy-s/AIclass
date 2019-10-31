using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MyRegexClass
{
    public class MyRegex
    {
        public bool IsMatch(string text, string regexStr, string throwStr) {
            Regex regex = new Regex(regexStr);
            if (!(regex.IsMatch(text)))
            {
                throw new Exception(throwStr);
            }
            return true;
        }
    }
}
