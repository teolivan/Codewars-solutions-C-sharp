/*Clock shows h hours, m minutes and s seconds after midnight.

Your task is to write a function which returns the time since midnight in milliseconds.

Example:
h = 0
m = 1
s = 1

result = 61000
Input constraints:

0 <= h <= 23
0 <= m <= 59
0 <= s <= 59*/

//My solution

  using System;
  public static class Clock
  {
    public static int Past(int h, int m, int s)
    {
     h = h*60000 * 60;
    m=  m*60000;
    s=  s*1000;
      
      return h+m+s;
    }
  }
