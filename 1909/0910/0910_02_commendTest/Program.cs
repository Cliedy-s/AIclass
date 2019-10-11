using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0910_02_commendTest
{
    /*
     * 클래스설명  : 
     * 작  성  자   : 개발부 ㅇㅅㅇ ( email@naver.com )
     * 최초 작성일 :
     * 수 정 사 항 : ( 요청자, 수정자 ) 
     * 
     */

    class Program
    {
        static void Main(string[] args)
        {
            commentTest ct = new commentTest(2);
            ct.TestFunc(1, 2);
        }
    }

    /// <summary>
    /// 테스트 클래스입니다.
    /// </summary>
    class commentTest
    {
        int index = 0;
        /// <summary>
        /// 테스트 클래스의 생성자입니다.
        /// </summary>
        /// <param name="index">곱할 값1</param>
        public commentTest(int index)
        {
            this.index = index; 
        }
        /// <summary>
        /// 테스트 함수입니다. index와 value를 곱해 반환합니다.
        /// </summary>
        /// <param name="index">곱할 값1</param>
        /// <param name="value">곱할 값2</param>
        /// <returns>index와 value의 곱입니다.</returns>
        public int TestFunc(int index, int value = 0)
        {
            return index * value;
        }
    }
}
