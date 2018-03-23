using System;
using interfaces.Interfaces;

namespace interfaces.Models
{
  public class Squirrel : IFly
  {
    public int FlightSpeed { get; set; }
    public string FlyStyle { get; set; }

    public void Fly()
    {
      Console.WriteLine("I AM A FLYING SQUIRRELL PEW PEW PEW");
      
    }
  }
}