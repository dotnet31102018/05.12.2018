using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0512
{
    class Program
    {
        static void Main(string[] args)
        {

            Print1To10();

            int[] numbers = { 1, 4, 5 };

            PrintNumbers(numbers);

            int[] numbers2 = { 7, 9, 9 };
            PrintNumbers(numbers2);

            double average = CalculateAverage(numbers);
        }

        private static double CalculateAverage(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum = sum + arr[i];
                if (arr[i] < 0)
                    return -1; // this will get out of the function, back to main
            }

            double avg = sum / arr.Length;

            Console.WriteLine($"Average = {avg}");

            return avg;
        }

        private static void PrintNumbers(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"Element {i} is {arr[i]}");

            }
        }

        private static void Print1To10()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
