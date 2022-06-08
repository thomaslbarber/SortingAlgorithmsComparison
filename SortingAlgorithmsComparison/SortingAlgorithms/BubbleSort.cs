namespace Algorithms
{
    /// <summary>
    /// Bubble Sort Implementation.
    /// </summary>
    public class BubbleSort : SortingAlgorithm
    {
        /// <summary>
        /// Implements sort using the bubble sort algorithm.
        /// </summary>
        /// <remarks> https://en.wikipedia.org/wiki/Bubble_sort </remarks>
        /// <param name="numbersToSort">The array of integer numbers to sort.</param>
        /// <returns>The sorted integer array.</returns>
        public override int[] Sort(int[] numbersToSort)
        {
            int temporary = 0;
            
            for (int i = 0; i < numbersToSort.Length - 1; i++)
            {
                for (int j = 0; j < numbersToSort.Length - 1; j++)
                {
                    if (numbersToSort[j] > numbersToSort[j + 1])
                    {
                        temporary = numbersToSort[j];
                        numbersToSort[j] = numbersToSort[j + 1];
                        numbersToSort[j + 1] = temporary;
                    }
                }
            }
            
            return numbersToSort;
        }
    }
}