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

        /// <summary>
        /// Show a header in console window 
        /// </summary>
        /// <param name="headerText">The text in the header</param>
        static void Header(string headerText)
        {
			Console.WriteLine($"*************************");
			if (headerText.Equals("Menu"))
				Console.WriteLine($"*\t{headerText}\t\t*");
			else
				Console.WriteLine($"*\t{headerText}\t*");
			Console.WriteLine($"*************************");
		}
        /// <summary>
        /// Collecting of some integer values
        /// </summary>
        /// <returns>A array of integer values</returns>
        static int[] GetSomeInteger()
        {
            // Variables for collecting of integer values
            string numbers;
            int[] result;

            // Ask the user for some integer values
            Console.Write("Write some numbers and split them by coma: ");
            numbers = Console.ReadLine();

            // Convert a string value into a array of integer values then return the result
            result = Array.ConvertAll(numbers.Split(','), int.Parse);
            return result;
        }
    }
}
