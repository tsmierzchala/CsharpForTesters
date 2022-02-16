using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpForTesters._05_Obiekty
{
    public class Paint : Rectangle, IPriceable
    {
        public Paint(int width, int height)
        {
            this.width = width;
            this.height = height;
        }

        public double GetPrice()
        {
            return GetArea() * 1000;
        }
    }
}
