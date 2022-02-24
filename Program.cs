using System;
using RPGOOPDIO.src.entities;

namespace RPGOOPDIO
{
    class Program
    {
        static void Main(string[] args)
        {
            Personagem arus = new Personagem("Arus", 42);
            arus.HeroType = new Guerreiro();

            Personagem sura = new Personagem("Sura", 43);
            sura.HeroType = new Vermelho();

            Console.WriteLine(arus);
            Console.WriteLine(sura);

            Console.WriteLine(arus.Ataque(4));
            Console.WriteLine(sura.Ataque(8));
        }
    }
}
