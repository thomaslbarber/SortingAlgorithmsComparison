using Algorithms;

public class Program
{
    public static void Main(string[] args)
    {
        int[] numbersToSort = new int[] { 12, 5, 42, 74, 2, 91, 26, 83, 59, 63, 9 };
        SortingAlgorithm bubbleSort = new BubbleSort();
        bubbleSort.PrintNumbers(bubbleSort.Sort(numbersToSort));
    }
}