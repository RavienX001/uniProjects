using System;
using System.Collections.Generic;
using System.Text;

namespace shapeAreaCalculator
{
    internal class Circle : IShape
    { public float CalculateArea(float radius)
        {
            float pi = 3.14f;

            return pi * radius * radius;
        }
    }

    }
