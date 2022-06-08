namespace Algorithms
{
    /// <summary>
    /// Insertion Sort Implementation.
    /// </summary>
    public class InsertionSort : SortingAlgorithm
    {
        /// <summary>
        /// Implements sort using the insertion sort algorithm.
        /// </summary>
        /// <remarks> https://en.wikipedia.org/wiki/Insertion_sort </remarks>
        /// <param name="numbersToSort">The array of integer numbers to sort.</param>
        /// <returns>The sorted integer array.</returns>
        public override int[] Sort(int[] numbersToSort)
        {
            int currentValue;
            for (int i = 1; i < numbersToSort.Length; i++)
            {
                currentValue = numbersToSort[i];
                int j = i - 1;

                for (; j >= 0 && numbersToSort[j] > currentValue; j--)
                {
                    numbersToSort[j + 1] = numbersToSort[j];
                }

                numbersToSort[j + 1] = currentValue;
            }

            return numbersToSort;
        }
    }
}