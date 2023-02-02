using System;
using ShapeTracker.Models;

namespace ShapeTracker
{
  class Program
  {
    static void Main()
    {
      Triangle testTriangle = new Triangle(3,6,3);
      Console.WriteLine($"Side one of the triangle: {testTriangle.Side1}");
      Console.WriteLine($"Side two of the triangle: {testTriangle.Side2}");
      Console.WriteLine($"Side three of the triangle: {testTriangle.Side3}");
      Console.WriteLine("Want to know what type of triangle you have?");
      Console.WriteLine("Calculating...");
      Console.WriteLine($"Your triangle is: {testTriangle.CheckType()}.");
    }
  }
}