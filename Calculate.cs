using System;
using System.Collections.Generic;
using System.Text;

namespace CalculateShape
{
    public interface IShape
    {
        void CalculateArea();
    }
    public class Calculate : IShape
    {
        private List<Shape> Shape { get; set; }
        public Calculate(List<Shape> shape)
        {
            Shape = shape;
        }
        public void CalculateArea(){
            foreach (var item in Shape) item.FindArea();
        }
    }
}
