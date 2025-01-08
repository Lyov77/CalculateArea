using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesLibrary
{
    public class Triangle : IShape
    {
        private readonly double _sideA;
        private readonly double _sideB;
        private readonly double _sideC;

        public Triangle(double a, double b, double c)
        {
            _sideA = a;
            _sideB = b;
            _sideC = c;
           
            if (IsNotTriangle())
            {
                throw new ArgumentException("Invalid Triangel sides. Non-existing Triangle");
            }
        }

        public double GetArea()
        {
            double s = (_sideA + _sideB + _sideC) / 2;
            return Math.Sqrt(s * (s - _sideA) * (s - _sideB) * (s - _sideC)); // using Heron's formula
        }
        public bool IsNotTriangle()
        {
            return (_sideA + _sideB <= _sideC) ||
                   (_sideB + _sideC <= _sideA) ||
                   (_sideA + _sideC <= _sideB);
        }

        public bool IsRightAngled()
        {
            return (_sideA * _sideA + _sideB * _sideB == _sideC * _sideC) ||
                   (_sideA * _sideA + _sideC * _sideC == _sideB * _sideB) ||
                   (_sideB * _sideB + _sideC * _sideC == _sideA * _sideA);
        }
    }
}
