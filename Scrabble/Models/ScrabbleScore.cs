using System.Collections.Generic;
using System;

namespace Scrabble.Models
{
  public class ScrabbleScore
  {
    public string Word { get; }
    private static Dictionary<string, int> ScrabbleDictionary = new Dictionary<string, int>() 
      {
        {"a", 1}, {"b", 3}, {"c", 3}, {"d", 2}, {"e", 1}, {"f", 4}, {"g", 2}, {"h", 4}, {"i", 1}, {"j", 8}, {"k", 5}, {"l", 1}, {"m", 3}, {"n", 1}, {"o", 1}, {"p", 3}, {"q", 10}, {"r", 1}, {"s", 1}, {"t", 1}, {"u", 1}, {"v", 4}, {"w", 4}, {"x", 8}, {"y", 4}, {"z", 10}
      };

    public ScrabbleScore(string word)
    {
      Word = word;
    }

    public static int GetLetterScore(string letter)
    {
      return ScrabbleDictionary[letter.ToLower()];
    }

    public int GetWordScore()
    {
      int total = 0;
      char[] wordArray = Word.ToCharArray();
      foreach (char letter in wordArray)
      {
        total += ScrabbleScore.GetLetterScore(letter.ToString());
      }
      return total;
    }
  }
}