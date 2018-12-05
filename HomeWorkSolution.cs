using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0512hw
{
    class Program
    {
        static void Main(string[] args)
        {
            Question1();

            Question2();

            Question3();

            Question4();

        }

        private static void Question4()
        {
            // question 4
            Console.WriteLine("Please enter number of classes:");
            int classes = Convert.ToInt32(Console.ReadLine());

            //int classOfMaximumAverage = 0;
            //double maxAverage = 0;

            int classOfMaximumAverage = -1;
            double maxAverage = double.MinValue;

            int[][] grades = new int[classes][];
            for (int i = 0; i < grades.GetLength(0); i++)
            {
                Console.WriteLine($"Please enter number of students for class number {i + 1}:");
                int studentsInThisClass = Convert.ToInt32(Console.ReadLine());

                int[] grades1 = new int[studentsInThisClass];

                grades[i] = new int[studentsInThisClass];

                int sum = 0;
                for (int j = 0; j < grades[i].Length; j++)
                {
                    Console.WriteLine($"Please enter grade for student {j + 1}:");
                    int grade = Convert.ToInt32(Console.ReadLine());

                    grades[i][j] = grade;

                    sum = sum + grades[i][j];
                }

                double average = sum / grades[i].Length;

                Console.WriteLine($"Average of class {i + 1} is {average}");

                if (average > maxAverage)
                {
                    maxAverage = average;
                    classOfMaximumAverage = i;
                }
            }

            Console.WriteLine($"The class with maximum average was class {classOfMaximumAverage + 1} with average of {maxAverage}");
        }

        private static void Question3()
        {
            int sizeBoard = 3;

            int[,] matrix = new int[sizeBoard, sizeBoard]; // all values are 0

            Random randomGenerator = new Random();

            int counterOfSub = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    // create a random number between 0-1
                    matrix[i, j] = randomGenerator.Next(0, 2);

                    // if the random number was 1 then increase number of submarines
                    if (matrix[i, j] == 1)
                    {
                        counterOfSub++;
                    }
                    Console.Write(matrix[i,j]);
                }
                Console.WriteLine();
            }

            // game loop
            int trials = 0;

            do
            {
                Console.WriteLine("Enter row for submarine:");
                int row = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter column for submarine:");
                int column = Convert.ToInt32(Console.ReadLine());

                if (matrix[row, column] == 1)
                {
                    Console.WriteLine("BOOM!");
                    counterOfSub--;
                    matrix[row, column] = 0;
                }
                else
                {
                    Console.WriteLine("Missed..............");
                }

                trials++;
            }
            while (counterOfSub > 0);

            Console.WriteLine("Game Over!");
            Console.WriteLine($"Total trials  = {trials} ");
        }

        private static void Question2()
        {

            // question 2
            int[,] matrix = new int[5, 5]; // all values are 0

            Random randomGenerator = new Random();

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    // create a random number between 1-10
                    matrix[i, j] = randomGenerator.Next(1, 11);
                }
            }

            Console.WriteLine("Please enter a number:");
            int number = Convert.ToInt32(Console.ReadLine());

            // check where the number resides
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] == number)
                    {
                        Console.WriteLine($"[{i}, {j}] number {number} appears");
                    }
                }
            }
        }

        private static void Question1()
        {
            // question 1

            Console.WriteLine("Enter number of students in class:");
            int students = Convert.ToInt32(Console.ReadLine());

            int[] gradesArray = new int[students];
            for (int i = 0; i < gradesArray.Length; i++)
            {
                gradesArray[i] = Convert.ToInt32(Console.ReadLine());
            }

            int sum = 0;
            for (int i = 0; i < gradesArray.Length; i++)
            {
                sum = sum + gradesArray[i];
            }

            double average = sum / gradesArray.Length;

            Console.WriteLine($"The average was : {average}");
        }
    }
}
