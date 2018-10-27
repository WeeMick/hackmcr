using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackManchesterLIVE
{

    public class Users
    {
        public string name;
        public int age;
        public string email;
        public string password;

        public Users(string name, int age, string email, string password)
            {
            this.name = name;
            this.age = age;
            this.email = email;
            this.password = password;

            }
    }
}
