using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algorithms;
using System;
using SortingAlgorithmsComparison;

namespace TestSortingAlgorithmsComparison;

[TestClass]
public class TestAlgorithms
{
    [TestMethod]
    public void TestBubbleSort()
    {
        Utilities.CurrentArraySize = 0;
        
        for (int i = 0; i < Utilities.ArraySizes.Length; i++, Utilities.CurrentArraySize++)
        {
            Utilities.GenerateInitialNumbers(Utilities.ArraySizes[Utilities.CurrentArraySize]);

            SortingAlgorithm bubbleSort = new BubbleSort();
            Assert.IsTrue(Utilities.DetermineWhetherSuccessful(bubbleSort.Sort(Utilities.NumbersToSort)));
        }
    }
    
    [TestMethod]
    public void TestCocktailSort()
    {
        Utilities.CurrentArraySize = 0;

        for (int i = 0; i < Utilities.ArraySizes.Length; i++, Utilities.CurrentArraySize++)
        {
            Utilities.GenerateInitialNumbers(Utilities.ArraySizes[Utilities.CurrentArraySize]);

            SortingAlgorithm cocktailSort = new CocktailSort();
            Assert.IsTrue(Utilities.DetermineWhetherSuccessful(cocktailSort.Sort(Utilities.NumbersToSort)));
        }
    }
    
    [TestMethod]
    public void TestInsertionSort()
    {
        Utilities.CurrentArraySize = 0;

        for (int i = 0; i < Utilities.ArraySizes.Length; i++, Utilities.CurrentArraySize++)
        {
            Utilities.GenerateInitialNumbers(Utilities.ArraySizes[Utilities.CurrentArraySize]);

            SortingAlgorithm insertionSort = new InsertionSort();
            Assert.IsTrue(Utilities.DetermineWhetherSuccessful(insertionSort.Sort(Utilities.NumbersToSort)));
        }
    }
    
    [TestMethod]
    public void TestSelectionSort()
    {
        Utilities.CurrentArraySize = 0;

        for (int i = 0; i < Utilities.ArraySizes.Length; i++, Utilities.CurrentArraySize++)
        {
            Utilities.GenerateInitialNumbers(Utilities.ArraySizes[Utilities.CurrentArraySize]);

            SortingAlgorithm selectionSort = new SelectionSort();
            Assert.IsTrue(Utilities.DetermineWhetherSuccessful(selectionSort.Sort(Utilities.NumbersToSort)));
        }
    }
    
    [TestMethod]
    public void TestQuickSort()
    {
        Utilities.CurrentArraySize = 0;

        for (int i = 0; i < Utilities.ArraySizes.Length; i++, Utilities.CurrentArraySize++)
        {
            Utilities.GenerateInitialNumbers(Utilities.ArraySizes[Utilities.CurrentArraySize]);

            SortingAlgorithm quickSort = new QuickSort();
            Assert.IsTrue(Utilities.DetermineWhetherSuccessful(quickSort.Sort(Utilities.NumbersToSort)));
        }
    }


}