using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackManchesterLIVE
{
    class AppData
    {

        public List<Users> userList;
        public Dictionary<Users, string> userDict;

        public AppData()
            {
                userList = new List<Users>();
                userDict = new Dictionary<Users, string>();
            }

        public void addUser(Users user)
        {
            userList.Add(user);
        }

        public void addToDict(Users user, string email)
        {
            userDict.Add(user, email);
        }


        public bool validLogin(Users user, string password)
        {
            if (userDict.ContainsKey(user) && user.getPassword().Equals(password))
            {
                return true;
            }
            else
            {
                return false;
            }
        }





    }
}
