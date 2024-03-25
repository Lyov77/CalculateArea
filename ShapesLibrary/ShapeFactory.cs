using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ShapesLibrary
{
    public static class ShapeFactory
    {
        public static IShape CreateShape(string shapeType, params double[] parameters)
        {
            switch (shapeType.ToLower())
            {
                case "circle":
                    if (parameters.Length != 1)
                        throw new ArgumentException("Invalid number of parameters for Circle");
                    return new Circle(parameters[0]);
                case "triangle":
                    if (parameters.Length != 3)
                        throw new ArgumentException("Invalid number of parameters for Triangle");
                    return new Triangle(parameters[0], parameters[1], parameters[2]);
                case "rectangle":
                    if (parameters.Length != 2)
                        throw new ArgumentException("Invalid number of parameters for Rectangle");
                    return new Rectangle(parameters[0], parameters[1]);
                default:
                    throw new ArgumentException("Unsupported shape type");
            }
        }

        public static double CalculateArea(IShape shape) // using reflection
        {
            MethodInfo? method = shape.GetType().GetMethod("GetArea");
            if (method != null)
            {
                return (double)method.Invoke(shape, null)!;
            }
            throw new ArgumentException("Invalid shape type");
        }
    }
}
