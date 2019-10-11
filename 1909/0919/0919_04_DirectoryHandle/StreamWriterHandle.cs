using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0919_04_DirectoryHandle
{
    class StreamWriterHandle
    {
        static void Main()
        {
            #region write
            //???????????????????????????????????????????????????????????????????????????

            FileStream fs = new FileStream(@"C:\Temp\SampleWrite.txt", FileMode.Append);

            StreamWriter streamWriter = new StreamWriter(fs);
            streamWriter.WriteLine("안녕하세요 후훗");
            streamWriter.Close();

            streamWriter = new StreamWriter(@"C:\Temp\SampleWrite.txt", true, Encoding.UTF7);
            streamWriter.WriteLine("안녕하세요 후훗");
            streamWriter.Close();

            streamWriter = new StreamWriter(@"C:\Temp\SampleWrite.txt", true, Encoding.ASCII);
            streamWriter.WriteLine("안녕하세요 후훗");
            streamWriter.Close();

            streamWriter = new StreamWriter(@"C:\Temp\SampleWrite.txt", true, Encoding.Default);
            streamWriter.WriteLine("안녕하세요 후훗");
            streamWriter.Close();

            streamWriter = new StreamWriter(@"C:\Temp\SampleWrite.txt", true, Encoding.UTF32);
            streamWriter.WriteLine("안녕하세요 후훗");
            streamWriter.Close();

            streamWriter = new StreamWriter(@"C:\Temp\SampleWrite.txt", true, Encoding.Unicode);
            streamWriter.WriteLine("안녕하세요 후훗");
            streamWriter.Close();
            #endregion

            StreamReader sr = new StreamReader(@"C:\Temp\SampleWrite.txt", Encoding.ASCII);
            string str = sr.ReadToEnd();
            Console.WriteLine(str);
            sr.Close();

            sr = new StreamReader(@"C:\Temp\SampleWrite.txt", Encoding.ASCII);
            str = sr.ReadToEnd();
            Console.WriteLine(str);
            sr.Close();
        }
    }
}
