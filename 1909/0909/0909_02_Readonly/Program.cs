using System;

namespace _0909_02_Readonly
{
    class MyDate
    {
        int yyyy;
        int mm;
        readonly int dd;
        const int Baseyy = 1970;

        public MyDate(int yyyy)
        {
            this.yyyy = yyyy;
            this.dd = 1;
        }

        // public int Month { get => mm; } // 읽기 전용 속성
        public int Month { get => mm; set => mm = value; }

        public void Print()
        {
            // Baseyy = 2020; // const 오류
            // this.dd = 5; // readonly 오류
            Console.WriteLine("{0}년 {1}월 {2}일", yyyy, Month, dd);
        }
    }

    [Flags]
    enum Days { Monday = 1, Tuesday = 2, Wednesday = 4, Thursday = 8, Friday = 16 }
    class Program
    {
        static void Main(string[] args)
        {
            Days workingday = Days.Monday | Days.Tuesday | Days.Wednesday | Days.Thursday;

            Console.WriteLine(workingday);

            MyDate d1 = new MyDate(2020);
            d1.Month = 10;
            d1.Print();
        }
    }
}
