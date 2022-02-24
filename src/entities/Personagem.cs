namespace RPGOOPDIO.src.entities {
  public class Personagem {
    public string Nome { get; set; }
    public int Level { get; set; }
    public Classe HeroType { get; set; }

    public Personagem(string Nome, int Level) 
    {
      this.Nome = Nome;
      this.Level = Level;
    }

    public string Ataque(int Bonus) {
      if (Bonus > 6) {
        return Nome + " atacou fortão com " + HeroType.Arma;
      }
      else {
        return Nome + " atacou maisoumenos com " + HeroType.Arma;
      }
      
    }

    public override string ToString()
    {
      return Nome + " level: " + Level + " - classe: " + HeroType;
    }
  }
}
