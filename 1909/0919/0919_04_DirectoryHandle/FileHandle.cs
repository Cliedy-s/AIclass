using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0919_04_DirectoryHandle
{
    class FileHandle
    {
        static void Main(string[] args)
        {
            FileInfo sourceFile = new FileInfo(@"D:\AIclass\1909\0919\0919_04_DirectoryHandle\FileHandle.cs");

            if (sourceFile.Exists)
            {
                FileInfo copyFile = sourceFile.CopyTo(@"C:\Temp\NewSample.txt", true);
                //MoveTo()
                copyFile.MoveTo(@"C:\Temp\NewMoveSample.txt");
                Console.WriteLine(copyFile.FullName);
                if (copyFile.Exists)
                {
                    Console.WriteLine("파일 복사 성공");
                    // Delete
                    copyFile.Delete();
                    Console.WriteLine("파일 삭제 성공");
                }
                else
                {
                    Console.WriteLine("복사된 파일이 없습니다.");
                }
            }
            else
            {
                Console.WriteLine("원본 파일이 없습니다.");
            }
        }
    }
}
