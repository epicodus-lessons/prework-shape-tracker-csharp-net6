using System;
using ShapeTracker.Models;

namespace ShapeTracker
{
  class Program
  {
    static void Main()
    {
      Triangle testTriangle = new Triangle(3,4,5);
      Console.WriteLine($"Side one of the triangle: {testTriangle.GetSide1()}");
      Console.WriteLine($"Side two of the triangle: {testTriangle.GetSide2()}");
      Console.WriteLine($"Side three of the triangle: {testTriangle.GetSide3()}");
      Console.WriteLine("Want to know what type of triangle you have?");
      Console.WriteLine("Calculating...");
      Console.WriteLine($"Your triangle is: {testTriangle.CheckType()}.");
      Console.WriteLine("Updating...");
      testTriangle.SetSide1(44);
      testTriangle.SetSide2(44);
      testTriangle.SetSide3(70);
      Console.WriteLine($"Actually, I've just changed the values of your triangle's sides to {testTriangle.GetSide1()}, {testTriangle.GetSide2()}, and {testTriangle.GetSide3()}.");
      Console.WriteLine($"Now your triangle is: {testTriangle.CheckType()}.");
    }
  }
}