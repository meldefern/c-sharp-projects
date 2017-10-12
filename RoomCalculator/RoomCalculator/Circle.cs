using System;
namespace RoomCalculator
{
    public class Circle : Shape
    {
        double Radius;

        public Circle(double rad)
        {
            this.Radius = rad;
        }

        public override double CalculateArea()
        {
            return Math.PI * Math.Pow(this.Radius, 2);
        }

        public override string DescribeYourself()
        {
            return $"I am a circle with radius {this.Radius}";
        }
    }
}
