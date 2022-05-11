namespace Algorithms
{
    /// <summary>
    /// Quick Sort Implementation
    /// </summary>
    public class QuickSort : SortingAlgorithm
    {
        private void RecursiveSort(int[] numbersToSort, int start, int end)
        {
            int i;
            if (start < end)
            {
                i = Partition(numbersToSort, start, end);

                RecursiveSort(numbersToSort, start, i - 1);
                RecursiveSort(numbersToSort, i + 1, end);
            }
        }

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

        public override int[] Sort(int[] numbersToSort)
        {
            RecursiveSort(numbersToSort, 0, numbersToSort.Length - 1);

            return numbersToSort;
        }
    }
}