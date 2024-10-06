using System;
using FigureLibrary.Models;

namespace FigureLibrary.Factories
{
  public class CircleFactory : EntityBaseFactory
  {
    private double radius;
    private CircleFactory() { }

    public override Figure CreateFigure()
      => Circle.New(radius);

    public static CircleFactory CreateFactory(double rad)
      => new CircleFactory() {
        radius = Math.Abs(rad)
      };
  }
}

