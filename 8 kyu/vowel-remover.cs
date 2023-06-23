/* Create a function called shortcut to remove the lowercase vowels (a, e, i, o, u ) in a given string.

Examples
"hello"     -->  "hll"
"codewars"  -->  "cdwrs"
"goodbye"   -->  "gdby"
"HELLO"     -->  "HELLO" */

//My solution

public class Kata
{
  public static string Shortcut(string input)
  {
  
   
      char[] result = input.ToCharArray();
    string s = "";
      
       for(int i = 0; i < input.Length; i++) { 
         if(result[i] != 'a' && result[i] != 'e' && result[i] != 'i' && result[i] != 'o' && result[i] != 'u' ) {
            s += result[i].ToString();
         }
         }
     
         return s;
    }
}
