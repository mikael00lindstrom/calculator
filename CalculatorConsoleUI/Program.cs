using BusinessLibrary;

namespace CalculatorConsoleUI
{
    /// <summary>
    /// The main class of the calculator console application.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// The name of the application.
        /// </summary>
        public const string ApplicationName = "The Calculator 2000";

        /// <summary>
        /// The main entry point of the application.
        /// </summary>
        /// <param name="args">A array of command-line arguments</param>
        static void Main(string[] args)
        {
            // Display a welcome message
            Console.WriteLine($"Welcome to {ApplicationName}!");

            // Let the user to read the welcome message
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        #region Helper methods

        /// <summary>
        /// Display a header by a specified title in console application
        /// </summary>
        /// <param name="title">The specified title for this header</param>
        static void DispalyAHeader(string title)
        {
            Console.WriteLine(new string('*', 50));
            Console.WriteLine($"* {title}");
            Console.WriteLine(new string('*', 50));
        }

        /// <summary>
        /// Collect some integer from the user
        /// </summary>
        /// <returns>A array of some integers</returns>
        static int[] GetSomeInteger()
        {
            // Variables for collecting of some integer
            string numbers;
            int[] result;

            // Let the user to enter some integer and split them by coma
            Console.Write("Enter some number and split them by coma: ");
            numbers = Console.ReadLine()!;

            // Convert a string value into a array of integer values then return the result
            result = Array.ConvertAll(numbers.Split(','), int.Parse);
            return result;
        }

        #endregion

        #region Basic Math Operation UI methods
        /// <summary>
        /// The method for addition operation in this application
        /// </summary>
        static void Addition()
        {
            // Display a header for this method
            DispalyAHeader("Addition");

            // Variables for calculating of sum in this method
            int[] numbers = GetSomeInteger();
            int result = 0;

            // Calculate the sum and display the result
            Console.Write("The sum of ");
            for (int i = 0; i < numbers.Length; i++)
            {
                // Calculate the sum by using BusinessLibrary
                result = result.Sum(numbers[i]);

                // Display the current number
                Console.Write(numbers[i]);

                // Display a comma except for the last number
                if (i < numbers.Length - 1)
                    Console.Write(", ");
            }
            Console.WriteLine($" are {result}.");
        }

        /// <summary>
        /// The method for subtraction operation in this application
        /// </summary>
        static void Subtraction()
        {
            // Display a header for this method
            DispalyAHeader("Subtraction");

            // Variables for calculating of difference in this method
            int[] numbers = GetSomeInteger();
            int result = 0;

            // Calculate the differnce and display the result
            Console.Write("The difference of ");
            for (int i = 0; i < numbers.Length; i++)
            {
                // Set or reduce by current number to the result
                if (i == 0)
                    result = numbers[i];
                else
                    result = result.Subtract(numbers[i]);

                // Display the current number
                Console.Write(numbers[i]);

                // Display a comma except for the last number
                if (i < numbers.Length - 1)
                    Console.Write(", ");
            }
            Console.WriteLine($" are {result}.");
        }

        /// <summary>
        /// The method for division operation in this application
        /// </summary>
        static void Division()
        {
            // Display a header for this method
            DispalyAHeader("Division");

            // Variables for calculating of quotient in this method
            int a, b;
            double result = 0;

            // Let the user to enter two integer values
            Console.Write("Enter the dividend: ");
            int.TryParse(Console.ReadLine()!, out a);
            Console.Write("Enter the divisor and it don't allowed be zero: ");
            int.TryParse(Console.ReadLine()!, out b);

            // Calculate the quotient and display the result
            try
            {
                result = a.Divde(b);
                Console.WriteLine($"The quotient of {a} and {b} is {Math.Round(result, 2)}.");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        /// <summary>
        /// The method for multiplication operation in this application
        /// </summary>
        static void Multiplication()
        {
            // Display a header for this method
            DispalyAHeader("Multiplication");

            // Variables for calculating of product in this method
            int a, b, result = 0;

            // Let the user to enter two integer values
            Console.Write("Enter the first number: ");
            int.TryParse(Console.ReadLine()!, out a);
            Console.Write("Enter the second number: ");
            int.TryParse(Console.ReadLine()!, out b);

            // Calculate the product and display the result
            result = a.Multply(b);
            Console.WriteLine($"The product of {a} and {b} is {result}.");
        }
        #endregion
    }
}