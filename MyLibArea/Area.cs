namespace MyLibArea;

public class Area
{

    //вычисление площади круга
    public static double CalculateСircleArea(double radius)
    {
        if (radius < 0)
        {
            throw new ArgumentException("Радиус не может быть меньше 0!");
        }
        return Math.PI * Math.Pow(radius, 2);
    }


    //вычисление площади треугольника
    public static double CalculateTriangleArea(double sideOne, double sideTwo, double sideThree)
    {

        if (sideOne + sideTwo <= sideThree || sideOne + sideThree <= sideTwo || sideTwo + sideThree <= sideOne)
        {
            throw new ArgumentException("Такого треугольника не существует!");
        }

        double halfPerimeter = (sideOne + sideTwo + sideThree) / 2;

        return Math.Sqrt(halfPerimeter * (halfPerimeter - sideOne) * (halfPerimeter - sideTwo) * (halfPerimeter - sideThree));

    }

    //проверка на прямоугольный треугольник (тут не совсем понял требование, должен ли это быть отдельный метод или же внутри вычисления площади)
    public static bool IsRightAngledTriangle(double sideOne, double sideTwo, double sideThree)
    {

        if (sideOne + sideTwo <= sideThree || sideOne + sideThree <= sideTwo || sideTwo + sideThree <= sideOne)
        {
            throw new ArgumentException("Такого треугольника не существует!");
        }

        double hypotenuse = Math.Max(sideOne, Math.Max(sideTwo, sideThree));
        double cathetusOne, cathetusTwo;

        if (hypotenuse == sideOne)
        {
            cathetusOne = sideTwo;
            cathetusTwo = sideThree;
        }
        else if (hypotenuse == sideTwo)
        {
            cathetusOne = sideOne;
            cathetusTwo = sideThree;
        }
        else
        {
            cathetusOne = sideOne;
            cathetusTwo = sideTwo;
        }

        // Проверка по теореме Пифагора: гипотенуза^2 = катет1^2 + катет2^2
        return Math.Abs(Math.Pow(hypotenuse, 2) - (Math.Pow(cathetusOne, 2) + Math.Pow(cathetusTwo, 2))) < 0.0001;
    }
}