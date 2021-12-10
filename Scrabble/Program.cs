using System;
using Scrabble.Models;

namespace UI 
{
  public class Program 
  {
    static void Main()
    {
      Console.WriteLine("Looking for a Scrabble Score? Enter a word!");
      string input = Console.ReadLine();
      ScrabbleScore inputWord = new ScrabbleScore(input);
      inputWord.GetWordScore();
      int superFinalTotal = inputWord.GetWordScore();
      Console.WriteLine("That word would net you a whopping " + superFinalTotal.ToString() + " points!");
    }
  } 
}

