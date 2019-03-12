using System;

namespace Lab01_NumbersGame
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Start();
            }
            catch (Exception)
            {

                throw new Exception("oops, something went wrong :-/");
            }
            finally
            {
                Console.ReadKey();
                Environment.Exit(0);
            }
        }

        static void Start()
        {
            Console.WriteLine("Enter a number greater than zero");
            string userInput1 = Console.ReadLine();
            try
            {
                int intUserInput1 = Convert.ToInt32(userInput1);
                int[] intArray = GetNumbers(intUserInput1);
                Console.WriteLine("The array of numbers is");
                foreach (var a in intArray)
                {
                    Console.Write(a + ", ");
                }
                int totalSum = AddNumbers(intArray);
                Console.WriteLine("The sum of all these numbers is " + totalSum);

                int avg = GetAverage(totalSum, intUserInput1);
                Console.WriteLine("The average of these numbers is " + avg);
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter a number");
                Start();
                //throw new Exception("Please try again...");
            }
        }

        //This is the get numbers method. sets a array based on the first int, and has user set numbers inside.
        static int[] GetNumbers(int size)
        {
            int[] arr = new int[size];
            int counter = 0;
           
            return arr;
        }

        //This is the sum method, iterates over the array and sums them together.
        static int AddNumbers(int[] arr)
        {
            int sum = 0;
            foreach (var b in arr)
                sum = sum + b;
            return sum;
        }

        //This is the averaging method, it divides the sum we found in AddNumbers() by the initial user input/array length.
        static int GetAverage(int totalSum, int divisor)
        {
            int quotient;
            try
            {
                quotient = totalSum / divisor;

            }
            catch (DivideByZeroException)
            {

                throw;
            }
            return quotient;
        }
    }
}
