using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0917_04_StringBuilder
{
    class StringBuilderProgram
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dicStudents = new Dictionary<string, string>();
            dicStudents["20190101"] = "김개똥";
            dicStudents["20190102"] = "박개똥";
            dicStudents["20190103"] = "홍개똥";
            dicStudents["20190104"] = "이개똥";
            dicStudents["20190105"] = "정개똥";

            // string str = string.Empty;
            StringBuilder sbStr = new StringBuilder();
            foreach (KeyValuePair<string, string> keyValuePair in dicStudents)
            {
                // str += string.Format("{0} : {1}\n", keyValuePair.Key, keyValuePair.Value); // 질 낮음
                // sbStr.Append(string.Format("{0} : {1}", keyValuePair.Key, keyValuePair.Value));
                // sbStr.AppendLine(string.Format("{0} : {1}", keyValuePair.Key, keyValuePair.Value)); // 자동으로 \n을 붙여줌
                // sbStr.AppendFormat("{0} : {1}\n", keyValuePair.Key, keyValuePair.Value);
                sbStr.AppendFormat(" {0} : {1},", keyValuePair.Key, keyValuePair.Value);

            }
            // Console.WriteLine(sbStr.ToString().Substring(0, sbStr.ToString().Length -1)); // 예전 방식
            Console.WriteLine(sbStr.ToString().TrimEnd(',').TrimStart(' '));
        }
    }
}
