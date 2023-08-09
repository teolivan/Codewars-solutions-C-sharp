/*Write a function

Vowel2Index(string s)
that takes in a string and replaces all the vowels [a,e,i,o,u] with their respective positions within that string.
E.g:

Kata.Vowel2Index("this is my string") == "th3s 6s my str15ng"
Kata.Vowel2Index("Codewars is the best site in the world") == "C2d4w6rs 10s th15 b18st s23t25 27n th32 w35rld"
Your function should be case insensitive to the vowels.

*/

//My solution

using System;
using System.Text;

public class Kata
{
  public static string Vowel2Index(string str)
  {
     StringBuilder result = new StringBuilder();
        string vowels = "aeiouAEIOU";
        int position = 0;

        foreach (char c in str)
        {                 position++;

            if (vowels.Contains(c))
            {
                result.Append(position);
            }
            else
            {
                result.Append(c);
            }
        }

        return result.ToString();
  }
}