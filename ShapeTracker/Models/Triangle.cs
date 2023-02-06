namespace ShapeTracker.Models 
{
  public class Triangle 
  {
    public int Side1;
    public int Side2;
    public int Side3;

    public Triangle(int length1, int length2, int length3) 
    {
      Side1 = length1;
      Side2 = length2;
      Side3 = length3;
    }

    public string CheckType() 
    {
      if ((Side1 > (Side2 + Side3)) || (Side2 > (Side1 + Side3)) || (Side3 > (Side1 + Side2)))
      {
        return "not a triangle";
      } 
      else if ((Side1 != Side2) && ((Side1 != Side3)) && ((Side2 != Side3))) 
      {
        return "scalene triangle";
      }  
      else if ((Side1 == Side2) && (Side1 == Side3)) 
      {
        return "equilateral triangle";
      } 
      else 
      {
        return "isosceles triangle";
      }
    }
  }
}
