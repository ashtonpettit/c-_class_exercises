using System;

namespace Determinant
{
    class Program
    {
        static void Main(string[] args)
        { 
            int[] inputOne = Array.ConvertAll(Console.ReadLine().Split(' '), Int32.Parse);
            int length = inputOne.Length;
            int[,] matrix = new int[length , length];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        matrix[i, j] = inputOne[j];
                    }
                    if (i < matrix.GetLength(0) - 1)
                    {
                        inputOne = Array.ConvertAll(Console.ReadLine().Split(' '), Int32.Parse);
                    }
                
            }

            string formula = matrix[0,0] + "*" + matrix[1, 1];
            string formulaTwo = matrix[0, 1] + "*" + matrix[1, 0];

            int result = matrix[0, 0] * matrix[1, 1];
            int resultTwo = matrix[0, 1] * matrix[1, 0];

            int A = result - resultTwo;

            Console.WriteLine(A + "(=" + formula + " - " + formulaTwo + " = " + result + " - " + resultTwo + " = " + A + ")"); 
        } 
    }
}
