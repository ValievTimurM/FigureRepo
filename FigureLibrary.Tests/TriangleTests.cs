using FigureLibrary.Factories;
using FigureLibrary.Models;

namespace FigureLibrary.Tests;
public class TriangleTests
{
  EntityBaseFactory factory;

  [SetUp]
  public void Setup() { }

  [Test]
  public void GetFigureArea_TriangleFactory_CorrectAreaResult()
  {
    factory = TriangleFactory.CreateFactory(2, 3, 4);
    Figure figure = factory.CreateFigure();

    double area = figure.GetFigureArea();

    Assert.That(Math.Truncate(area), Is.EqualTo(2.0d));
  }

  [Test]
  public void GetFigureArea_TriangleFactory_InCorrectAreaResult()
  {
    factory = TriangleFactory.CreateFactory(2, 3, 4);
    Figure figure = factory.CreateFigure();

    double area = figure.GetFigureArea();

    Assert.That(area, Is.Not.EqualTo(3.0d));
  }

  [Test]
  public void IsRightAngled_TriangleFactory_TriangleIsRightAngled()
  {
    factory = TriangleFactory.CreateFactory(5, 3, 4);
    Figure figure = factory.CreateFigure();

    bool result = (figure as Triangle).IsRightAngled();

    Assert.IsTrue(result);
  }

  [Test]
  public void IsRightAngled_TriangleFactory_TriangleIsNotRightAngled()
  {
    factory = TriangleFactory.CreateFactory(5, 3, 10);
    Figure figure = factory.CreateFigure();

    bool result = (figure as Triangle).IsRightAngled();

    Assert.IsFalse(result);
  }
}


