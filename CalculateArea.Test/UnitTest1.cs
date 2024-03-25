using ShapesLibrary;

namespace CalculateArea.Test
{
    public class Tests
    {
        private IShape circle;
        private IShape triangle;
        private IShape rectangle;

        [SetUp]
        public void Setup()
        {
            // Arrange
            circle = ShapeFactory.CreateShape("circle", 5);
            triangle = ShapeFactory.CreateShape("triangle", 3, 4, 5);
            rectangle = ShapeFactory.CreateShape("rectangle", 6, 5);
        }

        [Test]
        public void CircleAreaCalculation()
        {
            // Act
            double area = ShapeFactory.CalculateArea(circle);

            // Assert
            Assert.That(area, Is.EqualTo(25));
        }

        [Test]
        public void TriangleAreaCalculation()
        {
            // Act
            double area = ShapeFactory.CalculateArea(triangle);

            // Assert
            Assert.That(area, Is.EqualTo(6));
        }

        [Test]
        public void RectangleAreaCalculation()
        {
            // Act
            double area = ShapeFactory.CalculateArea(rectangle);

            // Assert
            Assert.That(area, Is.EqualTo(30));
        }
    }
}