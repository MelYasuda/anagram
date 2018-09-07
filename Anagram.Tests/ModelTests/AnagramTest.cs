using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Anagram.Models;


  [TestClass]
  public class AnagramTest
  {
    [TestMethod]
    public void ReturnString_ReturnsAString_ReturnsReturnString ()
    {
      Anagramz bongo = new Anagramz();
      string bill = "Matthew";
      bongo.SetString(bill);
      string testString = bongo.GetString();
      Assert.AreEqual(bill, testString);
    }
    [TestMethod]
    public void WordIntoArray_ReturnArray ()
    {
      Anagramz word = new Anagramz();
      char[] charArray = {'c','h','a','n'};
      word.SetString("chan");
      char[] test = word.WordIntoArray();
      CollectionAssert.AreEqual(test, charArray);
    }
    [TestMethod]
    public void SortArray_ReturnReversedArray ()
    {
      Anagramz word = new Anagramz();
      char[] charArray = {'a','c','h','n'};
      string charString = new string(charArray);
      word.SetString("chan");
      string test = word.SortArray();
      Assert.AreEqual(test, charString);
    }
  }
