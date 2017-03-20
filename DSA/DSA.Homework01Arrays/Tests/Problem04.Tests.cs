namespace Tests
{
    using NUnit.Framework;
    using Problem04;
    using System.Collections.Generic;
    using System.Linq;

    [TestFixture]
    public class Problem04Tests
    {
        [TestCase ("1 2 3 4 4 4 5 6 7", "4 4 4")]
        [TestCase ("56 18 0 0 0 8 15 15 15 15 92 38 46 55 92 18 4 58 21 4 4", "15 15 15 15")]
        [TestCase ("0 0 2", "0 0")]
        [TestCase ("1 2 3 4 3 6 6 6 6 99 999 9999 500 13 5103 50432 15 23 22 2", "6 6 6 6")]
        [TestCase ("42 42 42 42", "42 42 42 42")]
        [TestCase ("7", "7")]
        public void GetLongestSubsequenceReturnsCorrectArray(string initialListAsString, string expectedAsString)
        {
            // Arrange
            var list = initialListAsString
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            var expected = expectedAsString
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            // Act - StartUp.GetlongestSubsequence is a stupid name, I know...
            var subsequence = StartUp.GetLongestSubsequence(list);

            // Assert
            CollectionAssert.AreEqual(expected, subsequence);
        }
    }
}
