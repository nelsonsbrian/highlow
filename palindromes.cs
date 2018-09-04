using System;
using System.Collections.Generic;


public class Program
{

  public static void CharPalindrome(string word)
  {
    char[] arrayWord = word.ToCharArray();
    char[] reverseWord = word.ToCharArray();
    Array.Reverse(reverseWord);


    string revWord = "";
    foreach (char letter in reverseWord)
    {
      revWord += letter;
    }
    string forWord = "";
    foreach (char letter in arrayWord)
    {
      forWord += letter;
    }

    Console.WriteLine("Input word: " + forWord + " compared to reversed: " + revWord);
    if (forWord == revWord)
    {
      Console.WriteLine(word + " is a palindrome!!");
    }
    else
    {
      Console.WriteLine(word + " is NOT a palindrome");
    }
  }

  public static void Main()
  {
    Console.WriteLine("Input a word and see if its a palindrome!");
    string word = Console.ReadLine();
    CharPalindrome(word);

    // Console.WriteLine(reverseWord.GetValue(0));
    // reverseWord[0] = Array.Reverse(arrayWord[0]);
    // Console.WriteLine(reverseWord.GetValue(0));
    // if (arrayWord == reverseWord)
    // {
    //   Console.WriteLine("this is a palindrome");
    // }


  }
}
