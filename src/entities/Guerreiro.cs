namespace RPGOOPDIO.src.entities {
  public class Guerreiro : Classe {

    public Guerreiro() {
      Nome = "Guerreiro";
      Arma = "espada";
    }

    public override string ToString()
    {
      return Nome;
    }
  }
}
