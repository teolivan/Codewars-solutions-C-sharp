/*Given a string, you have to return a string in which each character (case-sensitive) is repeated once.

Examples (Input -> Output):
* "String"      -> "SSttrriinngg"
* "Hello World" -> "HHeelllloo  WWoorrlldd"
* "1234!_ "     -> "11223344!!__  "
Good Luck!*/

//My solution

using System;
using System.Text;
public class Kata
{
  public static string DoubleChar(string s)
  {
    
 StringBuilder builder = new StringBuilder(s.Length * 2);
  for ( int index = 0; index < s.Length; index++ )
    builder.Append(s[index], 2);
  return builder.ToString();
  }
}