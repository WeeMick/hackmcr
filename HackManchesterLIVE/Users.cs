using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackManchesterLIVE
{

    class Users
    {
        string name;
        int age;
        string email;
        string password;
        Boolean isShiftWorker;

        public Users(string name, int age, string email, string password)
            {
            this.name = name;
            this.age = age;
            this.email = email;
            this.password = password;
            isShiftWorker = false;
            }

        public string getEmail()
        {
            return email;
        }

        public string getPassword()
        {
            return password;
        }

        public void setShiftWorker(Boolean isShiftWorker)
        {
            if (isShiftWorker == true)
            {
                this.isShiftWorker = true;
            }
            else
            {
                this.isShiftWorker = false;
            }
        }

        
    }
}
