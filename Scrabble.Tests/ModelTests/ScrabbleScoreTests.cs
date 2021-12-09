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
    // [TestMethod]
    // public void GetScrabbleWord_ReturnsAString_String()
    // {
    //   ScrabbleScore testScore = "word";
    //   Assert.AreEqual()
    // }
  }
}