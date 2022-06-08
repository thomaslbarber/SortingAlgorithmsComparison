using Algorithms;
namespace SortingAlgorithmsComparison;

/// <summary>
/// A range of utility functions used elsewhere.
/// </summary>
public static class Utilities
{
    private static int[] initialNumbers;
    public static int[] InitialNumbers
    {
        get { return initialNumbers; }
    }

    private static int[] numbersToSort;
    public static int[] NumbersToSort
    {
        get { return numbersToSort; }
    }
    
    public static int[] ArraySizes
    {
        get { return new int[5] { 10, 100, 1000, 10000, 100000 }; }
    }

    private static int currentArraySize = 0;
    public static int CurrentArraySize
    {
        get { return currentArraySize; }
        set { currentArraySize = value; }
    }
    
    /// <summary>
    /// Creates the array of all sorting algorithms.
    /// </summary>
    /// <returns>All sorting algorithms in an array.</returns>
    public static SortingAlgorithm[] CreateAlgorithms()
    {
        return new SortingAlgorithm[] { new BubbleSort(), new CocktailSort(), new SelectionSort(), new InsertionSort(), new QuickSort() };
    }
    
    
    /// <summary>
    /// Tests a specific sorting algorithm, getting the name, sorting it, and calculating both the time taken and whether it was successful.
    /// </summary>
    /// <param name="algorithm">The SortingAlgorithm to test.</param>
    public static void TestAlgorithm(SortingAlgorithm algorithm)
    {
        algorithm.PrintAlgorithm();
        algorithm.PrintWhetherSuccessful(algorithm.BeginSorting(numbersToSort));
        algorithm.PrintTimeTaken();
        Console.WriteLine();
    }
    
    /// <summary>
    /// Determines whether the list is in the properly sorted order (low -> high).
    /// </summary>
    /// <param name="sortedNumbers">The array of integers that should be sorted.</param>
    /// <returns>A boolean valued as true if the list was sorted successfully (false if not).</returns>
    public static bool DetermineWhetherSuccessful(int[] sortedNumbers)
    {
        for (int i = 1; i < sortedNumbers.Length; i++)
        {            
            if (sortedNumbers[i - 1] > sortedNumbers[i])
            {
                return false;
            }
        }

        return true;
    }
    

    
    /// <summary>
    /// Sets the numbersToSort to the initialNumbers, resetting it. 
    /// </summary>
    public static void ResetNumbers()
    {
        initialNumbers.CopyTo(numbersToSort, 0);
    }

    /// <summary>
    /// Generates a random list of integer numbers given an array size.
    /// </summary>
    /// <param name="arraySize">The size of array to generate.</param>
    public static void GenerateInitialNumbers(int arraySize)
    {
        initialNumbers = new int[Utilities.ArraySizes[Utilities.CurrentArraySize]];
        numbersToSort = new int[Utilities.ArraySizes[Utilities.CurrentArraySize]];
        
        Random randomNumberGenerator = new Random();
        
        for (int i = 0; i < arraySize; i++)
        {
            initialNumbers[i] = randomNumberGenerator.Next();
        }

        ResetNumbers();
    }
}