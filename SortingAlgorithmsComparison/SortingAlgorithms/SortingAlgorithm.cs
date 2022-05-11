using SortingAlgorithmsComparison;
using System.Diagnostics;

namespace Algorithms 
{
    /// <summary>
    /// Abstract superclass for all sorting algorithms
    /// </summary>
    public abstract class SortingAlgorithm
    {
        private Stopwatch stopwatch = new Stopwatch(); // Used to measure time taken to sort.
        
        /// <summary>
        /// Abstract Sorting function for each sorting algorithm to implement.
        /// </summary>
        /// <param name="numbersToSort">A list of integer numbers to sort.</param>
        /// <returns>The sorted list.</returns>
        public abstract int[] Sort(int[] numbersToSort);
        
        /// <summary>
        /// Handles the timer and calls Sort() which sorts the array from smallest -> biggest numbers.
        /// </summary>
        /// <param name="numbersToSort">The unsorted array of integers.</param>
        /// <returns>The sorted array of integers.</returns>
        public int[] BeginSorting(int[] numbersToSort)
        {
            stopwatch.Start();
            numbersToSort = Sort(numbersToSort); // Sort the array.
            stopwatch.Stop();

            return numbersToSort;
        }
        
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
        
        public void PrintWhetherSuccessful(int[] numbersToPrint)
        {
            if (Utilities.DetermineWhetherSuccessful(numbersToPrint)) { Console.Write("Array was sorted successfully!"); return; }

            Console.Write("Array failed to sort!");
        }
        
        public void PrintTimeTaken()
        {
            if (stopwatch != null)
            {
                Console.Write(" | Time taken: " + stopwatch.Elapsed.TotalMilliseconds + "ms");
            }
            else
            {
                Console.Write(" | ERROR: Stopwatch is null!");
            }
        }
    }
}