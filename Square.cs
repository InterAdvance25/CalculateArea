using System;
using System.Collections.Generic;
using System.Text;

namespace CalculateShape
{
    public class Square : Shape
    {
        private int X { get; }
        public Square(int x)
        {
            X = x;
        }
        public override void FindArea()
        {
            Console.WriteLine("Square Area:" + X * X);
        }
    }
}
