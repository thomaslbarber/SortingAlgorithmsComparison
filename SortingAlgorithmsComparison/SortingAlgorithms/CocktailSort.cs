namespace Algorithms
{
    /// <summary>
    /// Cocktail Sort Implementation.
    /// </summary>
    public class CocktailSort : SortingAlgorithm
    {
        /// <summary>
        /// Implements sort using the cocktail sort algorithm.
        /// </summary>
        /// <remarks> https://en.wikipedia.org/wiki/Cocktail_shaker_sort </remarks>
        /// <param name="numbersToSort">The array of integer numbers to sort.</param>
        /// <returns></returns>
        public override int[] Sort(int[] numbersToSort)
        {
            bool swapped = true;
            
            int startPoint = 0;
            int endPoint = numbersToSort.Length;
 
            while (swapped) {
 
                swapped = false;

                for (int i = startPoint; i < endPoint - 1; ++i) {
                    if (numbersToSort[i] > numbersToSort[i + 1]) {
                        int temporary = numbersToSort[i];
                        numbersToSort[i] = numbersToSort[i + 1];
                        numbersToSort[i + 1] = temporary;
                        
                        swapped = true;
                    }
                }
                
                if (!swapped) { break; }

                swapped = false;
                endPoint--;

                for (int i = endPoint - 1; i >= startPoint; i--) {
                    if (numbersToSort[i] > numbersToSort[i + 1]) {
                        int temporary = numbersToSort[i];
                        numbersToSort[i] = numbersToSort[i + 1];
                        numbersToSort[i + 1] = temporary;
                        swapped = true;
                    }
                }
 
                startPoint++;
            }

            return numbersToSort;
        }
    }
}