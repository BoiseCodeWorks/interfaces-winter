namespace interfaces.Models
{
    
    public abstract class Animalia
    {
      public bool MultiCellular { get; set; }
      public bool Heterotrophic { get; set; }


      public Animalia()
      {
          MultiCellular = true;
          Heterotrophic = true;
      }

    }
}