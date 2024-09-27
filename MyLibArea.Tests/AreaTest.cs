using MyLibArea;

namespace MyLibAreaTest.Tests
{
    public class AreaTests
    {
        [Fact]
        public void Calculate�ircleArea_CorrectArea()
        {
            double radius = 5.0;
            double expectedArea = Math.PI * Math.Pow(radius, 2);

            double actualArea = Area.Calculate�ircleArea(radius);

            Assert.Equal(expectedArea, actualArea, precision: 5); //�������� 5 ������ ����� �������
        }

        [Fact]
        public void Calculate�ircleArea_ThrowsArgumentException()
        {
            double radius = -5.0;

            Assert.Throws<ArgumentException>(() => Area.Calculate�ircleArea(radius));
        }

        [Fact]
        public void CalculateTriangleArea_CorrectArea()
        {
            double sideOne = 3.0;
            double sideTwo = 4.0;
            double sideThree = 5.0;
            double expectedArea = 6.0; //������ �������

            double actualArea = Area.CalculateTriangleArea(sideOne, sideTwo, sideThree);

            Assert.Equal(expectedArea, actualArea, precision: 5); //�������� 5 ������ ����� �������
        }

        [Fact]
        public void CalculateTriangleArea_ThrowsArgumentException()
        {
            double sideOne = 1.0;
            double sideTwo = 2.0;
            double sideThree = 10.0;

            Assert.Throws<ArgumentException>(() => Area.CalculateTriangleArea(sideOne, sideTwo, sideThree));
        }

        [Fact]
        public void IsRightAngledTriangle_True()
        {
            double sideOne = 3.0;
            double sideTwo = 4.0;
            double sideThree = 5.0;

            bool result = Area.IsRightAngledTriangle(sideOne, sideTwo, sideThree);

            Assert.True(result);
        }

        [Fact]
        public void IsRightAngledTriangle_False()
        {
            double sideOne = 3.0;
            double sideTwo = 3.0;
            double sideThree = 5.0;

            bool result = Area.IsRightAngledTriangle(sideOne, sideTwo, sideThree);

            Assert.False(result);
        }

        [Fact]
        public void IsRightAngledTriangle_InvalidSides()
        {
            double sideOne = 1.0;
            double sideTwo = 2.0;
            double sideThree = 10.0;

            Assert.Throws<ArgumentException>(() => Area.IsRightAngledTriangle(sideOne, sideTwo, sideThree));
        }

       
    }
}
