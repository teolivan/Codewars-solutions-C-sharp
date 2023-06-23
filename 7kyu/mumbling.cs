/* This time no story, no theory. The examples below show you how to write function accum:

Examples:
accum("abcd") -> "A-Bb-Ccc-Dddd"
accum("RqaEzty") -> "R-Qq-Aaa-Eeee-Zzzzz-Tttttt-Yyyyyyy"
accum("cwAt") -> "C-Ww-Aaa-Tttt"
The parameter of accum is a string which includes only letters from a..z and A..Z. */

//My solutions

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;


public class Accumul 
{
	public static String Accum(string s) 
  {
  // s.ToUpper();
    string full = "";
    for(int i = 0; i < s.Length; i++) {
      full += char.ToUpper(s[i]) + string.Concat(Enumerable.Repeat(char.ToLower(s[i]), i)) + "-";
     
    }
   return full.Remove(full.Length - 1);
  }
}