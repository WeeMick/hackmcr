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
        public Users user1;
        public Users user2;
        public Users user3;
        public Users user4;


        public AppData()
            {
                userList = new List<Users>();
                userDict = new Dictionary<Users, string>();
                user1 = new Users("Donald Trump", 78, "terriblehairpeice@gmail.com", "bigwall");
                user2 = new Users("Sam", 32, "sam01@hotmail.com", "Sam");
                user3 = new Users("Jane Doe", 19, "janedoe@gmail.com", "Jane");
                user4 = new Users("Mary", 47, "mary@gmail.com", "Mary");

            addUser(user1);
            addUser(user2);
            addUser(user3);
            addUser(user4);

            addToDict(user1, user1.getEmail());
            addToDict(user2, user2.getEmail());
            addToDict(user3, user3.getEmail());
            addToDict(user4, user4.getEmail());
        }   




        public void addUser(Users user)
        {
            userList.Add(user);
        }

        public void addToDict(Users user, string email)
        {
            userDict.Add(user, email);
        }


        





    }
}
