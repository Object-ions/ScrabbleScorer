using System.Collections.Generic;

namespace ScrabbleScorer.Models
{
    public class ScrabbleScorerClass
    {
        public static Dictionary<int, string[]> lettersAndValues = new Dictionary<int, string[]>();

        // This method breaks a string into a character array
        public static char[] BreakIntoLetters(string userInput)
        {
            return userInput.ToCharArray();
        }
    }
}
/*
lettersAndValues.Add(1, new string[] { "A", "E", "I", "O", "U", "L", "N", "R", "S", "T" });
            lettersAndValues.Add(2, new string[] { "D", "G" });
            lettersAndValues.Add(3, new string[] { "B", "C", "M", "P" });
            lettersAndValues.Add(4, new string[] { "F", "H", "V", "W", "Y" });
            lettersAndValues.Add(5, new string[] { "K" });
            lettersAndValues.Add(8, new string[] { "J", "X" });
            lettersAndValues.Add(10, new string[] { "Q", "Z" });
*/