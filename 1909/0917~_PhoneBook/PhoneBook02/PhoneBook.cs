using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook02
{
    class PhoneBook
    {

        static void Main(string[] args)
        {
            PhoneBookManager phoneBookManager = new PhoneBookManager();

            #region PhoneInfo 테스트용
            phoneBookManager.InfoStorate[0] = new PhoneInfo("aaa", "111", "111");
            phoneBookManager.InfoStorate[1] = new PhoneInfo("bbb", "222", "222"); // ?
            phoneBookManager[2] = new PhoneInfo("ccc", "333", "333");
            phoneBookManager.CurCnt = 3;
            #endregion

            int choice;
            while (true)
            {
                while (true)
                {
                    phoneBookManager.ShowMenu();
                    if (int.TryParse(Console.ReadLine(), out choice))
                        break;
                }
                switch (choice)
                {
                    case 1:
                        phoneBookManager.InputData();
                        break;
                    case 2:
                        phoneBookManager.ListData();
                        break;
                    case 3:
                        string name;
                        Console.Write("이름 : ");
                        name = Console.ReadLine();
                        phoneBookManager.SearchData(name);
                        break;
                    case 4:
                        phoneBookManager.DeleteData();
                        break;
                    case 5:
                        Console.WriteLine("프로그램을 종료합니다");
                        break;
                }
            }
        }
    }
}
