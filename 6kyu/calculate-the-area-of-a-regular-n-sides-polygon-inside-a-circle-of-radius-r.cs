/*Write the following function:

public static double AreaOfPolygonInsideCircle(double circleRadius, int numberOfSides)
It should calculate the area of a regular polygon of numberOfSides, number-of-sides, or number_of_sides sides inside a circle of radius circleRadius, circle-radius, or circle_radius which passes through all the vertices of the polygon (such circle is called circumscribed circle or circumcircle). The answer should be a number rounded to 3 decimal places.

Input :: Output Examples

AreaOfPolygonInsideCircle(3, 3) // returns 11.691

AreaOfPolygonInsideCircle(5.8, 7) // returns 92.053

AreaOfPolygonInsideCircle(4, 5) // returns 38.042
Note: if you need to use Pi in your code, use the native value of your language unless stated otherwise.

*/

//My solution

namespace Solution {
  using System;
  public class Calculator {
    public static double AreaOfPolygonInsideCircle(double circleRadius, int numberOfSides) {
      double apothem = circleRadius * Math.Cos(Math.PI / numberOfSides);
        double sideLength = 2 * circleRadius * Math.Sin(Math.PI / numberOfSides);

        double area = 0.5 * numberOfSides * sideLength * apothem;
        return Math.Round(area, 3);
    }
  }
}