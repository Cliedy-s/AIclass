using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1128_01_MessengerServer
{
    public class UserInfoList
    {
        private static Hashtable clientTable;
        private static Dictionary<string, User> clientobject;
        public UserInfoList()
        {
            clientTable = new Hashtable();
        }
        public static bool AddClient(string username, string usergid, User user)
        {
            if (clientTable.ContainsValue(username))
                return false;

            clientTable.Add(usergid, username);
            clientobject.Add(usergid, user);
            return true;
        }
        public static string GetAllUsers()
        {
            StringBuilder users = new StringBuilder();
            //foreach (KeyValuePair<string, string> item in clientTable)
            foreach (DictionaryEntry item in clientTable)
            {
                users.Append("@");
                users.Append(item.Value);
            }

            return users.ToString();
        }
        public static Dictionary<string, User> GetAllUserOjbects()
        {
            return clientobject;
        }
    }
}
