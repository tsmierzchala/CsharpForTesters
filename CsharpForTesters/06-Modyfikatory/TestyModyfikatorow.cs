using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpForTesters._06_Modyfikatory
{
    public class TestyModyfikatorow
    {
        public static void Main(string[] args)
        {
            Modyfikatory mod = new Modyfikatory("Film", "Reżyser", "Scenarzysta", 50000);
            mod.budzet = 20000;

            User user = new User();
            user.Age = 200;
            user.Age = 0;
            user.Age = 20;


        }
    }
}
