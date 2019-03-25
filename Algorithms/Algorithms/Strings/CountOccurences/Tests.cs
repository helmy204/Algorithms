using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Algorithms.CountRepeatedWordInText
{
    public class Tests
    {
        [Fact]
        public void CountOccurences_1()
        {
            // Arrange
            string text = "hello world";
            string word = "hello";

            // Act
            int actual = CountOccurences.CountOccurences_1(text, word);

            // Assert
            int expected = 1;
            Assert.Equal(expected, actual);
        }
    }
}
