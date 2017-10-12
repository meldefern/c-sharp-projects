using System;

namespace Eng1
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            // ask for the users age
            Console.WriteLine("How old are you (years)? ");

            // convert age to days
            uint age = Convert.ToUInt32(Console.ReadLine(), 10);
            double days = MainClass.YearsToDays(age);

			// print that age to the screen
			Console.WriteLine($"You are {days} days old");

        }

        public static double YearsToDays(uint years){

            return years * 365.25;

        }

    }
}
