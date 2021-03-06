using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;

namespace WordCounterApp.Models
{
  public class RepeatCounter
  {
    private static int _wordCount;
    private static string _userWord;
    private static string _userSentence;

    public static int WordCountCalc(string userWord, string userSentence)
    {
      _userWord = userWord;
      _userSentence = userSentence;
      userWord = userWord.ToLower();
      string[] userSentenceArray = userSentence.ToLower().Split();
      foreach(string word in userSentenceArray)
      {
        if(word == userWord)
        {
          _wordCount += 1;
        }
      }
      return _wordCount;
    }

    public static int GetWordCount()
    {
      return _wordCount;
    }

    public static string GetUserWord()
    {
      return _userWord;
    }

    public static string GetUserSentence()
    {
      return _userSentence;
    }

    public static void ClearAll()
    {
      _wordCount = 0;
    }
  }
}
