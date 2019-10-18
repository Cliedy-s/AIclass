using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook6
{
    public class PhoneBookManager
    {
        //const int MAX_CNT = 100;
        //PhoneInfo[] infoStorage = new PhoneInfo[MAX_CNT];
        //int curCnt = 0;
        HashSet<PhoneInfo> infoStorage = new HashSet<PhoneInfo>();

        static PhoneBookManager inst = null;
        public static PhoneBookManager createManagerInstance()
        {
            if (inst == null)
                inst = new PhoneBookManager();

            return inst;
        }

        private PhoneBookManager() { }

        public void showMenu()
        {
            Console.WriteLine("------------------------ 주소록 --------------------------");
            Console.WriteLine("1. 입력  |  2. 목록  |  3. 검색  |  4. 정렬   |  5. 삭제  |  6. 종료");
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("선택: ");
        }

        public void inputData()
        {
            int choice;
            Console.WriteLine("데이터 입력을 시작합니다..");
            Console.WriteLine("1. 일반, 2. 대학, 3. 회사");
            Console.Write("선택>> ");
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out choice))
                    break;
            }

            if (choice < 1 || choice > 3)
                throw new MenuChoiceException(choice);

            PhoneInfo info = null;
            switch (choice)
            {
                case 1:
                    info = readFriendInfo();
                    break;
                case 2:
                    info = readUnivFriendInfo();
                    break;
                case 3:
                    info = readCompanyFriendInfo();
                    break;
            }

            //infoStorage[curCnt++] = info;
            //Console.WriteLine("데이터 입력이 완료되었습니다. \n");

            bool isAdded = infoStorage.Add(info);
            if (isAdded == true)
                Console.WriteLine("데이터 입력이 완료되었습니다. \n");
            else
                Console.WriteLine("이미 저장된 데이터입니다. \n");
        }

        public void testData()
        {
            HashSet<PhoneInfo> h2 = new HashSet<PhoneInfo>();
            h2.Add(new PhoneInfo("aaa", "111"));
            h2.Add(new PhoneInfo("aaa", "111"));
            h2.Add(new PhoneInfo("aaa", "111"));
            int cnt = h2.Count;
        }

        private PhoneInfo readFriendInfo()
        {
            Console.Write("이름: ");
            String name = Console.ReadLine();
            Console.Write("전화번호: ");
            String phone = Console.ReadLine();
            return new PhoneInfo(name, phone);
        }

        private PhoneInfo readUnivFriendInfo()
        {
            Console.Write("이름: ");
            String name = Console.ReadLine();
            Console.Write("전화번호: ");
            String phone = Console.ReadLine();
            Console.Write("전공: ");
            String major = Console.ReadLine();
            Console.Write("학년: ");
            int year;
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out year))
                    break;
            }
            return new PhoneUnivInfo(name, phone, major, year);
        }

        private PhoneInfo readCompanyFriendInfo()
        {
            Console.Write("이름: ");
            String name = Console.ReadLine();
            Console.Write("전화번호: ");
            String phone = Console.ReadLine();
            Console.Write("회사: ");
            String company = Console.ReadLine();
            return new PhoneCompanyInfo(name, phone, company);
        }


        public void listData()
        {
            Console.WriteLine("*********************************************************************");
            //for (int idx = 0; idx < curCnt; idx++)
            //{
            //    PhoneInfo curInfo = infoStorage[idx];
            //    curInfo.showPhoneInfo();
            //}

            foreach (var curInfo in infoStorage)
            {
                curInfo.showPhoneInfo();
            }
            Console.WriteLine("*********************************************************************");
        }

        public void searchData()
        {
            Console.WriteLine("주소록 검색을 시작합니다..");

            Console.Write("이름: ");
            string name = Console.ReadLine();

            //int dataIdx = searchName(name);
            //if (dataIdx < 0)
            //{
            //    Console.WriteLine("해당하는 데이터가 존재하지 않습니다. \n");
            //}
            //else
            //{
            //    infoStorage[dataIdx].showPhoneInfo();
            //    Console.WriteLine("주소록 검색이 완료되었습니다. \n");
            //}

            PhoneInfo info = searchName(name);

            if (info == null)
            {
                Console.WriteLine("해당하는 데이터가 존재하지 않습니다. \n");
            }
            else
            {
                info.showPhoneInfo();
                Console.WriteLine("데이터 검색이 완료되었습니다. \n");
            }
        }

        private PhoneInfo searchName(String name)
        {
            foreach (var curInfo in infoStorage)
            {
                if (name.CompareTo(curInfo.Name) == 0)
                    return curInfo;
            }
            return null;
        }

        //private int searchName(string name)
        //{
        //    for (int idx = 0; idx < curCnt; idx++)
        //    {
        //        PhoneInfo curInfo = infoStorage[idx];
        //        if (name.CompareTo(curInfo.Name) == 0)
        //            return idx;
        //    }
        //    return -1;
        //}

        public void deleteData()
        {
            Console.WriteLine("주소록 삭제를 시작합니다..");

            Console.Write("이름: ");
            string name = Console.ReadLine();

            bool bFlag = false;
            foreach (var curInfo in infoStorage)
            {
                if (name.CompareTo(curInfo.Name) == 0)
                {
                    infoStorage.Remove(curInfo);
                    bFlag = true;
                    Console.WriteLine("주소록 삭제가 완료되었습니다. \n");
                    break;
                }
            }
            if (!bFlag)
            {
                Console.WriteLine("해당하는 데이터가 존재하지 않습니다. \n");
            }

            //int dataIdx = searchName(name);
            //if (dataIdx < 0)
            //{
            //    Console.WriteLine("해당하는 데이터가 존재하지 않습니다. \n");
            //}
            //else
            //{
            //    for (int idx = dataIdx; idx < (curCnt - 1); idx++)
            //        infoStorage[idx] = infoStorage[idx + 1];

            //    curCnt--;
            //    Console.WriteLine("주소록 삭제가 완료되었습니다. \n");
            //}
        }

        public void sortData()
        {
            Console.WriteLine("데이터 정렬을 시작합니다..");
		    Console.WriteLine("1.이름 ASC, 2.이름 DESC, 3.핸드폰번호 ASC, 4.핸드폰번호 DESC ");
            Console.Write("선택>> ");
            int choice;
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out choice))
                    break;
            }

            if (choice < 1 || choice > 4)
			    throw new MenuChoiceException(choice);

            //PhoneInfo[] new_arr = new PhoneInfo[curCnt];
            //Array.Copy(infoStorage, new_arr, curCnt);		
            List<PhoneInfo> list = new List<PhoneInfo>(infoStorage);

            if (choice == 1) {
                list.Sort();
		    } 
		    else if (choice == 2) {
                list.Sort();
                list.Reverse();
                //list.Sort(new Comparison<PhoneInfo>(
                //            (i1, i2) => i2.CompareTo(i1)
                //    ));
            }
		    else if (choice == 3) {
                list.Sort(new PhoneComparator());
		    }
		    else {
                list.Sort(new PhoneComparator());
                list.Reverse();
            }
		
		    foreach (PhoneInfo curInfo in list) {
			    Console.WriteLine(curInfo.ToString());
		    }
		
		    Console.WriteLine("데이터 정렬이 완료되었습니다. \n");		
	    }
    }
}
