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
					// Make a empty console window and show the name of program
					Console.Clear();
					Console.WriteLine(_programName);

					// Take the user to the math function they choise to do
					switch(choise)
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
		
		/// <summary>
		/// Calculate the sum from some integer values then show the result in console window
		/// </summary>
		static void Addition()
		{
			// Show a heeder for this addition funcction
			Header("Addition");

			// Variables for calculation of sum from some integer values
			int result = 0;
			int[] numbers = GetSomeInteger();

			// Calculate the sum and show the result in console window
			Console.Write("The sum from ");
			for (int i = 0; i < numbers.Length; i++)
			{
				// Add value into the result and show the value that added in console window
				result += numbers[i];
				Console.Write(numbers[i]);

				// Add coma in console if the number don't are the last one
				if(i < numbers.Length - 1)
					Console.Write(", ");
			}
			Console.WriteLine($" are {result}.");
		}
		/// <summary>
		/// Calculate the difference of some integer values then show the result in console window
		/// </summary>
		static void Subtraction()
		{
			// Show the header for this subtraction function
			Header("Subtraction");

			// Variables for calculation of the difference
			int result = 0;
			int[] numbers = GetSomeInteger();

			// Calculate the difference of some integer values and show the result in console window
			Console.Write("The difference of ");
			for (int i = 0; i < numbers.Length; i++)
			{
				// Set or reduce the result
				if(i == 0)
					result = numbers[i];
				else
					result -= numbers[i];

				// Show the value that set or reduce the result for the user
				Console.Write(numbers[i]);

				// Add a coma if the number don't are the last one
				if(i < numbers.Length - 1)
					Console.Write(", ");
			}
			Console.WriteLine($" are {result}.");
		}
		/// <summary>
		/// Calculate the qouta from two integer values then show the result in console window
		/// </summary>
		static void Division()
		{
			// Show a header for this division function
			Header("Division");

			// Variables for calculation of the qouta
			double result = 0;
			int a, b;

			// Ask the user for two integer and the secord don't allowed be zero
			Console.Write("Write a number: ");
			int.TryParse(Console.ReadLine(), out a);

			Console.Write("Write a other number and it's not allowed be zero: ");
			int.TryParse(Console.ReadLine() , out b);

			if (b == 0)
				Console.WriteLine("The secord number are zero and didn't allowed be that.");
			else
			{
				result = (double) a / b;
				Console.WriteLine($"The qouta from {a} and {b} are {Math.Round(result,2)}.");
			}
		}
		/// <summary>
		/// Calculate the product from two integer values then show the result in console window
		/// </summary>
		static void Multiplication()
		{
			// Show a header for this multiplication function
			Header("Multiplication");

			// Variables for calculation of the product
			int a, b;

			// Ask the user for two integer
			Console.Write("Write a number: ");
			int.TryParse(Console.ReadLine(),out a);

			Console.Write("Write a other number: ");
			int.TryParse(Console.ReadLine() ,out b);

			// Calculate the product and show the result in console window
			Console.WriteLine($"The product of {a} and {b} are {a * b}.");
		}
	}
}
