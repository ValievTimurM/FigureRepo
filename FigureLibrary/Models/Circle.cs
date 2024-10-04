using System;
namespace FigureLibrary.Models
{
  public class Circle : Figure
  {
    private Circle() { }

    public double Radius { get; set; }

    public override double GetFigureArea()
    {
      return Math.PI * Math.Pow(Radius, 2);
    }

    public static Circle New(double radius)
      => new Circle{
        Radius = radius
      };
  }
}

