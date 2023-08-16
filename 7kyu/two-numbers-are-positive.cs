/*Task:
Your job is to write a function, which takes three integers a, b, and c as arguments, and returns True if exactly two of of the three integers are positive numbers (greater than zero), and False - otherwise.

Examples:
TwoArePositive(2, 4, -3) == true
TwoArePositive(-4, 6, 8) == true
TwoArePositive(4, -6, 9) == true
TwoArePositive(-4, 6, 0) == false
TwoArePositive(4, 6, 10) == false
TwoArePositive(-14, -3, -4) == false*/

//My solution

namespace Solution {
    public static class Kata {
        public static bool TwoArePositive(int a, int b, int c) {
            if(a > 0 && b > 0 && c <= 0) {
              return true;
            } else if ( a > 0 && b <= 0 && c > 0) {
              return true;
            } else if (a <= 0 && b > 0 && c > 0) {
              return true;
            } else {
              return false;
            }
        }
    }
}