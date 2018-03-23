using System;
using System.Collections.Generic;
using interfaces.Interfaces;
using interfaces.Models;

namespace interfaces
{
  class Program
  {
    static void Main(string[] args)
    {
      IFly popper = new Penguin("Spheniscidae", 8);
      Parrot tweety = new Parrot("Tweety", "yellow");
      Squirrel squirrel = new Squirrel();

      Dictionary<string, List<IFly>> FlyingCreatures = new Dictionary<string, List<IFly>>();
      List<IFly> birds = new List<IFly>(){popper, tweety};
    //   birds.Add(popper);
    //   birds.Add(tweety);
      FlyingCreatures["birds"] = birds;
      FlyingCreatures["non-birds"] = new List<IFly>(){squirrel, tweety};

        //Itterates over object keys and values calling each pair 'types'
      foreach(KeyValuePair<string, List<IFly>> types in FlyingCreatures)
      {
          System.Console.WriteLine(types.Key);

            //Itterates over inner lists 
          for (int i = 0; i < types.Value.Count; i++)
          {
              types.Value[i].Fly();
          }
      }

    }
  }
}
