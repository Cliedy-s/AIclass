using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0904_01_준비운동
{
    public class Time
    {
        private int hours;
        private int minutes;

        public Time(int minutes) : this(0, minutes) { }
        public Time(int hours, int minutes)
        {
            //초기화
            this.hours = hours;
            this.minutes = minutes;

            //hours와 minutes를 검증
            Examine();
        }

        private void Examine()
        {
            //hours와 minutes가 음수이면 예외 발생
            if (this.hours < 0 || this.minutes < 0)
                throw new Exception("올바르지 않은 인자입니다");

            //hours와 minutes가 범위가 넘어가는 경우를 대비해
            //재계산
            hours = hours + (minutes / 60);
            minutes = minutes % 60;

        }

        //총 분수를 반환
        private int TotalMinutes()
        {
            return hours * 60 + minutes;
        }

        //ToString 오버라이드. 시:분 식으로 출력
        public override string ToString()
        {
            return hours + ":" + minutes;
        }

        //관계 연산자 오버로딩
        public static bool operator ==(Time leftTime, Time rightTime)
        {
            return Compare(leftTime, rightTime) == 0;
        }

        public static bool operator !=(Time leftTime, Time rightTime)
        {
            return Compare(leftTime, rightTime) != 0;
        }

        public static bool operator <(Time leftTime, Time rightTime)
        {
            return Compare(leftTime, rightTime) < 0;
        }

        public static bool operator >(Time leftTime, Time rightTime)
        {
            return Compare(leftTime, rightTime) > 0;
        }

        public static bool operator <=(Time leftTime, Time rightTime)
        {
            return Compare(leftTime, rightTime) <= 0;
        }

        public static bool operator >=(Time leftTime, Time rightTime)
        {
            return Compare(leftTime, rightTime) >= 0;
        }

        //Equals 메소드 오버라이딩
        public override bool Equals(object o)
        {
            return (o is Time) && (Compare(this, (Time)o) == 0);
        }

        //Equals 메소드 오버라이딩 시 GetHashCode도 같이 오버라이딩
        public override int GetHashCode()
        {
            return TotalMinutes();
        }

        //객체들을 비교하는 Comapre 메소드
        private static int Compare(Time leftTime, Time rightTime)
        {
            int l = leftTime.TotalMinutes();
            int r = rightTime.TotalMinutes();

            if (l < r)
                return -1;
            else if (l > r)
                return 1;
            else
                return 0;
        }

        //++연산자 오버로딩
        public static Time operator ++(Time t)
        {
            return new Time(t.TotalMinutes() + 1);
        }

        //+연산자 오버로딩
        public static Time operator +(Time t1, Time t2)
        {
            return new Time(t1.TotalMinutes() + t2.TotalMinutes());
        }
        //논리 연산자 오버로딩
        public static bool operator true(Time t)
        {
            return t.IsAfterNoon(); // 오후 => true
        }

        public static bool operator false(Time t)
        {
            return !t.IsAfterNoon(); // 오전 => true
        }

        public static Time operator &(Time leftTime, Time rightTime)
        {
            if (rightTime.IsAfterNoon()) // rightTIme -> AfterNoon => return left
                return leftTime;
            else
                return new Time(0);
        }

        public static Time operator |(Time leftTime, Time rightTime)
        {
            if (rightTime.IsAfterNoon()) // rightTIme -> AfterNoon => return right
                return rightTime;
            else
                return new Time(0);
        }

        private bool IsAfterNoon()
        {
            return (hours >= 12) ? true : false;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Time 클래스를 정의한다.
            //int hours와 int minutes를 멤버로 갖는다.
            //생성자(hour, minutes)

            Time t1 = new Time(10, 20);
            Time t2 = new Time(10, 20);
            Console.WriteLine(t1.ToString());        //10:20

            Console.WriteLine("t1 == t2 -> {0}", t1 == t2);  //True
            Console.WriteLine("t1.Equals(t2) -> {0}", t1.Equals(t2));   //True

            Console.WriteLine(t1++);
            Console.WriteLine(++t2);

            Time t3 = new Time(1, 50);
            Time t4 = t1 + t3;
            Console.WriteLine(t4);

        }
    }
}
