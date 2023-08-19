/*
Title:
They say that only the name is long enough to attract attention. They also said that only a simple Kata will have someone to solve it. This is a sadly story #1: Are they opposite?

Task
Give you two strings: s1 and s2. If they are opposite, return true; otherwise, return false. Note: The result should be a boolean value, instead of a string.

The opposite means: All letters of the two strings are the same, but the case is opposite. you can assume that the string only contains letters or it's a empty string. Also take note of the edge case - if both strings are empty then you should return false/False.

Examples (input -> output)
"ab","AB"     -> true
"aB","Ab"     -> true
"aBcd","AbCD" -> true
"AB","Ab"     -> false
"",""         -> false
*/

//My solution

using System;

public class Kata
{
  public static bool IsOpposite(string s1, string s2)
  {
    
    int counter = 0;
   if(String.Equals(s1,s2)) {
     return false;
   } else if (s1.Length == 0 || s2.Length == 0) {
     return false;
   } else if (String.Equals(s1,s2, StringComparison.CurrentCultureIgnoreCase)){
   for(int i = 0; i < s1.Length; i++) {
     if(s1[i] != s2[i]) {
       counter++;
     } 
   }
     if(counter == s1.Length) {
       return true;
     } else {
       return false;
     }
     
   } else {
     return false;
   }
   
   }
  }
