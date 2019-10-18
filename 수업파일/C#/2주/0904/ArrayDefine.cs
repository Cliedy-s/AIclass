using System;

namespace Demo8th
{
	/// <summary>
	/// 배열 선언에 대해서 알아보자.
	/// </summary>
	class ArrayDefine
	{
		[STAThread]
		static void Main(string[] args)
		{
			//배열의 선언과 초기화방법
			int[] array_1 = {1,2,3,4,5};
			int[,] array_2 = { 
								{ 1,2,3,4}, {5,6,7,8}, {9,10,11,12}			
							 };
			Console.WriteLine("{0}, {1}", array_2.Length, array_2.Rank);

			//int [] arr = new int[2] {0}; 컴파일오류
			
			Console.WriteLine();

			//1차배열
			char [] array1 = new char[2];
		
			array1[0] = 'A';
			array1[1] = '가';
		
			Console.WriteLine("array1[0]={0}",array1[0]);
			Console.WriteLine("array1[1]={0}",array1[1]);

			//1차배열의 경우 요소에 접근하는 방법 
			for(int i=0; i< array1.Length ;++i) 
			{
				Console.WriteLine(array1[i]);
			}

			Console.WriteLine();
		
			
			//2차배열
			int [,] array2 = new int[2,3] { {1,2,3}, {4,5,6}};		

			for(int i=0;i<2;i++)
				for(int j=0;j<3;j++)
					Console.WriteLine(array2[i,j]);
			
			Console.WriteLine();

			//2차배열의 경우 요소에 접근하는 방법
			for(int i=0;i<array2.GetLength(0);++i) 
			{
				for(int j=0;j<array2.GetLength(1);++j) 
				{
					Console.WriteLine(array2[i,j]);
				}
			}
			
			Console.WriteLine();
			
			foreach(int t in array2) 
			{
				Console.WriteLine(t);
			}
		}
	}
}
