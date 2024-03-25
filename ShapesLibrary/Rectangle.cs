using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesLibrary
{
    public class Rectangle : IShape
    {
        private readonly double _length;
        private readonly double _width;

        public Rectangle(double length, double width)
        {
            _length = length;
            _width = width;
        }

        public double GetArea()
        {
            return _length * _width;
        }
    }
}
