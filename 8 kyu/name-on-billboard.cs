/*You can print your name on a billboard ad. Find out how much it will cost you. Each character has a default price of £30, but that can be different if you are given 2 parameters instead of 1 (allways 2 for Java).

You can not use multiplier "*" operator.

If your name would be Jeong-Ho Aristotelis, ad would cost £600. 20 leters * 30 = 600 (Space counts as a character).*/

//My solution

public class Kata {
  public static double Billboard(string name, double price = 30) {

    double result = 0;
    
    foreach (char c in name)
    {
      result += price;
    }
    
    return result;
  }
}