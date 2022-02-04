using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpForTesters._05_Obiekty
{
    public class Rectangle : Shape
    {
        public int GetArea()
        {
            return width * height;
        }
    }
}
