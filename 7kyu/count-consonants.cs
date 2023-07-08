/*Complete the function that takes a string of English-language text and returns the number of consonants in the string.

Consonants are all letters used to write English excluding the vowels a, e, i, o, u.*/

//My solution

using System;
using System.Text.RegularExpressions;
public class Kata
{
  public static int ConsonantCount(string str)
  {
     var regex = new Regex("[bcdfghjklmnpqrstvwxyz]");
       return regex.Matches(str.ToLower()).Count;
    
    
    
  }
}