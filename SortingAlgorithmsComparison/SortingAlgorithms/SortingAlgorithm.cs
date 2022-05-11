namespace Algorithms 
{
    /// <summary>
    /// Abstract superclass for all sorting algorithms
    /// </summary>
    public abstract class SortingAlgorithm
    {
        /// <summary>
        /// Abstract Sorting function for each sorting algorithm to implement.
        /// </summary>
        /// <param name="numbersToSort">A list of integer numbers to sort.</param>
        /// <returns>The sorted list.</returns>
        public abstract int[] Sort(int[] numbersToSort);
        
        /// <summary>
        /// Prints a given list of numbers to the console.
        /// </summary>
        /// <param name="numbersToPrint">A list of integer numbers to print to the console.</param>
        public void PrintNumbers(int[] numbersToPrint)
        {
            for (int i = 0; i < numbersToPrint.Length; i++) { Console.Write(numbersToPrint[i] + " "); }

            Console.WriteLine();
        }
        
        /// <summary>
        /// Prints the sorting algorithm type.
        /// </summary>
        public void PrintAlgorithm()
        {
            Console.Write(this.GetType() + " | ");
        }
    }
}