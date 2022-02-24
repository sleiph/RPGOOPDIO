namespace RPGOOPDIO.src.entities {
  public class Classe {
    public string Nome { get; set; }

    public Classe(string Nome) {
      this.Nome = Nome;
    }

    public override string ToString()
    {
      return Nome;
    }
  }
}
