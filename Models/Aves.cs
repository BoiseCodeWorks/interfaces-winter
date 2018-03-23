using System;
using interfaces.Interfaces;

namespace interfaces.Models
{
  public abstract class Aves : Animalia, IFly 
  {
    public bool Teeth { get; set; }
    public bool Feathers { get; set; }
    public int FlightSpeed { get ; set; }
    public string FlyStyle { get; set; }

    public void Reproduce()
    {
      Console.WriteLine("I Lay Eggs!");
    }

    public virtual void Fly()
    {
      Console.WriteLine("I Believe I can fly");
    }

    public Aves()
    {
      Teeth = false;
      Feathers = true;
    }

  }
}