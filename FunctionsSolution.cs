using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionsStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            Print123();

            //int number = Convert.ToInt32(Console.ReadLine());

            PrintPower2(4);
            PrintPower2(8);
            //PrintPower2(number);

            int[] arr = { 1, 4, 8 };
            int[] arr3 = { 1, 4, 8, 9 };

            PrintArray(arr);
            PrintArray(arr3);

            int result = GetPower2(9);
            Console.WriteLine($"9^2 = {result}");

            Console.WriteLine($"10^2 = {GetPower2(10)}");

            int[] arrayWithRandom = GetIntArrayWithRandomNumbers(100, 1, 1001);
            int[] arrayWithRandom100 = GetIntArrayWithRandomNumbers(100, 1, 101);

            PrintArray(arrayWithRandom);

            double[] aDoubleArray = ConvertArrayIntToDouble(arrayWithRandom100);

            //PrintArray(aDoubleArray);
        }

        private static double[] ConvertArrayIntToDouble(int[] arrayWithRandom100)
        {
            double[] result = new double[arrayWithRandom100.Length];
            for (int i = 0; i < arrayWithRandom100.Length; i++)
            {
                result[i] = arrayWithRandom100[i];
            }
            return result;
        }

        private static int[] GetIntArrayWithRandomNumbers(int arraySize, int min, int max)
        {
            int[] result = new int[arraySize];

            Random randomGenerator = new Random();

            for (int i = 0; i < result.Length; i++)
            {
                result[i] = randomGenerator.Next(min, max);
            }

            return result;
        }

        private static int GetPower2(int v)
        {
            return v * v;
        }

        private static void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[ i ]);
            }
        }

        private static void PrintPower2(int number)
        {
            Console.WriteLine($"Power^2 of {number} is {number * number}");
        }

        private static void Print123()
        {
            Console.WriteLine(1);
            Console.WriteLine(2);
            Console.WriteLine(3);
        }
    }
}
