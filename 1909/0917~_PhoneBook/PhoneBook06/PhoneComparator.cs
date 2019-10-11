using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook6
{
    /// <summary>
    /// 다른 속성으로 정렬하고 싶을 때 사용
    /// 
    /// </summary>
    class PhoneComparator : IComparer<PhoneInfo>
    {
        public int Compare(PhoneInfo x, PhoneInfo y)
        {
            string phone1 = x.PhoneNumber;
            string phone2 = y.PhoneNumber;

            return phone1.CompareTo(phone2);
        }
    }
}
