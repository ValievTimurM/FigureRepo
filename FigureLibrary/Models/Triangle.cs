using System;
using System.IO;

namespace FigureLibrary.Models
{
  public class Triangle : Figure
  {
    private Triangle() { }

    public double A_side { get; set; }
    public double B_side { get; set; }
    public double C_side { get; set; }
    
    public override double GetFigureArea()
    {
      double p = (A_side + B_side + C_side) / 2;

      return Math.Sqrt(p * (p - A_side) * (p - B_side) * (p - C_side));
    }

    public bool IsRightAngled()
    {
      double[] sides = new double[] { A_side, B_side, C_side };
      Array.Sort(sides);
      A_side = sides[0];
      B_side = sides[1];
      C_side = sides[2];

      return Math.Pow(A_side, 2) + Math.Pow(B_side, 2) == Math.Pow(C_side, 2);
    }

    public static Triangle New(double a, double b, double c)
      => new Triangle
      {
        A_side = Math.Abs(a),
        B_side = Math.Abs(b),
        C_side = Math.Abs(c)
      };
  }
}

