using System;
using System.Security.Cryptography.X509Certificates;

namespace BMI_Project
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
            Console.WriteLine(Math.Round(bmi, 1));
           
        }
    }
}
