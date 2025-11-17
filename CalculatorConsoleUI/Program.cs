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
    }
}
