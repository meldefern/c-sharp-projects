using System;
namespace RoomCalculator
{
    public class Square : Rectangle
    {

        public Square(double sl) : base(sl, sl)
        {
        }

		public override string DescribeYourself()
		{
			return $"I am a square with side length {this.Width}";
		}
    }
}
