using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpForTesters._06_Modyfikatory
{
    public class User
    {
        private int age;

        public void setAge(int age)
        {
            if(age <= 0 || age > 150) { Console.WriteLine("nie ma takiego wieku"); } else
            {
                this.age = age;
                Console.WriteLine($"Wiek poprawny: {age}");
            }
        }

        public int getAge()
        {
            return this.age;
        }
    }
}
