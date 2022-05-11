using Algorithms;

public class Program
{
    public static void Main(string[] args)
    {
        int[] numbersToSort = new int[] { 12, 5, 42, 74, 2, 91, 26, 83, 59, 63, 9 };
        SortingAlgorithm bubbleSort = new BubbleSort();
        bubbleSort.PrintAlgorithm();
        bubbleSort.PrintNumbers(bubbleSort.Sort(numbersToSort));
        
        numbersToSort = new int[] { 12, 5, 42, 74, 2, 91, 26, 83, 59, 63, 9 };
        SortingAlgorithm insertionSort = new InsertionSort();
        insertionSort.PrintAlgorithm();
        insertionSort.PrintNumbers(insertionSort.Sort(numbersToSort));
        
        numbersToSort = new int[] { 12, 5, 42, 74, 2, 91, 26, 83, 59, 63, 9 };
        SortingAlgorithm selectionSort = new SelectionSort();
        selectionSort.PrintAlgorithm();
        selectionSort.PrintNumbers(selectionSort.Sort(numbersToSort));
        
        numbersToSort = new int[] { 12, 5, 42, 74, 2, 91, 26, 83, 59, 63, 9 };
        SortingAlgorithm cocktailSort = new CocktailSort();
        cocktailSort.PrintAlgorithm();
        cocktailSort.PrintNumbers(cocktailSort.Sort(numbersToSort));
    }
}