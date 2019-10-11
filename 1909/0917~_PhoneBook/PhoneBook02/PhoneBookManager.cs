using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook02
{
    class PhoneBookManager
    {
        const int MAX_CNT = 100;
        PhoneInfo[] infoStorate;
        int curCnt;

        internal PhoneInfo[] InfoStorate { get => infoStorate; set => infoStorate = value; }
        public int CurCnt { get => curCnt; set => curCnt = value; }

        public PhoneBookManager()
        {
            this.InfoStorate = new PhoneInfo[MAX_CNT];
            this.CurCnt = 0;
        }

        #region PhoneInfo 테스트용 인덱서
        public PhoneInfo this[int index]{
            get { return InfoStorate[index]; }
            set { InfoStorate[index] = value; }
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
            Console.Write("이름 : ");
            string name = Console.ReadLine();
            Console.Write("번호 : ");
            string phoneNumber = Console.ReadLine();
            Console.Write("생일 : ");
            string birth = Console.ReadLine();

            InfoStorate[CurCnt++] = new PhoneInfo(name, phoneNumber, birth); // InfoStorage의 빈칸(curCnt)에 넣어준다.
            Console.WriteLine("입력되었습니다.");
            // Max < curCnt => IndexOutOfException
        }
        public void ListData()
        { // 2. 목록
            Console.WriteLine("-------------------------------목록출력---------------------------------");
            for (int i = 0; i < CurCnt; i++)
            {
                InfoStorate[i].ShowPhoneInfo();
            }
            Console.WriteLine("------------------------------------------------------------------------");
        }
        public void SearchData(string name)
        { // 3. 검색
            int i = 0;
            for (; i < CurCnt; i++)
            {
                if (InfoStorate[i].Name == name)
                {
                    InfoStorate[i].ShowPhoneInfo();
                    break;
                }
            }
            if (i == CurCnt)
                Console.WriteLine("해당 사람은 주소록에 존재하지 않습니다.");
        }
        public void DeleteData()
        { // 4. 삭제
            string name;
            Console.Write("이름 : ");
            name = Console.ReadLine();
            int i = 0;
            for (; i < CurCnt; i++)
            {
                if (InfoStorate[i].Name == name) // 배열에 값이 존재하면
                {
                    for (int j = i; j < curCnt - 1; j++) 
                    {
                        InfoStorate[j] = InfoStorate[j + 1]; // 값을 덮어써준다.
                    }
                    i--; // 존재할 경우 curCnt값을 -1해줬기 때문에 i도 -1해줌
                    CurCnt--; // 한 칸씩 땡겼으므로 cnt도 줄여준다.
                    break;
                }
            }
            if (i == CurCnt)
                Console.WriteLine("해당 사람은 주소록에 존재하지 않습니다.");
        }
    }
}

