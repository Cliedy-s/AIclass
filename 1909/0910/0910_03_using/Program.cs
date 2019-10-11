using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _0910_03_using
{
    class Program
    {
        [DllImport("user32.dll")]
        static extern int MessageBeep(uint uType); // MessageBeep => 해당 dll의 함수와 같아야함!!!!!!!!!!!!!!!!!!!!!!!!!!!!
   
        static void Main(string[] args)
        {
            System.Windows.Forms.MessageBox.Show("aa");
            MessageBeep(5);
        }
   
        unsafe static void GetAddResult(int* p, int a, int b)
        {
            *p = a + b;
        }
    }
}
