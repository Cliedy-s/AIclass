using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook2
{
    class PhoneBook
    {
        static void Main(string[] args)
        {
            PhoneBookManager manager = new PhoneBookManager();
            int choice;

            while (true)
            {
                while (true)
                {
                    manager.showMenu();
                    if (int.TryParse(Console.ReadLine(), out choice))
                        break;
                }

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
                        manager.deleteData();
                        break;
                    case 5:
                        Console.WriteLine("프로그램을 종료합니다.");
                        return;
                }
            }
        }
    }
}
