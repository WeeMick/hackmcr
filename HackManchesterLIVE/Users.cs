﻿using System;
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
        public Boolean isShiftWorker;
        public string gender;
        public int height;
        public double weight;
        public DateTime sleepTime;
        public DateTime wakeTime;
        public string type;

        public Users(string name, int age, string email, string password)
            {
            this.name = name;
            this.age = age;
            this.email = email;
            this.password = password;
            isShiftWorker = false;
            }

        public string getName()
        {
            return name;
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

        public void setGender(string gender)
        {
            this.gender = gender;
        }

        public string getGender()
        {
            return gender;
        }


        public void setHeight(int height)
        {
            this.height = height;
        }
        public int getHeight()
        {
            return height;
        }

        public void setWeight(double weight)
        {
            this.weight = weight;
        }
        public double getWeight()
        {
            return weight;
        }

        public void setSleepTime(DateTime sleepTime)
        {
            this.sleepTime = sleepTime;
        }

        public DateTime getSleepTime()
        {
            return sleepTime;
        }

        public void setWakeTime(DateTime wakeTime)
        {
            this.wakeTime = wakeTime;
        }
        public DateTime getWakeTime()
        {
            return wakeTime;
        }

        public void setType(string type)
        {
            this.type = type;
        }
        public string getType()
        {
            return type;
        }


    }
}
