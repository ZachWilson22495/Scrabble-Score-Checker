using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using Scrabble.Models;

namespace Scrabble.Models.Tests
{
  [TestClass]
  public class ScrabbleScoreTests
  {
    [TestMethod]
    public void ScrabbleScoreConstructor_CreatesInstanceOfScrabbleScore_ScrabbleScore()
    {
      ScrabbleScore testScore = new ScrabbleScore("word");
      Assert.AreEqual(typeof(ScrabbleScore), testScore.GetType());
    }
    [TestMethod]
    public void GetScrabbleWord_ReturnsAString_String()
    {
      ScrabbleScore testScore = new ScrabbleScore("word");
      Assert.AreEqual(typeof(String), testScore.Word.GetType());
    }
    [TestMethod]
    public void GetScrabbleWord_ReturnsAString_ReturnsBunnies()
    {
      ScrabbleScore testScore = new ScrabbleScore("Bunnies");
      Assert.AreEqual("Bunnies", testScore.Word);
    }
    [TestMethod]
    public void GetLetterScore_ReturnsScoreForALetter_int()
    {
      Assert.AreEqual(ScrabbleScore.GetLetterScore("b"), 3);
      Assert.AreEqual(ScrabbleScore.GetLetterScore("z"), 10);
      Assert.AreEqual(ScrabbleScore.GetLetterScore("h"), 4);
    }
    [TestMethod]
    public void GetLetterScore_ReturnsScoreForALetterInUpperCase_int()
    {
      Assert.AreEqual(ScrabbleScore.GetLetterScore("B"), 3);
      Assert.AreEqual(ScrabbleScore.GetLetterScore("Z"), 10);
      Assert.AreEqual(ScrabbleScore.GetLetterScore("H"), 4);
    }
  }
}