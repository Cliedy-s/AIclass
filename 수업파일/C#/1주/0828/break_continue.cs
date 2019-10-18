using System;

namespace Demo5th
{
	/// <summary>
	/// break문과 continue문에 대해서 알아보자.
	/// </summary>
	public class break_continue
	{
		[STAThread]
		static void Main(string[] args)
		{

			int i;

			//Case1.break 문 예제
			Console.WriteLine("**************** Case1.break 문 예제 *********************");
			Console.WriteLine("start!");

			for(i=1; i<20; i++)
			{
				if(i%2==0 || i%3==0)
					break;

				Console.WriteLine("{0}", i);
			}
			Console.WriteLine("end!\n");




			//Case2.continue 문 예제
			Console.WriteLine("************** Case2.continue 문 예제 ********************");
			Console.WriteLine("start!");

			for(i=1; i<20; i++)
			{
				if(i%2==0 || i%3==0)
					continue;

				Console.WriteLine("{0}", i);
			}
			Console.WriteLine("end!\n");
		}
	}
}
