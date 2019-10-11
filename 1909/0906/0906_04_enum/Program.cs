using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0906_04_enum
{
    public class BroadCastC { }
    public struct BroadCastS { }
    public interface BroadCaseI { }
    public enum BroadCast { SBS=6, KBS=11, MBC=20 }
    public enum Color {
        /// <summary>
        /// Red = 'R'
        /// Green='G'
        /// Blue='B'
        /// </summary>
        Red ='R', Green='G', Blue='B' }
    class EnumProgram
    {
        static void Main(string[] args)
        {
            BroadCast channel = BroadCast.SBS;
            Console.WriteLine((int)channel);
            Console.WriteLine(channel);

            Color palette = Color.Red;
            Color palette2 = Color.Blue;
            Console.WriteLine((char)palette);
            Console.WriteLine(Color.Green);
        }
    }
}
