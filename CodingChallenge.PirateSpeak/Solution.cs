using System;
using System.Collections.Generic;
using System.Linq;

namespace CodingChallenge.PirateSpeak
{
    public class Solution
    {
        public string[] GetPossibleWords(string jumble, string[] dictionary)
        {
            var result = new List<string>();
            var jumbleSorted = new string(jumble.ToCharArray().OrderBy(x => x).ToArray());

            foreach (var word in dictionary)
            {
                if (word.Length == jumble.Length)
                {
                    var wordSorted = new string(word.ToCharArray().OrderBy(x => x).ToArray());

                    if (string.Equals(wordSorted,jumbleSorted,StringComparison.OrdinalIgnoreCase))
                        result.Add(word);
                }

                //if (word.Length == jumble.Length)
                //{
                //    var wordCharacters = word.ToCharArray().ToList();
                //    var numberOfMatches = 0;

                //    foreach (var character in jumbleCharacters)
                //    {
                //        if (wordCharacters.Contains(character))
                //        {
                //            wordCharacters.Remove(character);
                //            numberOfMatches++;
                //        }
                //    }

                //    if (numberOfMatches == jumble.Length)
                //        result.Add(word);
                //}
            }

            return result.ToArray();
        }
    }
}