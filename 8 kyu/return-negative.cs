/* In this simple assignment you are given a number and have to make it negative. But maybe the number is already negative?

Examples
Kata.MakeNegative(1);  // return -1
Kata.MakeNegative(-5); // return -5
Kata.MakeNegative(0);  // return 0 */

//My solution

using System;

public static class Kata
{
  public static int MakeNegative(int number)
  {
    if (number > 0) {
      return number*-1;
    }
    else {
      return number;
    }
  }
}