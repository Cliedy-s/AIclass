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
        private static Hashtable clientTable = new Hashtable();
        private static Dictionary<string, User> clientobject = new Dictionary<string, User>();
        public static bool AddClient(string username, string usergid, User user)
        {
            lock (clientTable)
            {
                if (clientTable.ContainsValue(username))
                    return false;

                clientTable.Add(usergid, username);
                clientobject.Add(usergid, user);
                return true;
            }
        }
        public static bool RemoveClient(User user)
        {
            lock (clientTable)
            {
                if (clientTable.ContainsKey(user.GUID))
                {
                    clientTable.Remove(user.GUID);
                    clientobject.Remove(user.GUID);
                    return true;
                }
                else
                {
                    clientTable.Add(user.GUID, user.Username);
                    clientobject.Add(user.GUID, user);
                    return false;
                }
                

            }
        }
        public static bool IsContains(string userid)
        {
            return clientTable.ContainsKey(userid);
        }
        public static string GetAllUsersToString()
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
        public static Dictionary<string, User> GetAllUserObjects()
        {
            return clientobject;
        }
    }
}
