using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook02_Teacher
{
    class PhoneBookManager
    {
        const int MAX_CNT = 100;
        PhoneInfo[] infoStorate;
        int curCnt;

        internal PhoneInfo[] InfoStorage { get => infoStorate; set => infoStorate = value; }
        public int CurCnt { get => curCnt; set => curCnt = value; }

        public PhoneBookManager()
        {
            this.InfoStorage = new PhoneInfo[MAX_CNT];
            this.CurCnt = 0;
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
            Console.WriteLine("1. 입력 | 2. 목록 | 3. 검색 | 4. 삭제 | 5. 종료");
            Console.WriteLine("------------------------------------------------------------------------");
            Console.Write("선택 : ");
        }
        public void InputData()
        { // 1. 입력
            int choice;
            Console.WriteLine("1. 일반, 2. 대학, 3. 회사");
            while (true)
            {
                Console.Write("선택 >> ");
                if (int.TryParse(Console.ReadLine(), out choice))
                    break;
            }
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
        public void ListData()
        { // 2. 목록
            Console.WriteLine("-------------------------------목록출력---------------------------------");
            for (int i = 0; i < CurCnt; i++)
            {
                InfoStorage[i].ShowPhoneInfo(); // override됐으므로 ㄱㅊ
            }
            Console.WriteLine("------------------------------------------------------------------------");
        }
        public void SearchData()
        { // 3. 검색
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
        public void DeleteData()
        { // 4. 삭제
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
