namespace CompileTimeArea
{
    // Интерфейс для фигур
    public interface Shape
    {
        double CalculateArea();
    }

    // Класс для круга
    public class Circle : Shape
    {
        private double _radius;

        public Circle(double radius)
        {
            if (radius < 0)
                throw new ArgumentException("Радиус не может быть меньше 0!");

            _radius = radius;
        }

        public double CalculateArea()
        {
            return Math.PI * Math.Pow(_radius, 2);
        }
    }

    // Класс для треугольника
    public class Triangle : Shape
    {
        private double _sideOne;
        private double _sideTwo;
        private double _sideThree;

        public Triangle(double sideOne, double sideTwo, double sideThree)
        {
            if (sideOne + sideTwo <= sideThree || sideOne + sideThree <= sideTwo || sideTwo + sideThree <= sideOne)
                throw new ArgumentException("Такого треугольника не существует!");

            _sideOne = sideOne;
            _sideTwo = sideTwo;
            _sideThree = sideThree;
        }

        public double CalculateArea()
        {
            double halfPerimeter = (_sideOne + _sideTwo + _sideThree) / 2;
            return Math.Sqrt(halfPerimeter * (halfPerimeter - _sideOne) * (halfPerimeter - _sideTwo) * (halfPerimeter - _sideThree));
        }
    }
}
