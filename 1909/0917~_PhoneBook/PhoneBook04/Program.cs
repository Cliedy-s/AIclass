using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook04
{
    class PhoneBook
    {
        static void Main(string[] args)
        {
            int choice;
            PhoneBookManager phoneBookManager = PhoneBookManager.CreatePhoneBookManager();
            #region PhoneInfo 테스트용
            phoneBookManager.InfoStorage[0] = new PhoneInfo("bbb", "222"); // ?
            phoneBookManager[1] = new PhoneInfo("ccc", "333");
            phoneBookManager.InfoStorage[2] = new PhoneInfo("aaa", "111");
            phoneBookManager.CurCnt = 3;
            #endregion
            while (true)
            {
                try // try는 메인에서 하나만 둬라
                {
                    while (true)
                    {
                        phoneBookManager.ShowMenu();
                        if (int.TryParse(Console.ReadLine(), out choice))
                            break;
                    }
                    if (choice < 1 || choice > 5)
                        throw new MenuChoiceException(choice);

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
                            phoneBookManager.SortData();
                            break;
                        case 5:
                            phoneBookManager.DeleteData();
                            break;
                        case 6:
                            Console.WriteLine("프로그램을 종료합니다.");
                            System.Environment.Exit(0);
                            return;
                    }
                }
                catch(MenuChoiceException menuerr)
                {
                    menuerr.showWrongChoice();
                    Console.WriteLine(menuerr.Message);
                }
                catch (Exception err)
                {
                    Console.WriteLine(err.Message);
                }
            }
        }

    }
}
