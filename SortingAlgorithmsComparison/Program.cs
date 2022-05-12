using Algorithms;
using SortingAlgorithmsComparison;

/// <summary>
/// Main() class.
/// </summary>
public class Program
{
    /// <summary>
    /// Iterates through all sorting algorithms, and tests them on a range of array sizes (10, 100, 1000, 10000, 100000).
    /// </summary>
    /// <param name="args"></param>
    public static void Main(string[] args)
    {
        for (int i = 0; i < Utilities.ArraySizes.Length; i++, Utilities.CurrentArraySize++)
        {
            SortingAlgorithm[] sortingAlgorithms = Utilities.CreateAlgorithms();

            Utilities.GenerateInitialNumbers(Utilities.ArraySizes[Utilities.CurrentArraySize]);
            
            Console.WriteLine("Test " + i + " - array size of " + Utilities.ArraySizes[i]);
            for (int j = 0; j < sortingAlgorithms.Length; j++)
            {
                Utilities.TestAlgorithm(sortingAlgorithms[j]);
                Utilities.ResetNumbers();
            }
            Console.WriteLine("\n");
        }
    }
}