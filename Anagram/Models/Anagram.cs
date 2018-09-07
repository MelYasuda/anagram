using System.Collections.Generic;
using System;

namespace Anagram.Models
{
  public class Anagramz
  {
    private string _inputString = "billy";
    private static List<Anagramz> _listWord = new List<Anagramz> {};

    public string GetString()
    {
      return _inputString;
    }

    public void SetString(string inputString)
    {
      _inputString = inputString;
    }

    public char[] WordIntoArray()
    {
      char[] charArray = _inputString.ToCharArray();
      return charArray;
    }
    public string SortArray()
    {
      char[] charArray = _inputString.ToCharArray();
      Array.Sort(charArray);
      string strinArray = new string(charArray);
      return strinArray;
    }
    public void Save()
    {
      _listWord.Add(this);
    }
    public static List<Anagramz> GetAll()
    {
      return _listWord;
    }


  }


  public class program
  {
    public static void Main()
    {
      Console.WriteLine("Welcome to Anagram! Enter a word");
    }
  }
}
