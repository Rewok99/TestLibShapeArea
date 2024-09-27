using System;
using MyLibArea;
using CompileTimeArea;

class Program
{
    static void Main(string[] args)
    {
        // Пример использования для круга
        double radius = 5.0;
        try
        {
            double circleArea = Area.CalculateСircleArea(radius);
            Console.WriteLine($"Площадь круга с радиусом {radius}: {circleArea}");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }

        // Пример использования для треугольника
        double sideOne = 3.0;
        double sideTwo = 4.0;
        double sideThree = 5.0;
        try
        {
            double triangleArea = Area.CalculateTriangleArea(sideOne, sideTwo, sideThree);
            Console.WriteLine($"Площадь треугольника: {triangleArea}");

            bool isRight = Area.IsRightAngledTriangle(sideOne, sideTwo, sideThree);
            Console.WriteLine($"Треугольник прямоугольный: {isRight}");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }



        //compileTimeArea 
        Shape circle = new Circle(5.0);
        Shape triangle = new Triangle(3.0, 4.0, 5.0);
        Console.WriteLine($"Площадь круга: {circle.CalculateArea()}");
        Console.WriteLine($"Площадь треугольника: {triangle.CalculateArea()}");
    }
}
