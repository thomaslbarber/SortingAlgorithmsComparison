using Microsoft.VisualStudio.TestTools.UnitTesting;
using SortingAlgorithmsComparison;

namespace TestSortingAlgorithmsComparison
{
    /// <summary>
    /// Tests the utility functions provided in Utilities.cs.
    /// </summary>
    [TestClass]
    public class TestUtilities
    {
        /// <summary>
        /// Tests the DetermineWhetherSuccessful() function using some correctly sorted arrays.
        /// </summary>
        [TestMethod]
        public void TestDetermineWhetherSuccessfulCorrectValues()
        {
            int[] correctValues0 = new int[5] { 2, 6, 92, 4331, 282034 };
            int[] correctValues1 = new int[10] { -54, -27, -2, 0, 1, 6, 22, 59, 117, 235 };

            Assert.IsTrue(Utilities.DetermineWhetherSuccessful(correctValues0));
            Assert.IsTrue(Utilities.DetermineWhetherSuccessful(correctValues1));
        }

        /// <summary>
        /// Tests the DetermineWhetherSuccessful() function using some incorrectly sorted arrays.
        /// </summary>
        [TestMethod]
        public void TestDetermineWhetherSuccessfulIncorrectValues()
        {
            int[] correctValues0 = new int[5] { 2, 1, 92, 4331, 282034 };
            int[] correctValues1 = new int[10] { -54, -27, -2, 0, 7, 6, 22, 59, 117, 235 };

            Assert.IsFalse(Utilities.DetermineWhetherSuccessful(correctValues0));
            Assert.IsFalse(Utilities.DetermineWhetherSuccessful(correctValues1));
        }
    }
}