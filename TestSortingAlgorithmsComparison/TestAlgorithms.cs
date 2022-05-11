using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algorithms;
using System;
namespace TestSortingAlgorithmsComparison;

[TestClass]
public class TestAlgorithms
{
    private int[] initialNumbers;
    private int[] numbersToSort;
    private int[] arraySizes;
    private int currentArraySize = 0;
    
    [TestMethod]
    public void TestBubbleSort()
    {
        arraySizes = new int[5] { 10, 100, 1000, 10000, 100000 };
        currentArraySize = 0;

        for (int i = 0; i < arraySizes.Length; i++, currentArraySize++)
        {
            initialNumbers = new int[arraySizes[currentArraySize]];
            numbersToSort = new int[arraySizes[currentArraySize]];

            GenerateInitialNumbers();

            SortingAlgorithm bubbleSort = new BubbleSort();
            Assert.IsTrue(DetermineWhetherSuccessful(bubbleSort.Sort(numbersToSort)));
        }
    }
    
    
    [TestMethod]
    public void TestInsertionSort()
    {
        arraySizes = new int[5] { 10, 100, 1000, 10000, 100000 };
        currentArraySize = 0;

        for (int i = 0; i < arraySizes.Length; i++, currentArraySize++)
        {
            initialNumbers = new int[arraySizes[currentArraySize]];
            numbersToSort = new int[arraySizes[currentArraySize]];

            GenerateInitialNumbers();

            SortingAlgorithm insertionSort = new InsertionSort();
            Assert.IsTrue(DetermineWhetherSuccessful(insertionSort.Sort(numbersToSort)));
        }
    }


    public bool DetermineWhetherSuccessful(int[] numbersToSort)
    {
        for (int i = 1; i < numbersToSort.Length; i++)
        {            
            if (numbersToSort[i - 1] > numbersToSort[i])
            {
                return false;
            }
        }

        return true;
    }
    
    private void ResetNumbers()
    {
        initialNumbers.CopyTo(numbersToSort, 0);
    }

    public void GenerateInitialNumbers()
    {
        Random randomNumberGenerator = new Random();
        
        for (int i = 0; i < arraySizes[currentArraySize]; i++)
        {
            initialNumbers[i] = randomNumberGenerator.Next();
        }

        ResetNumbers();
    }
}