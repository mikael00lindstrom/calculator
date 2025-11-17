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
    }
}
