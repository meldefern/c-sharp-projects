using System;
using System.Collections.Generic;

namespace RoomCalculator
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Square[] shapes = new Square[3];

            // "Square" is a complex type
            //Square sqr = new Square(5);

            //shapes[0] = new Square(5);
            //shapes[1] = new Square(5);
            //shapes[2] = new Square(10);

            List<IArea> shapes = new List<IArea>();

            AreaCalculator calc = new AreaCalculator(shapes);

            calc.AddShape(new Square(5));
            calc.AddShape(new Square(7));
            calc.AddShape(new Square(10));
            calc.AddShape(new Rectangle(5,10));
            calc.AddShape(new Circle(10));
            calc.AddShape(new Circle(15));

            double total = calc.GetTotalArea();

            Console.WriteLine($"Total area: {total}");

            Circle circ = new Circle(10);
            Square sqr = new Square(5);

            sqr.Width = 4;

            MainClass.TellMeWhatYouAre(circ);

        }

        public static void TellMeWhatYouAre(IDescribable thing){
            Console.WriteLine(thing.DescribeYourself());
        }

    }
}
