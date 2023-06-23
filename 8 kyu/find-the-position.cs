/* When provided with a letter, return its position in the alphabet.

Input :: "a"

Ouput :: "Position of alphabet: 1" */

//My solution

public class Kata
{
  public static string Position(char alphabet)
  {
    int position = 0;
    string alpha = "abcdefghijklmnopqrstuvwxyz";
    for (int i = 0; i < alpha.Length; i++) {
      position++;
      if (alpha[i] == alphabet) {
        break;
       
      }
      
    }
     string pos = "Position of alphabet: " +  position.ToString();
     return pos;
  }
}