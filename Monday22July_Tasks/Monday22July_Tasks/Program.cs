using System;

namespace Monday22July_Tasks
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int sizeN;

            Console.WriteLine("Task 1: Print 3d array with random 'double' values.");
            PrintArray();

            while (true)
            {
                Console.Write("Task 2: Enter number for array length: ");
                if (int.TryParse(Console.ReadLine(), out sizeN))
                {
                    RandomArrayFromNSize(sizeN);
                    break;
                }
                else
                    Console.WriteLine("Try again!");
            }

            while (true)
            {
                Console.Write("Taskt 3: Enter number for arrays length: ");
                if (int.TryParse(Console.ReadLine(), out sizeN))
                {
                    MultiplyTwoArrays(sizeN);
                    break;
                }
                else
                    Console.WriteLine("Try again!");
            }

            while (true)
            {
                Console.Write("Task 4: Enter number for Nth element on Fibunacci sequence: ");
                if (int.TryParse(Console.ReadLine(), out sizeN))
                {
                    FibunacciSequenceNumberPrint(sizeN);
                    break;
                }
                else
                    Console.WriteLine("Try again!");
            }

            while (true)
            {
                Console.Write("Task 5: Enter number for Nth element factorial result: ");
                if (int.TryParse(Console.ReadLine(), out sizeN))
                {
                    NFactorial(sizeN);
                    break;
                }
                else
                    Console.WriteLine("Try again!");
            }
        }

        private static void PrintArray()
        {
            Random rng = new Random();
            double[,,] array3d = new double[4, 4, 4];

            for (int i = 0; i < array3d.GetLength(0); i++)
            {
                for (int j = 0; j < array3d.GetLength(1); j++)
                {
                    for (int k = 0; k < array3d.GetLength(1); k++)
                    {
                        array3d[i, j, k] = rng.NextDouble() * (1000.0d - 1.0d) + 1.0d;
                    }
                }
            }
            
            for (int i = 0; i < array3d.GetLength(0); i++)
            {
                for (int j = 0; j < array3d.GetLength(1); j++)
                {
                    for (int k = 0; k < array3d.GetLength(1); k++)
                    {
                        Console.Write(array3d[i, j, k] + " ");
                    }
                    Console.Write(Environment.NewLine);
                }
                Console.Write(Environment.NewLine);
            }
        }

        private static void RandomArrayFromNSize(int sizeN)
        {
            decimal[] arrayDecimal = new decimal[sizeN];
            Random rng = new Random();
            
            Console.WriteLine("Task 2: Random array from given size N");

            for (int i = 0; i < sizeN; i++)
            {
                arrayDecimal[i] = (decimal)rng.NextDouble() * (534.0m - 100.0m) + 100.0m;
            }

            Console.Write("Result: ");
            Console.WriteLine(string.Join(" ", arrayDecimal));
        }

        private static void MultiplyTwoArrays(int sizeN)
        {
            decimal result = 0;
            int numberCounter = 0;
            decimal[] arrayA = new decimal[sizeN];
            decimal[] arrayB = new decimal[sizeN];
            
            Console.WriteLine("Array 1");
            while (numberCounter < sizeN)
            {
                Console.Write("Number " + (numberCounter + 1) + ":");
                if (decimal.TryParse(Console.ReadLine(), out arrayA[numberCounter]))
                    numberCounter++;
                else
                {
                    Console.Write(Environment.NewLine);
                    Console.WriteLine("Error! Enter number for index " + (numberCounter + 1) + " again!");
                }
            }

            numberCounter = 0;
            Console.WriteLine("Array 2");
            while (numberCounter < sizeN)
            {
                Console.Write("Number " + (numberCounter + 1) + ":");
                if (decimal.TryParse(Console.ReadLine(), out arrayB[numberCounter]))
                    numberCounter++;
                else
                {
                    Console.Write(Environment.NewLine);
                    Console.Write("Error! Enter number for index " + (numberCounter + 1) + " again: ");
                }
            }

            for (int i = 0; i < sizeN; i++)
            {
                result += (arrayA[i] * arrayB[i]);
            }

            Console.WriteLine("Result: " + result);
        }

        private static void FibunacciSequenceNumberPrint(int elementNth)
        {
            long numberOne = 0;
            long numberTwo = 1;

            for (int i = 0; i < elementNth; i++)
            {
                numberOne = numberOne + numberTwo;
                numberTwo = numberOne - numberTwo;
            }

            Console.WriteLine("Fibunacci sequence " + elementNth + " number is: " + numberOne);
        }

        private static void NFactorial(int nthNumber)
        {
            //Random rng = new Random();
            //int randomNumber = rng.Next(5, 21);
            long result = 1;

            for (int i = 2; i <= nthNumber; i++)
            {
                result *= i;
            }

            Console.WriteLine("Factorial for " + nthNumber + " is: " + result);
        }
    }
}