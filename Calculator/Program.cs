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
            // Variable for user choise
            int choise;

            // Welcome the user to this program
            Console.WriteLine($"Welcome to {_programName}!");

            do
            {
                // Show the menu of this program and wait for the user make their choise
                int.TryParse(Menu(), out choise);

				// Check if the user don't choise to quit the program
				if (choise != 99)
				{
					// Take the user to the math function they choise to do
					switch(choise)
                    {
                        default:
                            break;
                    }
                    // Make a pause in the program
					Console.ReadKey();
				}

			} while (choise != 99);
            
        }

        /// <summary>
        /// Show the menu of this program and wait for the user make their choise
        /// </summary>
        /// <returns>The user choise</returns>
        static string Menu()
        {
            // Make a empty console window and show the name of this program
            Console.Clear();
			Console.WriteLine(_programName);

            // Make a empty row then show a header for this menu
			Console.WriteLine();
            Header("Menu");

			Console.WriteLine();

            // Show the menu itself
			Console.WriteLine("1. Addition");
			Console.WriteLine("2. Subtraction");
			Console.WriteLine("3. Division");
			Console.WriteLine("4. Multiplication");

			Console.WriteLine("99. Quit the program");

			Console.WriteLine();

            // Ask the user for their choise
            Console.Write("Make your choise: ");
            return Console.ReadLine();
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
