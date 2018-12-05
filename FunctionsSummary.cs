using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions3
{
    class Program
    {
        static void Main(string[] args)
        {

            // get number from user while number > 0
            int number = InputNumberLargerThan0();

            // create array in number size and populate with random numbers
            int[] arr = GenerateRandomIntArray(number);

            // print the array
            PrintArray(arr);
        }

        private static void PrintArray(int[] someArray)
        {
            for (int i = 0; i < someArray.Length; i++)
            {
                Console.WriteLine(someArray[i]);
            }
        }

        private static int[] GenerateRandomIntArray(int number)
        {
            int[] result = new int[number];

            Random randomGenerator = new Random();

            for (int i = 0; i < result.Length; i++)
            {
                result[i] = randomGenerator.Next(1, 1001);
            }

            return result;
        }

        private static int InputNumberLargerThan0()
        {
            int result;
            do
            {
                Console.WriteLine("Enter number larger than 0");
                result = Convert.ToInt32(Console.ReadLine());
            }
            while (result <= 0);

            return result;
        }
    }
}
