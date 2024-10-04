using System;
using FigureLibrary.Models;

namespace FigureLibrary.Factories
{
  public class TriangleFactory : EntityBaseFactory
  {
    private double a_side;
    private double b_side;
    private double c_side;

    private TriangleFactory() { }

    public override Figure CreateFigure()
      => Triangle.New(a_side, b_side, c_side);

    public static TriangleFactory CreateFactory(double a, double b, double c)
      => new TriangleFactory()
      {
        a_side = a,
        b_side = b,
        c_side = c
      };
  }
}

