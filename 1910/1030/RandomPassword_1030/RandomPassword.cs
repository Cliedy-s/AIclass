using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomPassword_1030
{
    public class RandomPassword
    {
        public string CreateNewPassword()
        {
            Random r = new Random();
            StringBuilder pwd = new StringBuilder();

            for (int i = 0; i < 8; i++)
            {
                int rndVal = r.Next(0, 36);
                if(rndVal < 10)
                {
                    pwd.Append(rndVal);
                }
                else
                {
                    pwd.Append((char)(rndVal + 55));
                }
            }
            return pwd.ToString();
        }
    }
}
