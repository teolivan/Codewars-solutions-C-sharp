/*Complete the solution so that it reverses the string passed into it.

'world'  =>  'dlrow'
'word'   =>  'drow'*/

//My solution

using System;

public static class Kata
{
  public static string Solution(string str) 
  {
    char[] charArray = str.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
  }
}