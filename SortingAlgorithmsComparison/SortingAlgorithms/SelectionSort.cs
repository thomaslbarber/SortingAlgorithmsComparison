namespace Algorithms 
{
    /// <summary>
    /// Selection Sort Implementation
    /// </summary>
    public class SelectionSort : SortingAlgorithm
    {
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