namespace Calculator
{
    /// <summary>
    /// The class for this program
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// The name of this program
        /// </summary>
        const string _programName = "The Calculator 2000";
        
        /// <summary>
        /// The start point of this program
        /// </summary>
        /// <param name="args">Anything</param>
        static void Main(string[] args)
        {
            // Welcome the user to this program
            Console.WriteLine($"Welcome to {_programName}!");

            // Make a pause in this program
            Console.ReadKey();
        }
    }
}
