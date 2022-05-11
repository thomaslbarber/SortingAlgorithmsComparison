namespace SortingAlgorithmsComparison;

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
    
    public static bool DetermineWhetherSuccessful(int[] numbersToSort)
    {
        for (int i = 1; i < numbersToSort.Length; i++)
        {            
            if (numbersToSort[i - 1] > numbersToSort[i])
            {
                return false;
            }
        }

        return true;
    }
    
    private static void ResetNumbers()
    {
        initialNumbers.CopyTo(numbersToSort, 0);
    }

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