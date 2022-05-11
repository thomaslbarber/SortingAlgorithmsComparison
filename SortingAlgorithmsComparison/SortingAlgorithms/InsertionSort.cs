namespace Algorithms
{
    /// <summary>
    /// Insertion Sort Implementation
    /// </summary>
    public class InsertionSort : SortingAlgorithm
    {
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