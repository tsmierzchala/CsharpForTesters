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

        public double GetPrice() {
            var pricePerSqMeter = 1000;
            return GetArea() * pricePerSqMeter;
        }
    }
}
