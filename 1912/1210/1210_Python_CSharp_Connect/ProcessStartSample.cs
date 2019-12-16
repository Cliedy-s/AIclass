using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1210_Python_CSharp_Connect
{
    class ProcessStartSample
    {
        static void Main(string[] args)
        {
            //프로세스 파일명 정의
            //파이썬 exe를 직접 실행해서 파이썬 코드가 실행되도록 한다.
            var psi = new ProcessStartInfo();
            psi.FileName = @"C:\ProgramData\Anaconda3\python.exe"; //파이썬 설치 경로
            psi.Arguments = $"\"C:\\Users\\Administrator\\Desktop\\1210\\WithPython\\WithPython\\bin\\Debug\\test.py\"";//파일경로

            //3) Proecss configuration
            psi.UseShellExecute = false;
            psi.CreateNoWindow = true;
            psi.RedirectStandardOutput = true;
            psi.RedirectStandardError = true;

            //4) return value def
            var erros = "";
            var results = "";

            using (var process = Process.Start(psi))
            {
                erros = process.StandardError.ReadToEnd();
                results = process.StandardOutput.ReadToEnd();
            }

            Console.WriteLine(erros);
            Console.WriteLine(results);

        }
    }
}
