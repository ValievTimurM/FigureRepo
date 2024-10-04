using System;
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

    public static Triangle New(double a, double b, double c)
      => new Triangle
      {
        A_side = a,
        B_side = b,
        C_side = c
      };
  }
}

