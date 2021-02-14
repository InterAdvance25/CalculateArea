using System;
using System.Collections.Generic;
using System.Text;

namespace CalculateShape
{
    public class Tringle : Shape
    {
        int X, Y, Z;
        public Tringle(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }
        public override void FindArea()
        {
            int sum = X + Y + Z;
            string straight = "";
            if ((X * X + Y * Y == Z * Z) || (X * X + Y * Y == Y * Y) || (Z * Z + Y * Y == X * X))
            {
                straight = "Straight";
            }
            Console.WriteLine(straight+"Triangle Area:" + Math.Sqrt((sum / 2) * ((sum / 2) - X) * ((sum / 2) - Y) * ((sum / 2) - Z)));

        }
    }
}
