using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0919_04_DirectoryHandle
{
    class DirectoryHandle
    {
        static void Main(string[] args)
        {
            DirectoryInfo dirInfo = new DirectoryInfo(@"C:\Windows\System");

            if (dirInfo.Exists)
            {
                Console.WriteLine("{0,-12} : {1} ", "FullName", dirInfo.FullName);
                Console.WriteLine("{0,-12} : {1} ", "CreationTime", dirInfo.CreationTime);
                Console.WriteLine("{0,-12} : {1} ", "Root", dirInfo.Root);
                Console.WriteLine("{0,-12} : {1} ", "Parent", dirInfo.Parent);
                                                      
                Console.WriteLine("{0,-12} : {1} ", "Attributes", dirInfo.Attributes);
            }
            else
            {
                Console.WriteLine("디렉터리가 없습니다");
            }

            //=====================================================
            DirectoryInfo dirInfo02 = new DirectoryInfo(@"C:\Temp\DirSampleTemp");
            Console.WriteLine();

            Console.WriteLine("{0} 디렉터리를 생성합니다.", dirInfo02);
            dirInfo02.Create();

            Console.WriteLine(@"/년 디렉터리를 하위에 생성합니다.");
            dirInfo02.CreateSubdirectory(DateTime.Now.Year.ToString());

            Console.WriteLine("{0} 디렉터리 하위까지 모두 지웁니다.", dirInfo02);
            dirInfo02.Delete(true);
        }
    }
}
