using System;
namespace RoomCalculator
{
    abstract public class Shape : IDescribable, IArea
    {
		String Name;
		String Colour;

        public Shape()
        {
        }

        abstract public double CalculateArea();
        abstract public string DescribeYourself();
    }

}
