/* Your team is writing a fancy new text editor and you've been tasked with implementing the line numbering.

Write a function which takes a list of strings and returns each line prepended by the correct number.

The numbering starts at 1. The format is n: string. Notice the colon and space in between.

Examples: (Input --> Output)

[] --> []
["a", "b", "c"] --> ["1: a", "2: b", "3: c"] */

//My solution

using System.Collections.Generic;
public class LineNumbering 
{
    public static List<string> Number(List<string> lines) 
    {
      for(int i = 0; i < lines.Count; i++) {
        string count = (i+1).ToString() + ": ";
         lines[i] = lines[i].Insert(0,  (i+1).ToString() + ": ");
      }
       
      
      return lines;
      
    }
}