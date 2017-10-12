using System;
namespace RoomCalculator
{
    public class Rectangle : Shape
    {
        protected double width;
        public double Width { get {
                return width;
            } set {
                width = value;
            } }

        private double height;
        public double Height { get {
                return height;
            } set {
                height = value;
            } }
       
        public Rectangle(double w, double h)
        {
            this.Width = w;
            this.Height = h;
        }

		public override double CalculateArea()
		{
			return this.Width * this.Height;
		}

		public override string DescribeYourself()
		{
            return $"I am a rectangle with width {this.Width} and length {this.Height} ";
		}

    }
}
