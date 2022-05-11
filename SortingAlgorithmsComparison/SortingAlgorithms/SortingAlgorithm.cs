namespace Algorithms 
{
    /// <summary>
    /// Abstract superclass for all sorting algorithms
    /// </summary>
    public abstract class SortingAlgorithm
    {
        public abstract int[] Sort(int[] numbersToSort);
        
        public void PrintNumbers(int[] numbersToPrint)
        {
            for (int i = 0; i < numbersToPrint.Length; i++) { Console.Write(numbersToPrint[i] + " "); }

            Console.WriteLine();
        }
    }
}