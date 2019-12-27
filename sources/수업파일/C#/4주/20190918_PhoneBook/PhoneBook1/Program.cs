using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook1
{
    class PhoneBook
    {
        const int MAX_CNT = 100;
        static PhoneInfo[] infoStorage = new PhoneInfo[MAX_CNT];
        static int curCnt = 0;
        
        static void Main(string[] args)
        {
            int choice;

            while (true)
            {
                while (true)
                {
                    showMenu();
                    if (int.TryParse(Console.ReadLine(), out choice))
                        break;
                }
                                
                switch (choice)
                {
                    case 1:
                        inputData();
                        break;
                    case 2:
                        listData();
                        break;
                    case 3:
                        searchData();
                        break;
                    case 4:
                        deleteData();
                        break;
                    case 5:
                        Console.WriteLine("프로그램을 종료합니다.");
                        return;
                }
            }
        }

        public static void showMenu()
        {
            Console.WriteLine("------------------------ 주소록 --------------------------");
            Console.WriteLine("1. 입력  |  2. 목록  |  3. 검색  |  4. 삭제  |  5. 종료");
            Console.WriteLine("-----------------------------------------------------------");
            Console.Write("선택: ");
        }

        public static void inputData()
        {
            Console.Write("이름: ");
            string name = Console.ReadLine();
            Console.Write("전화번호: ");
            string phone = Console.ReadLine();
            Console.Write("생년월일: ");
            string birth = Console.ReadLine();

            infoStorage[curCnt++] = new PhoneInfo(name, phone, birth);
            Console.WriteLine("주소록 데이터 입력이 완료되었습니다. \n");
        }

        public static void listData()
        {
            Console.WriteLine("*********************************************************************");
            for (int idx = 0; idx < curCnt; idx++)
            {
                PhoneInfo curInfo = infoStorage[idx];
                curInfo.showPhoneInfo();
            }
            Console.WriteLine("*********************************************************************");
        }

        public static void searchData()
        {
            Console.WriteLine("주소록 검색을 시작합니다..");

            Console.Write("이름: ");
            string name = Console.ReadLine();

            int dataIdx = searchName(name);
            if (dataIdx < 0)
            {
                Console.WriteLine("해당하는 데이터가 존재하지 않습니다. \n");
            }
            else
            {
                infoStorage[dataIdx].showPhoneInfo();
                Console.WriteLine("주소록 검색이 완료되었습니다. \n");
            }
        }

        private static int searchName(string name)
        {
            int search_idx = -1;
            for (int idx = 0; idx < curCnt; idx++)
            {
                PhoneInfo curInfo = infoStorage[idx];
                if (name.CompareTo(curInfo.Name) == 0)
                {
                    search_idx = idx;
                    break;
                }
            }
            return search_idx;
        }

        public static void deleteData()
        {
            Console.WriteLine("주소록 삭제를 시작합니다..");

            Console.Write("이름: ");
            string name = Console.ReadLine();

            int dataIdx = searchName(name);
            if (dataIdx < 0)
            {
                Console.WriteLine("해당하는 데이터가 존재하지 않습니다. \n");
            }
            else
            {
                for (int idx = dataIdx; idx < (curCnt - 1); idx++)
                    infoStorage[idx] = infoStorage[idx + 1];

                curCnt--;
                Console.WriteLine("주소록 삭제가 완료되었습니다. \n");
            }
        }
    }
}
