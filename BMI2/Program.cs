using System;

namespace BMI2
{
    class Program
    {
        static void Main(string[] args)
        {
            double weight;
            double height;
            double bmi;

            weight = Convert.ToDouble(Console.ReadLine());
            height = Convert.ToDouble(Console.ReadLine());
            bmi = weight / (height * height);
            
            if (bmi < 18.5)
            {
                Console.WriteLine("underweight");
            }
            else if (bmi < 24.9)
            {
                Console.WriteLine("normal");
            }
            else if (bmi < 29.9)
            {
                Console.WriteLine("overweight");
            }
            else if (bmi < 34.9)
            {
                Console.WriteLine("obese");
            }
            else if (bmi > 35)
            {
                Console.WriteLine("extremely obese");
            }
        }
    }
}
