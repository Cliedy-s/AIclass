using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook01
{
    class PhoneBook
    {
        const int MAX_CNT = 100;
        static PhoneInfo[] infoStorate = new PhoneInfo[MAX_CNT];
        static int curCnt = 0;

        static void Main(string[] args)
        {
            #region temp
            infoStorate[0] = new PhoneInfo("aaa", "111", "111");
            infoStorate[1] = new PhoneInfo("bbb", "222", "222");
            infoStorate[2] = new PhoneInfo("ccc", "333", "333");
            curCnt = 3;
            #endregion

            int choice;
            while (true)
            {
                while (true)
                {
                    ShowMenu();
                    if (int.TryParse(Console.ReadLine(), out choice))
                        break;
                }
                switch (choice)
                {
                    case 1:
                        InputData();
                        break;
                    case 2:
                        ListData();
                        break;
                    case 3:
                        string name;
                        Console.Write("이름 : ");
                        name = Console.ReadLine();
                        SearchData(name);
                        break;
                    case 4:
                        DeleteData();
                        break;
                    case 5:
                        Console.WriteLine("프로그램을 종료합니다");
                        break;
                }
            }
        }
        public static void ShowMenu()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("-------------------------------주소록---------------------------------");
            Console.WriteLine("1. 입력 | 2. 목록 | 3. 검색 | 4. 삭제 | 5. 종료");
            Console.WriteLine("------------------------------------------------------------------------");
            Console.Write("선택 : ");
        }
        public static void InputData()
        { // 1. 입력
            string name, phoneNumber, birth;

            Console.Write("이름 : ");
            name = Console.ReadLine();
            Console.Write("번호 : ");
            phoneNumber = Console.ReadLine();
            Console.Write("생일 : ");
            birth = Console.ReadLine();
            infoStorate[curCnt] = new PhoneInfo(name, phoneNumber, birth); // InfoStorage의 빈칸(curCnt)에 넣어준다.
            Console.WriteLine("입력되었습니다.");
            curCnt++;
        }
        public static void ListData()
        { // 2. 목록
            Console.WriteLine("-------------------------------목록출력---------------------------------");
            for (int i = 0; i < curCnt; i++)
            {
                infoStorate[i].ShowPhoneInfo();
            }
            Console.WriteLine("------------------------------------------------------------------------");
        }
        public static void SearchData(string name)
        { // 3. 검색
            int i = 0;
            for (; i < curCnt; i++)
            {
                if (infoStorate[i].Name == name)
                {
                    infoStorate[i].ShowPhoneInfo();
                    break;
                }
            }
            if (i == curCnt)
                Console.WriteLine("해당 사람은 주소록에 존재하지 않습니다.");
        }
        public static void DeleteData()
        { // 4. 삭제
            string name;
            Console.Write("이름 : ");
            name = Console.ReadLine();
            int i = 0;
            for (; i < curCnt; i++)
            {
                if (infoStorate[i].Name == name) // 배열에 값이 존재하면
                {
                    infoStorate[i] = null; // 해당 값을 지워줌
                    for (int j = i; j < infoStorate.Length-1; j++) // 값이 빔으로써 생기는 빈 공간을 없애준다.
                    {
                        infoStorate[j] = infoStorate[j + 1];
                    }
                    infoStorate[infoStorate.Length - 1] = null;
                    i--; // 존재할 경우 curCnt값을 -1해줬기 때문에 i도 -1해줌
                    curCnt--; // 한 칸씩 땡겼으므로 cnt도 줄여준다.
                    break;
                }
            }
            if (i == curCnt)
                Console.WriteLine("해당 사람은 주소록에 존재하지 않습니다.");
        }
    }

}
