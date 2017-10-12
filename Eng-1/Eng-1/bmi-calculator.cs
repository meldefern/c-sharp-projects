using System;

namespace Eng1
{
	class MainClass
	{
        public static void Main(string[] args)
        {
            // ask user for their weight and height
            Console.WriteLine("Please enter your weight in kg:");
            float weight = float.Parse(Console.ReadLine());

            Console.WriteLine("Please enter your height in m:");
            float height = float.Parse(Console.ReadLine());

            // Calculate BMI
            double bmi = CalculateBMI(weight, height);

            // Categorize BMI
            String bmiCategory = CategorizeBMI(bmi);

            Console.WriteLine($"Your BMI is {bmi}, you are {bmiCategory}");

        }

        public static double CalculateBMI(float weight, float height){

            return (weight / Math.Pow(height, 2));

        }

        public static String CategorizeBMI(double bmi){

            if (bmi < 18.5) {
                return "underweight";
            } else if (bmi > 18.5 && bmi < 24.9) {
                return "healthy";
            } else if (bmi > 25.0 && bmi < 29.9) {
                return "overweight";
            } else if (bmi > 30.0 && bmi < 34.9) {
                return "obese";
            } else if (bmi > 35.0 && bmi < 39.9) {
                return "severly obese";
            } else if (bmi >= 40) {
                return "morbidly obese";
            } else {
                return "unknown";
            }

        }

	}
}
