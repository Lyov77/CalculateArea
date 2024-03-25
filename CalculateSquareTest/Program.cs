using ShapesLibrary;

namespace CalculateArea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Calculating Circle's Area
            IShape circle = ShapeFactory.CreateShape("circle", 5);
            Console.WriteLine("Площадь круга: " + ShapeFactory.CalculateArea(circle) + "Pi");

            // Calculating Triangle's Area
            IShape triangle = ShapeFactory.CreateShape("triangle", 5, 12, 13);
            Console.WriteLine("Площадь треугольника: " + ShapeFactory.CalculateArea(triangle));
            Console.WriteLine("Является ли треугольник прямоугольным: " + ((Triangle)triangle).IsRightAngled());

            // Calculating Rectangle's Area
            IShape rectangle = ShapeFactory.CreateShape("rectangle", 7, 8);
            Console.WriteLine("Площадь прямоугольника: " + ShapeFactory.CalculateArea(rectangle));
        }
    }
}
