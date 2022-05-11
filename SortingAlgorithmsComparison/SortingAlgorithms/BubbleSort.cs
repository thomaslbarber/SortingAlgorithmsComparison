namespace Algorithms
{
    /// <summary>
    /// Bubble Sort Implementation
    /// </summary>
    public class BubbleSort : SortingAlgorithm
    {
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