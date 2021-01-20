using System;

namespace itsMagic
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isMagic = false;
            int input = Convert.ToInt32(Console.ReadLine());
            int[] intArray = Array.ConvertAll(Console.ReadLine().Split(' '), Int32.Parse);

            int length = intArray.Length;
            int[,] nrsArr = new int[input, length];

            for (int i = 0; i < nrsArr.GetLength(0); i++)
            {

                for (int j = 0; j < nrsArr.GetLength(1); j++)
                {
                    nrsArr[i , j] = intArray[j];
                }
                if (i < nrsArr.GetLength(0) - 1)
                {
                    intArray = Array.ConvertAll(Console.ReadLine().Split(' '), Int32.Parse);
                }
            }

            int oldSum = 0;
            int count = 1;
            int[] sum = new int[length];
            for (int i = 0; i < nrsArr.GetLength(1); i++)
            {
                sum[i] = 0;
                for (int j = 0; j < nrsArr.GetLength(0); j++)
                {
                    sum[i] = sum[i] + nrsArr[j , i];
                }
                if (i != 0 && sum[i] == oldSum)
                {
                    count++;
                }
                oldSum = sum[i];
            }

            if (count == length)
            {
                isMagic = true;
            }

            Console.WriteLine(count + " " + isMagic);

        }
    }
}
