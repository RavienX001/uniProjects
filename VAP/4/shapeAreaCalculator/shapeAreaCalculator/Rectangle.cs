using System;
using System.Collections.Generic;
using System.Text;

namespace shapeAreaCalculator
{
    internal class Rectangle : IShape
    {
        public float CalculateArea(float hight, float width) {
            return hight*width;
        }
    }
}
