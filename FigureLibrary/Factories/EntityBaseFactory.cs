
using System;
using FigureLibrary.Models;

namespace FigureLibrary.Factories
{
  public abstract class EntityBaseFactory
  {
    public abstract Figure CreateFigure();
  }
}

