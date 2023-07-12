using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScrabbleScorer.Models;
using System.Collections.Generic;
using System;

namespace ScrabbleScorer.Tests
{
    [TestClass]
    public class ScrabbleScorerTest
    {
        [TestMethod]
        public void BreakIntoLetters_ShouldReturnCharacterArray()
        {
            // Arrange
            string userInput = "hello";
            char[] actualResult = ScrabbleScorerClass.BreakIntoLetters(userInput);
            // Expected
            char[] expectedResult = { 'h', 'e', 'l', 'l', 'o' };

            // Act


            // Assert
            CollectionAssert.AreEqual(expectedResult, actualResult);
        }
    }
}