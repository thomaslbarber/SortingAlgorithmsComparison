namespace Algorithms
{
    /// <summary>
    /// Quick Sort Implementation
    /// </summary>
    public class QuickSort : SortingAlgorithm
    {
        /// <summary>
        /// Sorts a (portion of an) array, divides it into partitions, then sorts those.
        /// </summary>
        /// <param name="numbersToSort"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        private void RecursiveSort(int[] numbersToSort, int start, int end)
        {
            int i;
            if (start < end)
            {
                // Partition array and get the pivot index. 
                i = Partition(numbersToSort, start, end);
                
                // Sort the two partitions.
                RecursiveSort(numbersToSort, start, i - 1);
                RecursiveSort(numbersToSort, i + 1, end);
            }
        }
        
        /// <summary>
        /// Divides the array into two partitions.
        /// </summary>
        /// <param name="numbersToSort"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <returns></returns>
        private int Partition(int[] numbersToSort, int start, int end)
        {
            int temporary;
            int p = numbersToSort[end];
            int i = start - 1;

            for (int j = start; j <= end - 1; j++)
            {
                if (numbersToSort[j] <= p)
                {
                    i++;
                    temporary = numbersToSort[i];
                    numbersToSort[i] = numbersToSort[j];
                    numbersToSort[j] = temporary;
                }
            }

            temporary = numbersToSort[i + 1];
            numbersToSort[i + 1] = numbersToSort[end];
            numbersToSort[end] = temporary;
            return i + 1;
        }

        /// <summary>
        /// Implements sort using the quick sort algorithm. 
        /// </summary>
        /// <remarks>
        /// In the pseudocode provided by: 
        /// https://en.wikipedia.org/wiki/Quicksort#Algorithm
        /// quicksort(...) == RecursiveSort(...)
        /// partition(...) == Partition(...)
        /// </remarks>
        /// <param name="numbersToSort">The array of integer numbers to sort.</param>
        /// <returns>The sorted integer array.</returns>
        public override int[] Sort(int[] numbersToSort)
        {
            RecursiveSort(numbersToSort, 0, numbersToSort.Length - 1);

            return numbersToSort;
        }
    }
}