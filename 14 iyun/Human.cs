using System;
using System.Collections.Generic;
using System.Text;

namespace _14_iyun
{
    class Human
    {
        public string Name;
        public string Surname;
        public byte Age;
        public Human(byte age = 30, string  name=null, string surname = null)
        {
             Name = name;
            Surname = surname;
            Age = age;
        }
    }
}
