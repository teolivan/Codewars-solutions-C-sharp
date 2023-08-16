/*The rgb function is incomplete. Complete it so that passing in RGB decimal values will result in a hexadecimal representation being returned. Valid decimal values for RGB are 0 - 255. Any values that fall out of that range must be rounded to the closest valid value.

Note: Your answer should always be 6 characters long, the shorthand with 3 will not work here.

Examples (input --> output):
255, 255, 255 --> "FFFFFF"
255, 255, 300 --> "FFFFFF"
0, 0, 0       --> "000000"
148, 0, 211   --> "9400D3"*/
//My solution

using System; 
public class Kata
{
  public static string Rgb(int r, int g, int b) 
  {
   r = Math.Max(0, Math.Min(255, r)); 
        g = Math.Max(0, Math.Min(255, g));
        b = Math.Max(0, Math.Min(255, b));

        string hexR = r.ToString("X2");
        string hexG = g.ToString("X2");
        string hexB = b.ToString("X2");

        return hexR + hexG + hexB;
  }
}