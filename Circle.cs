using System;
using System.Collections.Generic;
using System.Text;

namespace CalculateShape
{
    public class Circle : Shape
    {
        private int X { get; set; }
        public Circle(int radius)
        {
            X = radius;
        }
        public override void FindArea()
        {
            Console.WriteLine("Circle Area:" + Math.PI * Math.Pow(X, 2));
        }
    }
}
