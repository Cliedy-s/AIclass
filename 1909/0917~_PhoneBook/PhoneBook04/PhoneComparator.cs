using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook04
{
    class PhoneComparator : IComparer<PhoneInfo>
    {
        public int Compare(PhoneInfo x, PhoneInfo y)
        {
            return x.PhoneNumber.CompareTo(y.PhoneNumber);
         }
    }
}
