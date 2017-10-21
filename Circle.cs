using System;
class MyCircle
{

  static void  Circlemethods(double radius, out double area, out double circumference)
    {
      area=Math.PI*Math.pow(radius,2)
      circumference=2*Math.PI*radius;
    }
static void Main()
{
double radius;
double area;
double circumference;
Console.WriteLine("Enter the radius of the circle");
radius=int.Parse(Console.ReadLine());
Circlemethods(radius, out area, out circumference);
Console.WriteLine("The area is {0} and the circumference is {1}",area,circumference);
}
}
