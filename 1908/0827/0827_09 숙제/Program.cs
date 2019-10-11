using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0827_09_숙제
{
    class Program
    {
        static void Main(string[] args)
        {
            // 점수 입력 :  abcdf 학점 출력
            Console.WriteLine("점수 입력 : ");
            int score = int.Parse(Console.ReadLine());
            string result1;

            if (score >= 90)
                result1 = "A";
            else if (score >= 80)
                result1 = "B";
            else if (score >= 70)
                result1 = "C";
            else if (score >= 60)
                result1 = "D";
            else
                result1 = "F";
            Console.WriteLine("학점 : {0}", result1);
            /* // switch문
                        switch (score / 10)
                        {
                            case 10: case 9: // 90점 이상
                                result1 = "A";
                                break;
                            case 8: // 80점 이상
                                result1 = "B";
                                break;
                            case 7: // 70점 이상
                                result1 = "C";
                                break;
                            case 6: // 60
                                result1 = "D";
                                break;
                            default:
                                result1 = "F";
                                break;
                        }
                        Console.WriteLine("학점 : {0}",result1);
            */

            // 성별 입력 : 성별 출력
            Console.WriteLine("성별 입력 ( 남자 :m, 여자 :f ) : ");
            char gender = char.Parse(Console.ReadLine());
            string result2;

            switch (gender)
            {
                case 'm': case 'M':
                    result2 = "남자";
                break;
                case 'f': case 'F':
                    result2 = "여자";
                    break;
                default:
                    result2 = "다시 입력해주세요";
                    break;
            }
            Console.WriteLine("성별 : {0}", result2);
        }

    }
}
