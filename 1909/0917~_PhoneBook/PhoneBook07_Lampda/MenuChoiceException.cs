using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook04
{
    class MenuChoiceException : Exception
    {
        int wrongChoice;
        public MenuChoiceException() : base() { }
        public MenuChoiceException(string Message) : base(Message) { }
        public MenuChoiceException(int choice) : base("메뉴를 다시 선택해 주세요")
        {
            this.wrongChoice = choice;
        }
        public void showWrongChoice()
        {
            Console.WriteLine(wrongChoice + "에 해당하는 메뉴는 존재하지 않습니다.");
        }
    }
}
