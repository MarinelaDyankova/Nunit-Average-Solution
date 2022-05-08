using System;

namespace Average
{
    public class Average
    {
        public static double AverageNumbers(double[] arr)
        {
            double sum = 0;
           
            double average = 0;
            if (arr.Length != 0) {
                for (int i = 0; i < arr.Length; i++)
                {
                    sum += arr[i];
                   
                }
                average = sum / arr.Length;
            } else if (arr.Length == 0)
            {
                average = 0;    
            }

            return average;
        }
        static void Main()
        {
            double result = AverageNumbers(new double[] { 5, 8 });
            Console.WriteLine($"{result:f2}");
        }
    }

    }

