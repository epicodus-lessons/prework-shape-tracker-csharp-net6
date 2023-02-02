using System;
using ShapeTracker.Models;
using System.Collections.Generic;

namespace ShapeTracker
{
  class Program
  {
    static void Main()
    {
      List<Triangle> allTriangles = Triangle.GetAll();
      Triangle testTriangle = new Triangle(3,4,5);
      Triangle secondTriangle = new Triangle(32,74,75);
      // Triangle.ClearAll();
      if (allTriangles.Count == 0)
      {
        Console.WriteLine("There are no triangles!");
      }
      else
      {
        Console.WriteLine("You have triangles!");
        Console.WriteLine("----------------------------------");
        foreach (Triangle tri in allTriangles)
        {
          Console.WriteLine($"Side one of the triangle: {tri.GetSide1()}");
          Console.WriteLine($"Side two of the triangle: {tri.GetSide2()}");
          Console.WriteLine($"Side three of the triangle: {tri.GetSide3()}");
          Console.WriteLine("----------------------------------");
        }
      }
    }

    public static void PrintTriangles(List<Triangle> triangles)
    {
      if (triangles.Count == 0)
      {
        Console.WriteLine("There are no triangles!");
      }
      else
      {
        Console.WriteLine("----------------------------------");
        foreach (Triangle tri in triangles)
        {
          Console.WriteLine($"Side one of the triangle: {tri.GetSide1()}");
          Console.WriteLine($"Side two of the triangle: {tri.GetSide2()}");
          Console.WriteLine($"Side three of the triangle: {tri.GetSide3()}");
          Console.WriteLine("----------------------------------");
        }
      }
    }
  }
}