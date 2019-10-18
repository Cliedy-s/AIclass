using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook2
{
    public class PhoneBookManager
    {
        const int MAX_CNT = 100;
        PhoneInfo[] infoStorage = new PhoneInfo[MAX_CNT];
        int curCnt = 0;

        public void showMenu()
        {
            Console.WriteLine("------------------------ 주소록 --------------------------");
            Console.WriteLine("1. 입력  |  2. 목록  |  3. 검색  |  4. 삭제  |  5. 종료");
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("선택: ");
        }

        public void inputData()
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

        public void listData()
        {
            Console.WriteLine("*********************************************************************");
            for (int idx = 0; idx < curCnt; idx++)
            {
                PhoneInfo curInfo = infoStorage[idx];
                curInfo.showPhoneInfo();
            }
            Console.WriteLine("*********************************************************************");
        }

        public void searchData()
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

        private int searchName(string name)
        {
            for (int idx = 0; idx < curCnt; idx++)
            {
                PhoneInfo curInfo = infoStorage[idx];
                if (name.CompareTo(curInfo.Name) == 0)
                    return idx;
            }
            return -1;
        }

        public void deleteData()
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
