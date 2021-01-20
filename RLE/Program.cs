using System;
using System.IO;

namespace RLE
{
    class Program
    {
        static void Main(string[] args)
        {
            string pixel = "";

            bool isStar = false;

            try
            {
                string fileName = Console.ReadLine();

                StreamReader reader = File.OpenText(fileName);
                string line = reader.ReadLine();

                while (line != null)
                {
                    string[] numbers = line.Split(',');
                    int[] lineArr = Array.ConvertAll(numbers, Int32.Parse);
                    int firstNum = lineArr[0];

                    if (firstNum == 0)
                    {
                        isStar = false;
                        foreach (var item in lineArr)
                        {
                            for (int j = 0; j < item; j++)
                            {
                                if (isStar == true)
                                {
                                    pixel = "*";
                                }
                                else
                                {
                                    pixel = " ";
                                }

                                Console.Write(pixel);
                            }

                            if (isStar == true)
                            {
                                isStar = false;
                            }
                            else
                            {
                                isStar = true;
                            }
                        }
                    }
                    else
                    {
                        isStar = false;
                        foreach (var item in lineArr)
                        {
                            for (int j = 0; j < item; j++)
                            {
                                if (isStar == true)
                                {
                                    pixel = "*";
                                }
                                else
                                {
                                    pixel = " ";
                                }

                                Console.Write(pixel);
                            }

                            if (isStar == true)
                            {
                                isStar = false;
                            }
                            else
                            {
                                isStar = true;
                            }
                        }
                    }
                    line = reader.ReadLine();
                    Console.WriteLine();
                }
            }
            catch(Exception)
            {
                Console.WriteLine("Crazy Input!");
            }

            
        }
    }
}
