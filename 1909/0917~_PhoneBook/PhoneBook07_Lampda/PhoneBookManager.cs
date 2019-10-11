using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook04
{
    class PhoneBookManager
    {
        static PhoneBookManager phoneBookManager;
        const int MAX_CNT = 100;
        PhoneInfo[] infoStorate;
        int curCnt;

        internal PhoneInfo[] InfoStorage { get => infoStorate; set => infoStorate = value; }
        public int CurCnt { get => curCnt; set => curCnt = value; }

        private PhoneBookManager()
        {
            this.InfoStorage = new PhoneInfo[MAX_CNT];
            this.CurCnt = 0;
        }
        public static PhoneBookManager CreatePhoneBookManager() {
            if(phoneBookManager == null)
                phoneBookManager = new PhoneBookManager();
            return phoneBookManager;
        }

        #region PhoneInfo 테스트용 인덱서
        public PhoneInfo this[int index]
        {
            get { return InfoStorage[index]; }
            set { InfoStorage[index] = value; }
        }
        #endregion

        public void ShowMenu()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("-------------------------------주소록---------------------------------");
            Console.WriteLine("1. 입력 | 2. 목록 | 3. 검색 | 4. 정렬 | 5. 삭제 | 6. 종료");
            Console.WriteLine("------------------------------------------------------------------------");
            Console.Write("선택 : ");
        }
        // 1. 입력
        public void InputData()
        { 
            int choice;
            Console.WriteLine("1. 일반, 2. 대학, 3. 회사");
            while (true)
            {
                Console.Write("선택 >> ");
                if (int.TryParse(Console.ReadLine(), out choice))
                    break;
            }
            if (choice < 1 || choice > 3)
                throw new MenuChoiceException(choice);
            PhoneInfo phoneInfo = null;

            switch (choice)
            {
                case 1:
                    phoneInfo = readFriendInfo();
                    break;
                case 2:
                    phoneInfo = readUnivInfo();
                    break;
                case 3:
                    phoneInfo = readCompanyInfo();
                    break;
            }

            InfoStorage[CurCnt++] = phoneInfo; // InfoStorage의 빈칸(curCnt)에 넣어준다.
            Console.WriteLine("입력되었습니다.");
            // Max < curCnt => IndexOutOfException
        }
        // 2. 목록
        public void ListData()
        { 
            Console.WriteLine("-------------------------------목록출력---------------------------------");
            for (int i = 0; i < CurCnt; i++)
            {
                InfoStorage[i].ShowPhoneInfo(); // override됐으므로 ㄱㅊ
            }
            Console.WriteLine("------------------------------------------------------------------------");
        }
        // 3. 검색
        public void SearchData()
        { 
            string name;
            Console.Write("이름 : ");
            name = Console.ReadLine();
            int idx = SearchName(name);
            if (idx != -1)
            {
                InfoStorage[idx].ShowPhoneInfo();
            }
            else
            {
                Console.WriteLine("해당 사람은 주소록에 존재하지 않습니다.");
            }
        }
        // 4. 정렬
        public void SortData()
        {
            Console.WriteLine("정렬을 시작합니다.");
            int choice;
            Console.WriteLine("1. 이름 ASC, 2. 이름 DESC, 3. 번호 ASC, 4. 번호 DESC");
            while (true)
            {
                Console.Write("선택 >> ");
                if (int.TryParse(Console.ReadLine(), out choice))
                    break;
            }
            if (choice < 1 || choice > 4)
                throw new MenuChoiceException(choice);

            PhoneInfo[] sortArr = new PhoneInfo[CurCnt];
            Array.Copy(InfoStorage, sortArr, CurCnt);
            switch (choice)
            {
                case 1:
                    // Array.Sort(sortArr, PhoneInfo.CompareAscName);
                    Array.Sort(sortArr, (i1, i2) => i1.Name.CompareTo(i2.Name));
                    break;
                case 2:
                    // Array.Sort(sortArr);
                    // Array.Reverse(sortArr);
                    // Array.Sort(sortArr, new Comparison<PhoneInfo>((i1, i2) => i2.CompareTo(i1)));
                    // Array.Sort(sortArr, PhoneInfo.CompareDescName);
                    Array.Sort(sortArr, (i1, i2) => i2.Name.CompareTo(i1.Name));
                    break;
                case 3:
                    //Array.Sort(sortArr, new PhoneComparator());
                    // Array.Sort(sortArr, PhoneInfo.CompareAscPhonenumber);
                    Array.Sort(sortArr, (i1, i2) => i1.PhoneNumber.CompareTo(i2.PhoneNumber));
                    break;
                case 4:
                    //Array.Sort(sortArr, new PhoneComparator());
                    //Array.Reverse(sortArr);
                    // Array.Sort(sortArr, PhoneInfo.CompareDescPhonenumber);
                    Array.Sort(sortArr, (i1, i2) => i2.PhoneNumber.CompareTo(i1.PhoneNumber));
                    break;
            }
            foreach (var curInfo in sortArr)
            {
                Console.WriteLine(curInfo.ToString());
            }
        }
        // 5. 삭제
        public void DeleteData()
        { 
            string name;
            Console.Write("이름 : ");
            name = Console.ReadLine();
            int idx = SearchName(name);
            if (idx != -1)
            {
                for (int i = idx; i < curCnt - 1; i++)
                {
                    InfoStorage[i] = InfoStorage[i + 1]; // 값을 덮어써준다.
                }
                CurCnt--; // 한 칸씩 땡겼으므로 cnt도 줄여준다.
            }
            else
            {
                Console.WriteLine("해당 사람은 주소록에 존재하지 않습니다.");
            }
        }
        public int SearchName(string name)
        {
            for (int i = 0; i < CurCnt; i++)
            {
                if (InfoStorage[i].Name == name)
                    return i;
            }
            return -1;
        }
        public PhoneInfo readFriendInfo()
        {
            Console.Write("이름 : ");
            string name = Console.ReadLine();
            Console.Write("번호 : ");
            string phoneNumber = Console.ReadLine();

            return new PhoneInfo(name, phoneNumber);
        }
        public PhoneInfo readUnivInfo()
        {
            Console.Write("이름 : ");
            string name = Console.ReadLine();
            Console.Write("번호 : ");
            string phoneNumber = Console.ReadLine();
            Console.Write("전공 : ");
            string major = Console.ReadLine();
            int year;
            while (true)
            {
                Console.Write("학년 : ");
                if (int.TryParse(Console.ReadLine(), out year))
                    break;
            }

            return new PhoneUnivInfo(name, phoneNumber, major, year);
        }
        public PhoneInfo readCompanyInfo()
        {
            Console.Write("이름 : ");
            string name = Console.ReadLine();
            Console.Write("번호 : ");
            string phoneNumber = Console.ReadLine();
            Console.Write("회사 : ");
            string company = Console.ReadLine();

            return new PhoneCompanyInfo(name, phoneNumber, company);
        }
    }
}
