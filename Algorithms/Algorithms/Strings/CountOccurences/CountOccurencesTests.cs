using NUnit.Framework;

namespace Algorithms.Strings.CountOccurences
{
    public class Tests
    {
        [Test]
        public void CountOccurences_1()
        {
            // Arrange
            string text = "hello world";
            string word = "hello";

            // Act
            int actual = CountOccurences.CountOccurences_1(text, word);

            // Assert
            int expected = 1;
            Assert.AreEqual(expected, actual);
        }
    }
}
