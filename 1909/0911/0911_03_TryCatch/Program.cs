using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0911_03_TryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                        // exception
                        try
                        {
                            int[] nArray = new int[] { 0, 1, 2, 3, 4 };
                            int k = nArray[3] / 0;
                        }
                        catch (IndexOutOfRangeException) // else if
                        {
                            Console.WriteLine("배열의 인덱스가 범위를 벗어났습니다.");
                        }
                        catch (DivideByZeroException err) // else if
                        {
                            Console.WriteLine("{0} : 0으로 나누셨습니다.", err.Message);
                        }
                        catch (Exception err) //else
                        {
                            Console.WriteLine("{0} : 다시 입력해주세요.", err.Message);
                        }
            */
            // exception 2
            int iVal;
            short sVal;

            try
            {
                checked // 오버플로우, 언더플로우 체크 :: 내부적 예외 처리
                {
                    // iVal = Int32.MaxValue;
                    iVal = 10;
                    sVal = (short)iVal;
                }
                // throw new Exception("내가 발생시킨 오류입니다.");
                throw new OverflowException("내가 발생시킨 오류입니다.");
            }
            catch(OverflowException err)
            {
                Console.WriteLine("오버플로우거나 언더플로우 발생 :: {0}", err.Message);
                Console.WriteLine("source :: {0}", err.Source);
                Console.WriteLine("innerexception :: {0}", err.InnerException);
                Console.WriteLine("stacktrace :: {0}", err.StackTrace);
                Console.WriteLine("TargetSite :: {0}", err.TargetSite);
                Console.WriteLine("toString :: {0}", err.ToString());
            }
            catch(Exception err)
            {
                Console.WriteLine(err.Message);
            }
        }
    }
}
