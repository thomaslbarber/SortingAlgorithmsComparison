namespace Algorithms 
{
    /// <summary>
    /// Selection Sort Implementation.
    /// </summary>
    public class SelectionSort : SortingAlgorithm
    {
        /// <summary>
        /// Implements sort using the selection sort algorithm.
        /// </summary>
        /// <remarks> https://en.wikipedia.org/wiki/Selection_sort </remarks>
        /// <param name="numbersToSort">The array of integer numbers to sort.</param>
        /// <returns>The sorted integer array.</returns>
        public override int[] Sort(int[] numbersToSort)
        {
            int indexOfMin;
            int temporary;
        
            for (int i = 0; i < numbersToSort.Length - 1; i++)
            {
                indexOfMin = i;

                for (int j = i + 1; j < numbersToSort.Length; j++)
                {
                    if (numbersToSort[j] < numbersToSort[indexOfMin]) { indexOfMin = j; }
                }

                temporary = numbersToSort[i];
                numbersToSort[i] = numbersToSort[indexOfMin];
                numbersToSort[indexOfMin] = temporary;

            }

            return numbersToSort;
        }
    }
}