namespace RPGOOPDIO.src.entities {
  public class Personagem {
    public string Nome { get; set; }
    public int Level { get; set; }
    public Classe HeroType { get; set; }

    public Personagem(string Nome, int Level, string Classe) 
    {
      this.Nome = Nome;
      this.Level = Level;
      HeroType = new Classe(Classe);
    }

    public override string ToString()
    {
      return Nome + " level: " + Level + " - classe: " + HeroType;
    }
  }
}
