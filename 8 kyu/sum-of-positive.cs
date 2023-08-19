/*You get an array of numbers, return the sum of all of the positives ones.

Example [1,-4,7,12] => 1 + 7 + 12 = 20

Note: if there is nothing to sum, the sum is default to 0.*/

//My solution

using System;
using System.Linq;

public class Kata
{
  public static int PositiveSum(int[] arr)
  {
    int sum = 0;
    if(arr.Length == 0) {
      return 0;
    } else {
     for (int i = 0; i < arr.Length; i++) {
       if (arr[i] > 0) {
         sum += arr[i];
       }
     } return sum;
    }
  }
}
