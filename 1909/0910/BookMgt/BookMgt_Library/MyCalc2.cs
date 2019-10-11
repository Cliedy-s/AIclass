using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookMgt_Library
{
    /// <summary>
    /// 두 수를 전달받아서 연산하는 클래스
    /// </summary>
    public class MyCalc2
    {
        /// <summary>
        /// 두 수를 전달받아서 더하는 함수
        /// </summary>
        /// <param name="a"> 더할 값 1</param>
        /// <param name="b"> 더할 값 2</param>
        /// <returns> = a+b, 더한 결과 값 </returns>
        public int Add(int a, int b)
        {
            return a + b + 100 +500;
        }
    }
}
