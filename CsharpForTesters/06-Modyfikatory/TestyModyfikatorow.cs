using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpForTesters._06_Modyfikatory
{
    public class TestyModyfikatorow
    {
        public static void Main(string[] args)
        {

            // zadanie 2
            Modyfikatory mod = new Modyfikatory();
            mod.budzet = 549000000;
            mod.scenarzysta = "Mario Puzo";
            // tych dwóch nie możemy ustawić
            // mod.film = "Ojciec Chrzestny";
            // mod.rezyser = "Francis Ford Coppola";


            // zadanie 4
            User user = new User();
            user.Age = 245;
            Console.WriteLine(user.Age);
        }
    }
}
