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
            // Variable for storing user choice
            int choice;

            // Display a welcome message
            Console.WriteLine($"Welcome to {ApplicationName}!");

            // Let the user to read the welcome message
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();

            // Loop to display the menu until the user choose to exit
            do
            {
                // Display the menu and get the user choice
                choice = Menu();

                // Clear the console for better user experience and display the application name
                Console.Clear();
                Console.WriteLine(ApplicationName);

                Console.WriteLine();

                // Perform the operation based on user choice
                switch (choice)
                {
                    case 1:
                        Addition();
                        break;
                    case 2:
                        Subtraction();
                        break;
                    case 3:
                        Division();
                        break;
                    case 4:
                        Multiplication();
                        break;
                    case 5:
                        Console.WriteLine("Thank you for using the calculator. Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Try again.");
                        break;
                }

                // Let the user time to read the result
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            } while (choice != 5);
        }

        /// <summary>
        /// The method to display the menu and get the user choice
        /// </summary>
        /// <returns>The integer that symbolized the user choice</returns>
        static int Menu()
        {
            // Create a empty screen for better user experience
            Console.Clear();
            Console.WriteLine(ApplicationName);

            // Create a empty line for better readability
            Console.WriteLine();

            // Display the menu header
            DispalyAHeader("Menu");

            // Create a empty line for better readability
            Console.WriteLine();

            // Display the menu options
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Division");
            Console.WriteLine("4. Multiplication");
            Console.WriteLine("5. Exit");

            // Create a empty line for better readability
            Console.WriteLine();

            // Let the user to select an option
            Console.Write("Select an option (1-5): ");
            int.TryParse(Console.ReadLine()!, out int choice);

            // Validate the user choice
            if (choice < 1 || choice > 5)
            {
                Console.WriteLine("Invalid choice. Please select a valid option (1-5).");
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                return Menu();
            }

            return choice;
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