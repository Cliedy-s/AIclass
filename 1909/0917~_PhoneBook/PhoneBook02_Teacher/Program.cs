using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook02_Teacher
{
    class PhoneBook
    {
        static void Main(string[] args)
        {
            int choice;
            PhoneBookManager phoneBookManager = new PhoneBookManager();
            #region PhoneInfo 테스트용
            phoneBookManager.InfoStorage[0] = new PhoneInfo("aaa", "111");
            phoneBookManager.InfoStorage[1] = new PhoneInfo("bbb", "222"); // ?
            phoneBookManager[2] = new PhoneInfo("ccc", "333");
            phoneBookManager.CurCnt = 3;
            #endregion
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
                        phoneBookManager.SearchData();
                        break;
                    case 4:
                        phoneBookManager.DeleteData();
                        break;
                    case 5:
                        Console.WriteLine("프로그램을 종료합니다.");
                        return;
                }
            }
        }

    }
}
