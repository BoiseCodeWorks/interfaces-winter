namespace interfaces.Models
{
  public class Penguin : Aves
  {
    public string ScientificName { get; set; }
    public int CutenessLevel {get; set;}


    public void Swim()
    {
      System.Console.WriteLine("WEEEEEEE");
    }

    public override void Fly()
    {
      System.Console.WriteLine("I can't do it Captain");
    }


    public Penguin(string sciName, int cuteness)
    {
      ScientificName = sciName;
      CutenessLevel = cuteness;
    }

  }
}