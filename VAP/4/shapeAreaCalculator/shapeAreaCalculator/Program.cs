using System.Numerics;
using System.Runtime.ConstrainedExecution;

namespace shapeAreaCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Ishape> shapes = new List<Ishape> {
            new (),
            new ()
            };

            foreach (Ishape shape in shapes) { shape.Move(); }
        }
    }
    }
