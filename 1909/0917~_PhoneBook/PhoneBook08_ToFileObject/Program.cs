using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook6
{
    enum PhoneMenu
    {
        INPUT = 1, LIST = 2, SEARCH = 3, SORT = 4, DELETE = 5, EXIT = 6
    }

    class Program
    {
        static void Main(string[] args)
        {
            PhoneBookManager manager = PhoneBookManager.createManagerInstance();
            int choice;

            #region SavePhoneBookInfosToArr
            while (true)
            {
                try
                {
                    while (true)
                    {
                        manager.showMenu();
                        if (int.TryParse(Console.ReadLine(), out choice))
                            break;
                    }

                    if (choice < 1 || choice > 7)
                        throw new MenuChoiceException(choice);

                    switch (choice)
                    {
                        case 1:
                            manager.inputData();
                            break;
                        case 2:
                            manager.listData();
                            break;
                        case 3:
                            manager.searchData();
                            break;
                        case 4:
                            manager.sortData();
                            break;
                        case 5:
                            manager.deleteData();
                            break;
                        case 6:
                            manager.saveDate();
                            Console.WriteLine("프로그램을 종료합니다.");
                            return;
                        case 7:
                            manager.testData();
                            break;
                    }
                }
                catch (MenuChoiceException err)
                {
                    err.showWrongChoice();
                    Console.WriteLine("메뉴 선택을 처음부터 다시 진행합니다.\n");
                }
            }
        #endregion
        }
    }
}
