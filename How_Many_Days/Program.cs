using System;
using System.Collections.Generic;

namespace How_Many_Days
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
             * input
                13/11/2020
                24 December 2020
                output
                41 days

                input
                23 November 2020
                23/11/2021
                output
                365 days
            */

            try
            {
                //date 1
                string input = "";
                string[] inputarr = new string[3];
                double[] date = new double[3];
                double[] dateTwo = new double[3];
                double finalNum = 0;
                Dictionary<double, string> months = new Dictionary<double, string>();
                months.Add(1, "January");
                months.Add(2, "February");
                months.Add(3, "March");
                months.Add(4, "April");
                months.Add(5, "May");
                months.Add(6, "June");
                months.Add(7, "July");
                months.Add(8, "August");
                months.Add(9, "September");
                months.Add(10, "October");
                months.Add(11, "November");
                months.Add(12, "December");

                for (int i = 0; i <= 1; i++)
                {
                    input = Console.ReadLine();

                    if (input.Contains("/"))
                    {
                        inputarr = input.Split('/');
                        if (i == 0)
                        {
                            date = Array.ConvertAll(inputarr, Double.Parse);
                        }
                        else
                        {
                            dateTwo = Array.ConvertAll(inputarr, Double.Parse);
                        }

                        if (date[1] > 12 || dateTwo[1] > 12)
                        {
                            Console.WriteLine("Crazy Input!");
                        }

                    }
                    else
                    {
                        inputarr = input.Split(' ');
                        double key = 0;
                        if (months.ContainsValue(inputarr[1]))
                        {
                            foreach (var item in months)
                            {
                                if (item.Value == inputarr[1]) key = item.Key;

                            }
                            inputarr[1] = key.ToString();
                            if (i == 0)
                            {
                                date = Array.ConvertAll(inputarr, Double.Parse);
                            }
                            else
                            {
                                dateTwo = Array.ConvertAll(inputarr, Double.Parse);
                            }



                        }

                    }


                }


                /*
                 * Formula for date difference: 1461 * Year / 4 + 153 * Month / 5 + Date 
                 * First Date - Second Date

                */

                double year = 1461 * date[2] / 4;
                double month = 153 * date[1] / 5;
                double num = year + month + date[0];

                double yearTwo = 1461 * dateTwo[2] / 4;
                double monthTwo = 153 * dateTwo[1] / 5;
                double numTwo = yearTwo + monthTwo + dateTwo[0];

                if (num > numTwo)
                {
                    finalNum = Math.Floor(num - numTwo);
                }
                else
                {
                    finalNum = Math.Floor(numTwo - num);
                }

                Console.WriteLine(finalNum + " Days");

            }
            catch (Exception)
            {
                Console.WriteLine("Crazy Input!");
            }
            







        }
    }
}
