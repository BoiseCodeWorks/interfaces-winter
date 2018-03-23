namespace interfaces.Interfaces
{

  interface IFly
  {
    int FlightSpeed { get; set; }
    string FlyStyle { get; set; }

    void Fly();

  }

}