namespace interfaces.Models
{
  public class Parrot : Aves
  {
    public string Name { get; set; }

    public string Color { get; set; }

    public void Mimic(string sentence)
    {
      System.Console.WriteLine("SQUAWK "+ sentence);
    }


    public Parrot(string name, string color)
    {
      Name = name;
      Color = color;
    }

  }

}