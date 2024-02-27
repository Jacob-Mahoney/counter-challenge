using System.Linq;
using System.Text.RegularExpressions;

namespace CounterChallenge
{
    public class CounterChallenge
    {
        public string GetOutput(string input)
        {
            string currentWord = string.Empty;

            string output = string.Empty;

            for (int i = 0; i < input.Length; i++)
            {
                string currentCharacter = input[i].ToString();

                bool isCharacterALetter = Regex.IsMatch(currentCharacter, "^[a-zA-Z]{1}$");

                if (isCharacterALetter)
                {
                    currentWord += currentCharacter;
                }

                // if the current character is not a letter or if we've reached the end of the input
                // then the current word is finished and it's time to add it to the output string
                if (!isCharacterALetter || i == (input.Length - 1))
                {
                    // if the length of the word is 2 or less characters than the number of distinct characters between them
                    // would obviously be 0
                    int numberOfDistinctCharacters = currentWord.Length > 2 ? currentWord.Substring(1, currentWord.Length - 2).Distinct().Count() : 0;

                    // if the current word only has a length of 1 character then just simply have to output that
                    output += currentWord.Length > 1 ? currentWord[0].ToString() + numberOfDistinctCharacters + currentWord[currentWord.Length - 1].ToString() : currentWord;

                    // if the current character is specifically not a letter
                    // than we'll want to make sure to add that to the output string
                    // and empty out the current word variable to make way for the next word
                    if (!isCharacterALetter)
                    {
                        output += currentCharacter;
                        currentWord = string.Empty;
                    }
                }
            }

            return output;
        }
    }
}