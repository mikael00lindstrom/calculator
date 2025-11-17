namespace BusinessLibrary
{
    /// <summary>
    /// A static class that contains extension methods for basic arithmetic operations on integers. 
    /// </summary>
    public static class MathExtensions
    {
        /// <summary>
        /// Sums two integers and returns the result.
        /// </summary>
        /// <param name="a">The first integer in this operation</param>
        /// <param name="b">The secord integer in this opeartion</param>
        /// <returns>The result, sum, for this operation</returns>
        public static int Sum(this int a, int b) => a + b;

        /// <summary>
        /// Subtracts two integers and returns the difference as result.
        /// </summary>
        /// <param name="a">The first integer in this operation</param>
        /// <param name="b">The secord intger in this opeartion</param>
        /// <returns>The result, difference, for this operation</returns>
        public static int Subtract(this int a, int b) => a - b;

        /// <summary>
        /// Multiplies two integers and returns the product as result.
        /// </summary>
        /// <param name="a">The first integer in this operation</param>
        /// <param name="b">The secord integer in this operation</param>
        /// <returns>The result, product, for this opeation</returns>
        public static int Multply(this int a, int b) => a * b;

        /// <summary>
        /// Divides two integers and returns a double qouta as result .
        /// </summary>
        /// <param name="a">The first integer in this opeation</param>
        /// <param name="b">The secord integer in this operation</param>
        /// <returns>The result, qouta, for this operation</returns>
        /// <exception cref="DivideByZeroException">A exception when secord integer are zero</exception>
        public static double Divde(this int a, int b)
        {
            if (b == 0)
                throw new DivideByZeroException("Cannot divide by zero.");
            return (double)a / b;
        }
    }
}
