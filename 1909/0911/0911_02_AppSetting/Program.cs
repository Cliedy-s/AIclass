using System;
using System.Diagnostics;

namespace _0911_02_AppSettingAndDebug
{
    class Program
    {
        static void Main(string[] args)
        {
            /*          
                        // appSetting
                        string txt = ConfigurationSettings.AppSettings["AdminEmailAddress"];
                        string txt2 = ConfigurationManager.AppSettings["AdminEmailAddress"];
                        Console.WriteLine(txt);

                        txt = ConfigurationSettings.AppSettings["Delay"];
                        txt2 = ConfigurationManager.AppSettings["Delay"];
                        int delay = int.Parse(txt);
                        Console.WriteLine(delay);
            */
            /*
                        // Debug
                        int[] nArray = new int[] { 0, 1, 2, 3, 4 };
                        AccessArray(nArray);
                        nArray[3] = 0;
                        int k = nArray[3];

                        Debug.WriteLine("MYC :: Debug.WriteLine");
                        Trace.WriteLine("MYC :: Trace Print");
                        Debug.WriteLine("Debug.WriteLine");
                        Trace.WriteLine("Trace Print");

                        Console.ReadLine();
            */
        }
        /*
                static void AccessArray(int[] arr)
                {
                    arr[2] = 0;
                }
        */
    }
}
