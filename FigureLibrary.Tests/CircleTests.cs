
using FigureLibrary.Factories;
using FigureLibrary.Models;

namespace FigureLibrary.Tests;

public class Tests
{
  EntityBaseFactory factory;

  [SetUp]
  public void Setup() { }

  [Test]
  public void GetFigureArea_CircleFactory_CorrectAreaResult()
  {
    factory = CircleFactory.CreateFactory(10);
    Figure figure = factory.CreateFigure();

    double area = figure.GetFigureArea();

    Assert.That(Math.Truncate(area), Is.EqualTo(314));
  }

  [Test]
  public void GetFigureArea_CircleFactory_InCorrectAreaResult()
  {
    factory = CircleFactory.CreateFactory(23);
    Figure figure = factory.CreateFigure();

    double area = figure.GetFigureArea();

    Assert.That(area, Is.Not.EqualTo(31));
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
