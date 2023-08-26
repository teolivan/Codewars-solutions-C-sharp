/*Write a function that accepts an integer n and a string s as parameters, and returns a string of s repeated exactly n times.

Examples (input -> output)
6, "I"     -> "IIIIII"
5, "Hello" -> "HelloHelloHelloHelloHello"*/

//My solution

using System.Linq;

namespace Solution
{
  public static class Program
  {
    public static string RepeatStr(int n, string s)
    {
      return string.Concat(Enumerable.Repeat(s, n));
    }
  }
}