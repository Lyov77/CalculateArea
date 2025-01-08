using ShapesLibrary;

namespace CalculateArea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Calculating Circle's Area
            IShape circle = ShapeFactory.CreateShape("circle", 5);
            Console.WriteLine("Circle's area: " + ShapeFactory.CalculateArea(circle));

            // Calculating Triangle's Area
            IShape triangle = ShapeFactory.CreateShape("triangle", 5, 12, 13);
            Console.WriteLine("Triangles' area: " + ShapeFactory.CalculateArea(triangle));
            Console.WriteLine("Is Triangle Right-Angled: " + ((Triangle)triangle).IsRightAngled());

            // Calculating Rectangle's Area
            IShape rectangle = ShapeFactory.CreateShape("rectangle", 7, 8);
            Console.WriteLine("Rectangle's Area: " + ShapeFactory.CalculateArea(rectangle));
        }
    }
}
