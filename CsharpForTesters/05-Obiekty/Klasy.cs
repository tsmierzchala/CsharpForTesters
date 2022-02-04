using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpForTesters._05_Obiekty
{
    public class Klasy
    {
        public static void Main(string[] args)
        {
            Paint picasso = new Paint(2, 1);
            
            // bez konstruktora musielibyśmy ustawić dalej szerokość i wysokość
            // picasso.width = 2;
            // picasso.height = 1;

            var price = picasso.GetPrice();
            Console.WriteLine($"Cena obrazu Picasso: {price}");


            // zadanie 7
            Paint panoramaRaclawicka = new Paint(90, 5);
            IPriceable innyObraz = new Paint(4, 4);

            var panoramaPrice = panoramaRaclawicka.GetPrice();
            var innyObrazPrice = innyObraz.GetPrice();

            Console.WriteLine($"Cena Panoramy: {panoramaPrice}");
            Console.WriteLine($"Cena innego obrazu: {innyObrazPrice}");
        }
    }
}
